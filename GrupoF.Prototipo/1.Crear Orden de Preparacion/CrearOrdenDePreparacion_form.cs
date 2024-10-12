using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Base_de_Datos;
using System.Data;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    public partial class CrearOrdenDePreparacion_form : Form
    {
        private Datos_model Datos_model = new Datos_model();
        private CrearOrdnesDePreparacion_model CrearOrdnesDePreparacion_model = new CrearOrdnesDePreparacion_model();

        public CrearOrdenDePreparacion_form()
        {
            InitializeComponent();
            CargarDepositos();
        }

        private void button_aceptar_click(object sender, EventArgs e)
        {
            string Id_Cliente = IdCliente_textbox.Text.Trim();
            string Cantidad = Cantidad_textbox.Text.Trim();
            string NombreApellido = NombreApellido_TextBox.Text.Trim();
            string Dni = Dni_textbox.Text.Trim();

            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();
            string? mercaderiaSeleccionada = DescripcionMercaderia_ComboBox.SelectedItem?.ToString();


            if (depositoSeleccionado == "---")
            {
                MessageBox.Show("Debes seleccionar un depósito valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }


            if (mercaderiaSeleccionada == "---")
            {
                MessageBox.Show("Debes seleccionar una mercadería valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionMercaderia_ComboBox.Focus();
                return;
            }


            if (string.IsNullOrEmpty(Cantidad))
            {
                MessageBox.Show("El campo Cantidad no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (!Cantidad.All(char.IsDigit))
            {
                MessageBox.Show("El campo Cantidad solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }


            int dni;

            if (!int.TryParse(Dni, out dni))
            {
                MessageBox.Show("El campo Dni debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (Dni.Length != 8)
            {
                MessageBox.Show("El campo Dni debe ser tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (!Dni.All(char.IsDigit))
            {
                MessageBox.Show("El campo Dni solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (!Cantidad.All(char.IsDigit))
            {
                MessageBox.Show("El campo Cantidad debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreApellido))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreApellido_TextBox.Focus();
                return;
            }

            if (NombreApellido.Any(char.IsDigit))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede contener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreApellido))
            {
                MessageBox.Show("El campo Nombre y Apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreApellido_TextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Dni))
            {
                MessageBox.Show("El campo Dni no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dni_textbox.Focus();
                return;
            }


            MessageBox.Show("Se creo la orden de preparacion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();

        }

        private void button_salir_click(object sender, EventArgs e)
        {


        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Deposito_label_Click(object sender, EventArgs e)
        {

        }

        private void DescripcionDeposito_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();

            if (depositoSeleccionado != "---")
            {
                CargarMercaderias();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descripcionMercaderia_ComboBox = DescripcionMercaderia_ComboBox.Text.Trim();
            string cantidad_textbox = Cantidad_textbox.Text.Trim();
            string descripcionDeposito_Combobox = DescripcionDeposito_Combobox.Text.Trim();

            var mercaderia = Datos_model.Mercaderias.Where(x => x.Descripcion_Mercaderia == descripcionMercaderia_ComboBox).FirstOrDefault();
            var deposito = Datos_model.Depositos.Where(x => x.Nombre_Deposito == descripcionDeposito_Combobox).FirstOrDefault();

            var depositoMercaderia = Datos_model.DepositoMercaderias.Where(x => x.Id_Deposito == deposito.Id_Deposito).FirstOrDefault();

            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();


            int cantidadNueva = int.Parse(cantidad_textbox);
            int cantidadExistente = 0;
            int cantidadItem = 0;

            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                if (item.SubItems[0].Text == mercaderia.Descripcion_Mercaderia)
                {
                    cantidadItem = int.Parse(item.SubItems[1].Text);
                    cantidadExistente += cantidadItem;
                }
            }

            cantidadExistente += cantidadNueva;


            if (depositoSeleccionado == "---")
            {
                MessageBox.Show("Debes seleccionar un depósito valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }

            else
            {
                if (depositoMercaderia.Cantidad_DepositoMercaderias < cantidadExistente)
                {
                    MessageBox.Show("El deposito no contiene la cantidad seleccionada. La cantidad total es: " + depositoMercaderia.Cantidad_DepositoMercaderias, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cantidad_textbox.Focus();
                    return;
                }

                else
                {
                    var cantidadItems = listView_MercaderiasOrdenes.Items.Count;
                    var numeroItem = cantidadItems + 1;

                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        mercaderia.Descripcion_Mercaderia.ToString(),
                        cantidad_textbox.ToString(),

                    }, -1);

                    listView_MercaderiasOrdenes.Items.Add(listViewItem);

                    DescripcionDeposito_Combobox.Enabled = false;
                }
            }
        }

        private void button_borrarItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                if (item.Checked == true)
                {
                    listView_MercaderiasOrdenes.Items.Remove(item);
                }
            }

            if (listView_MercaderiasOrdenes.Items.Count == 0)
            {
                DescripcionDeposito_Combobox.Enabled = true;
            }
        }
    }
}
