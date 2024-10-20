using GrupoF.Prototipo._0.Menu;

using System.Data;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    public partial class CrearOrdenDePreparacion_form : Form
    {
        private CrearOrdnesDePreparacion_model CrearOrdnesDePreparacion_model = new CrearOrdnesDePreparacion_model();

        public CrearOrdenDePreparacion_form()
        {
            InitializeComponent();
            CargarDepositos();
        }

        private void CargarDepositos()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            DescripcionDeposito_Combobox.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var deposito in CrearOrdnesDePreparacion_model.Depositos)
            {
                DescripcionDeposito_Combobox.Items.Add(deposito.Nombre_Deposito);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (DescripcionDeposito_Combobox.Items.Count > 0)
            {
                DescripcionDeposito_Combobox.SelectedIndex = 0;
            }
        }

        private void CargarMercaderias()
        {
            var deposito = CrearOrdnesDePreparacion_model.Depositos.Where(x => x.Nombre_Deposito == DescripcionDeposito_Combobox.SelectedItem).FirstOrDefault();

            var cliente = 0;

            if (IdCliente_textbox.Text != "")
            {
                cliente = int.Parse(IdCliente_textbox.Text);
            }

            var depositoMercaderias = CrearOrdnesDePreparacion_model.DepositoMercaderias
                .Where(x => x.Id_Deposito == deposito.Id_Deposito)
                .Where(x => x.Id_Cliente == cliente)
                .Select(x => x.Id_Mercaderia)
                .Distinct()
                .ToList();

            var mercaderias = new List<string>();

            foreach (var item in depositoMercaderias)
            {
                var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Id_Mercaderia == item).FirstOrDefault();

                mercaderias.Add(mercaderia.Descripcion_Mercaderia);
            }

            DescripcionMercaderia_ComboBox.Items.Clear();

            foreach (var mercaderia in mercaderias)
            {
                DescripcionMercaderia_ComboBox.Items.Add(mercaderia);
            }

            if (DescripcionMercaderia_ComboBox.Items.Count > 0)
            {
                DescripcionMercaderia_ComboBox.SelectedIndex = 0;
            }
        }


        private void button_aceptar_click(object sender, EventArgs e)
        {
            var cliente = IdCliente_textbox.Text.Trim();
            string Cantidad = Cantidad_textbox.Text.Trim();
            string Dni = Dni_textbox.Text.Trim();

            string fecha = dateTimePicker_fecha.Text;

            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();
            string? mercaderiaSeleccionada = DescripcionMercaderia_ComboBox.SelectedItem?.ToString();

            //DNI

            if (!Dni.All(char.IsDigit))
            {
                MessageBox.Show("El campo Dni solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }
            if (Dni.Length != 8)
            {
                MessageBox.Show("El campo Dni debe ser tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Dni))
            {
                MessageBox.Show("El campo Dni no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dni_textbox.Focus();
                return;
            }


            //FECHA
            if (string.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("El campo Fecha, no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_fecha.Focus();
                return;
            }

            if (DateTime.Parse(fecha) < DateTime.Now.Date)
            {
                MessageBox.Show("El campo Fecha, no puede ser menor al dia de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_fecha.Focus();
                return;
            }


            //DEPOSITO
            if (depositoSeleccionado == "---")
            {
                MessageBox.Show("Debes seleccionar un depósito valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }


            //LISTA
            if (listView_MercaderiasOrdenes.Items.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos 1 item para la Orden de Preparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }



            var deposito = CrearOrdnesDePreparacion_model.Depositos.Where(x => x.Nombre_Deposito == DescripcionDeposito_Combobox.Text).FirstOrDefault();
            var tranpostista = CrearOrdnesDePreparacion_model.Transportistas.Where(x => x.Dni_Transportista == int.Parse(Dni_textbox.Text)).FirstOrDefault();

            var ordenDePreparacion = new OrdenesDePreparacion();

            ordenDePreparacion.Id_EstadoOP = 1;
            ordenDePreparacion.Prioridad_OrdenDePreparacion = true;
            ordenDePreparacion.Id_Cliente = int.Parse(cliente);
            ordenDePreparacion.Emision_OrdenDePreparacion = DateTime.Now;
            ordenDePreparacion.Id_Deposito = deposito.Id_Deposito;
            ordenDePreparacion.Id_Transportista = tranpostista.Id_Transportista;

            CrearOrdnesDePreparacion_model.CrearOrdenesDePreparacion(ordenDePreparacion);


            

            var ordenesDePreparacionItems = new OrdenesDePreparacionItems();

            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Descripcion_Mercaderia == item.SubItems[0].Text).FirstOrDefault();

                var depositoMercaderias = CrearOrdnesDePreparacion_model.DepositoMercaderias.Where(x => x.Id_Deposito == deposito.Id_Deposito && x.Id_Mercaderia == mercaderia.Id_Mercaderia);

                ordenesDePreparacionItems.Id_DepositoMercaderias = 0;
                ordenesDePreparacionItems.Cantidad_Mercaderia = int.Parse(item.SubItems[1].Text);

                CrearOrdnesDePreparacion_model.CrearOrdenesDePreparacionItem(ordenesDePreparacionItems);
            }


            MessageBox.Show("Se creo la orden de preparacion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Refresh();

            CrearOrdenDePreparacion_form nuevaForma = new CrearOrdenDePreparacion_form();
            nuevaForma.Show();

        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void DescripcionDeposito_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();

            if (depositoSeleccionado != "---")
            {
                CargarMercaderias();
            }
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            string descripcionMercaderia_ComboBox = DescripcionMercaderia_ComboBox.Text.Trim();
            string cantidad_textbox = Cantidad_textbox.Text.Trim();
            string descripcionDeposito_Combobox = DescripcionDeposito_Combobox.Text.Trim();

            var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Descripcion_Mercaderia == descripcionMercaderia_ComboBox).FirstOrDefault();
            var deposito = CrearOrdnesDePreparacion_model.Depositos.Where(x => x.Nombre_Deposito == descripcionDeposito_Combobox).FirstOrDefault();

            var depositoMercaderia = CrearOrdnesDePreparacion_model.DepositoMercaderias.Where(x => x.Id_Deposito == deposito.Id_Deposito).FirstOrDefault();

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

            if (descripcionMercaderia_ComboBox == "")
            {
                MessageBox.Show("Debes seleccionar una mercaderia valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    IdCliente_textbox.Enabled = false;
                    Cantidad_textbox.Text = "";
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
                IdCliente_textbox.Enabled = true;
            }
        }

        private void IdCliente_textbox_TextChanged(object sender, EventArgs e)
        {
            DescripcionDeposito_Combobox.SelectedItem = "---";
            DescripcionMercaderia_ComboBox.Items.Remove(DescripcionMercaderia_ComboBox.SelectedItem);
            Cantidad_textbox.Enabled = false;
            Cantidad_textbox.Text = "";

            string Id_Cliente = IdCliente_textbox.Text.Trim();

            //CLIENTE
            if (Id_Cliente.All(char.IsDigit) && !string.IsNullOrEmpty(Id_Cliente))
            {
                var clientes = CrearOrdnesDePreparacion_model.Clientes.Where(x => x.Id_Cliente == int.Parse(Id_Cliente)).FirstOrDefault();

                if (clientes != null)
                {
                    IdCliente_textbox.Text = Id_Cliente;
                    DescripcionDeposito_Combobox.Enabled = true;
                    Cantidad_textbox.Enabled = true;
                    CargarMercaderias();
                }
            }
        }

        private void Dni_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
