using GrupoF.Prototipo._0.Menu;

using GrupoF.Prototipo.Almacenes;
using System.Data;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    public partial class CrearOrdenDePreparacion_form : Form
    {
        private CrearOrdnesDePreparacion_model model = new CrearOrdnesDePreparacion_model();

        public CrearOrdenDePreparacion_form()
        {
            InitializeComponent();
            CargarDepositos();
        }

        private void CargarDepositos()
        {
            var cliente = 0;

            if (IdCliente_textbox.Text != "")
            {
                cliente = int.Parse(IdCliente_textbox.Text);
            }


            var depositos = model.ObtenerDepositos();

            var depositosAEliminar = new List<DepositoEnt>();

            foreach (var dep in depositos)
            {
                var DepositoMercaderiaEnt = model.ObtenerDepositosMercaderias().Where(x => x.ID_Cliente == cliente && x.ID_Deposito == dep.ID_Deposito)
                .FirstOrDefault();

                if (DepositoMercaderiaEnt == null)
                {
                    depositosAEliminar.Add(dep);
                }
            }

            foreach (var dep in depositosAEliminar)
            {
                depositos.Remove(dep);
            }

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var DepositoEnt in depositos)
            {
                DescripcionDeposito_Combobox.Items.Add(DepositoEnt.Descripcion_Deposito);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (DescripcionDeposito_Combobox.Items.Count > 0)
            {
                DescripcionDeposito_Combobox.SelectedIndex = 0;
            }
        }

        private void CargarMercaderias()
        {
            var DepositoEnt = model.ObtenerDepositos().Where(x => x.Descripcion_Deposito == DescripcionDeposito_Combobox.SelectedItem).FirstOrDefault();

            if (DepositoEnt != null)
            {
                if (!int.TryParse(IdCliente_textbox.Text, out int cliente))
                {
                    MessageBox.Show("El campo Cliente solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dni_textbox.Focus();
                    return;
                }

                var DepositoMercaderiaEnt = model.ObtenerDepositosMercaderias()
                .Where(x => x.ID_Deposito == DepositoEnt.ID_Deposito && x.ID_Cliente == cliente && x.Cantidad_DepositoMercaderia > 0)
                .Select(x => x.ID_Mercaderia)
                .Distinct()
                .OrderBy(id => id)  
                .ToList();


                //int cantidadTotal = model.ObtenerOPs()
                // .Where(x => x.Value.Item1 == cliente
                //     && x.Value.Item2 == deposito
                //     && x.Value.Item3 == int.Parse(mercaderiaID))
                // .Sum(x => x.Value.Item4);


                var mercaderias = new List<string>();

                foreach (var item in DepositoMercaderiaEnt)
                {
                    var MercaderiaEnt = model.ObtenerMercaderias().Where(x => x.ID_Mercaderia == item).FirstOrDefault();

                    mercaderias.Add(MercaderiaEnt.ID_Mercaderia + " - " + MercaderiaEnt.Descripcion_Mercaderia);
                }

                DescripcionMercaderia_ComboBox.Items.Clear();

                foreach (var MercaderiaEnt in mercaderias)
                {
                    DescripcionMercaderia_ComboBox.Items.Add(MercaderiaEnt);
                }

                if (DescripcionMercaderia_ComboBox.Items.Count > 0)
                {
                    DescripcionMercaderia_ComboBox.SelectedIndex = 0;
                }
            }
        }

        private void button_aceptar_click(object sender, EventArgs e)
        {
            string Cantidad = Cantidad_textbox.Text.Trim();
            string fecha = dateTimePicker_fecha.Text;

            //CLIENTE
            if ((!int.TryParse(IdCliente_textbox.Text, out int cliente)))
            {
                MessageBox.Show("Cliente debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }

            //DNI
            if (!int.TryParse(Dni_textbox.Text, out int Dni))
            {
                MessageBox.Show("El DNI ingresado debe ser un número positivo de 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dni_textbox.Focus();
                return;
            }

            //FECHA
            if (!DateTime.TryParse(dateTimePicker_fecha.Text, out DateTime Fecha))
            {
                MessageBox.Show("El campo Fecha no corresponde a un formato válido.");
                return;
            }

            if (DateTime.Parse(fecha) < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de entrega ingresada debe ser igual o mayor al día de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_fecha.Focus();
                return;
            }

            //DepositoEnt
            if (string.IsNullOrEmpty(DescripcionDeposito_Combobox.SelectedItem?.ToString()))
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


            var DepositoEnt = model.ObtenerDepositos().Where(x => x.Descripcion_Deposito == DescripcionDeposito_Combobox.Text).FirstOrDefault();

            var Prioridad_OP = true;
            var ID_Cliente = cliente;
            var FechaEntrega_OP = Fecha;
            var ID_Deposito = DepositoEnt.ID_Deposito;
            var DNI_Transportista = Dni;

            var ordenesDePreparacionItems = new Dictionary<int,int>();

            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                var id_merca = item.SubItems[0].Text.Split('-')[0].Trim();
                var cantidad = int.Parse(item.SubItems[1].Text);
            
                var ID_Mercaderia = int.Parse(id_merca);
                var Cantidad_Mercaderia = cantidad;

                ordenesDePreparacionItems.Add(ID_Mercaderia, Cantidad_Mercaderia);             
            }

            var mensaje = CrearOrdnesDePreparacion_model.CrearOrdenesDePreparacion(Prioridad_OP, ID_Cliente, FechaEntrega_OP, ID_Deposito, DNI_Transportista, ordenesDePreparacionItems);
            var id = 0;

            if (int.TryParse(mensaje.Trim(), out id))
            {
                MessageBox.Show($"Se creo la orden de preparacion: {mensaje} con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                CrearOrdenDePreparacion_form nuevaForma = new CrearOrdenDePreparacion_form();
                nuevaForma.Show();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string depositoDescri = DescripcionDeposito_Combobox.Text;
            var deposito = model.ObtenerDepositos().Where(x => x.Descripcion_Deposito == depositoDescri).SingleOrDefault().ID_Deposito;

            string cliente = IdCliente_textbox.Text;

            string mercaderia = DescripcionMercaderia_ComboBox.Text;
            string mercaderiaID = mercaderia.Split('-')[0].Trim();
            string mercaderiaDescri = mercaderia.Split('-')[1].Trim();

            var MercaderiaEnt = model.ObtenerDepositosMercaderias().Where(x => x.ID_Cliente == int.Parse(cliente) && x.ID_Deposito == deposito && x.ID_Mercaderia == int.Parse(mercaderiaID)).ToList();

            int cantidadTotal = model.ObtenerOPs()
             .Where(x => x.Value.Item1 == int.Parse(cliente)
                 && x.Value.Item2 == deposito
                 && x.Value.Item3 == int.Parse(mercaderiaID))
             .Sum(x => x.Value.Item4);


            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                string SubItems_Completo = item.SubItems[0].Text;

                string SubItems = SubItems_Completo.Split('-')[1];

                if (SubItems.Trim() == mercaderiaDescri)
                {
                    MessageBox.Show("La mercaderia ya ha sido seleccionada, si desea modificar la cantidad remueva el producto de la lista y vuelva a ingresarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cantidad_textbox.Focus();
                    return;
                }
            }

            int cantidadExistente = MercaderiaEnt.Sum(m => m.Cantidad_DepositoMercaderia);

            int cantidadDisponible = cantidadExistente - cantidadTotal;

            var cantidad = 0;
            if (!int.TryParse(Cantidad_textbox.Text.Trim(), out cantidad))
            {
                MessageBox.Show("La cantidad ingresada debe ser un numero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }
            if (cantidad < 1)
            {
                MessageBox.Show("La cantidad ingresada debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }
            if (cantidad > cantidadDisponible)
            {
                MessageBox.Show("El Deposito no contiene la cantidad Seleccionada. La cantidad total es: " + cantidadDisponible, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cantidad_textbox.Focus();
                return;
            }

            int cantidadNueva = cantidad;
            int cantidadItem = 0;


            if (mercaderia == "")
            {
                MessageBox.Show("Debes seleccionar una MercaderiaEnt valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }
            else
            {
                var cantidadItems = listView_MercaderiasOrdenes.Items.Count;
                var numeroItem = cantidadItems + 1;

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        mercaderiaID + " - " + mercaderiaDescri,
                        Cantidad_textbox.Text.ToString(),

                    }, -1);

                listView_MercaderiasOrdenes.Items.Add(listViewItem);

                DescripcionDeposito_Combobox.Enabled = false;
                IdCliente_textbox.Enabled = false;
                Cantidad_textbox.Text = "";

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
            DescripcionDeposito_Combobox.Items.Clear();
            DescripcionMercaderia_ComboBox.Items.Clear();

            Cantidad_textbox.Enabled = false;
            Cantidad_textbox.Text = "";

            string ID_Cliente = IdCliente_textbox.Text.Trim();

            //CLIENTE
            if (ID_Cliente.All(char.IsDigit) && !string.IsNullOrEmpty(ID_Cliente))
            {
                var clientes = ClienteAlmacen.Clientes.Where(x => x.ID_Cliente == int.Parse(ID_Cliente)).FirstOrDefault();

                if (clientes != null)
                {
                    IdCliente_textbox.Text = ID_Cliente;
                    DescripcionDeposito_Combobox.Enabled = true;
                    Cantidad_textbox.Enabled = true;
                    CargarDepositos();
                    CargarMercaderias();
                }
            }
        }

    }
}
