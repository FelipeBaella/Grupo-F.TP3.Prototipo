using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
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
            var cliente = 0;

            if (IdCliente_textbox.Text != "")
            {
                cliente = int.Parse(IdCliente_textbox.Text);
            }

            // Limpiamos el ComboBox por si ya tiene elementos cargados
          
            var depositos = CrearOrdnesDePreparacion_model.Depositos.ToList();

            var depositosAEliminar = new List<Deposito>();

            foreach (var deposito in depositos)
            {
                var depositoMercaderias = CrearOrdnesDePreparacion_model.DepositoMercaderias
                .Where(x => x.ID_Cliente == cliente && x.ID_Deposito == deposito.ID_Deposito)
                .FirstOrDefault();

                if (depositoMercaderias == null)
                {
                    depositosAEliminar.Add(deposito);
                }
            }

            foreach (var deposito in depositosAEliminar)
            {
                depositos.Remove(deposito);
            }

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var deposito in depositos)
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

            if (deposito != null)
            {
                if (!int.TryParse(IdCliente_textbox.Text, out int cliente))
                {
                    MessageBox.Show("El campo Cliente solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dni_textbox.Focus();
                    return;
                }

                var depositoMercaderias = CrearOrdnesDePreparacion_model.DepositoMercaderias
                    .Where(x => x.ID_Deposito == deposito.ID_Deposito)
                    .Where(x => x.ID_Cliente == cliente)
                    .Select(x => x.ID_Mercaderia)
                    .Distinct()
                    .ToList();

                var mercaderias = new List<string>();

                foreach (var item in depositoMercaderias)
                {
                    var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.ID_Mercaderia == item).FirstOrDefault();

                    mercaderias.Add(mercaderia.ID_Mercaderia + " - " + mercaderia.Descripcion_Mercaderia);
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
                MessageBox.Show("El campo Dni solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("El campo Fecha, no puede ser menor al dia de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_fecha.Focus();
                return;
            }
            
            //DEPOSITO
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


            var deposito = CrearOrdnesDePreparacion_model.Depositos.Where(x => x.Nombre_Deposito == DescripcionDeposito_Combobox.Text).FirstOrDefault();

            var ordenDePreparacion = new OrdenesDePreparacion();

            ordenDePreparacion.Estado_OP = EstadoOPEnum.EMITIDA;
            ordenDePreparacion.Prioridad_OP = true;
            ordenDePreparacion.ID_Cliente = cliente;
            ordenDePreparacion.FechaEmision_OP = DateTime.Now;
            ordenDePreparacion.FechaEntrega_OP = Fecha;
            ordenDePreparacion.FechaActualizacionEstado_OP = DateTime.Now;
            ordenDePreparacion.ID_Deposito = deposito.ID_Deposito;
            ordenDePreparacion.Dni_transportista = Dni;

            CrearOrdnesDePreparacion_model.CrearOrdenesDePreparacion(ordenDePreparacion);




            var ordenesDePreparacionItems = new OrdenesDePreparacionItems();

            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Descripcion_Mercaderia == item.SubItems[0].Text).FirstOrDefault();

                var depositoMercaderias = CrearOrdnesDePreparacion_model.DepositoMercaderias.Where(x => x.ID_Deposito == deposito.ID_Deposito && x.ID_Mercaderia == mercaderia.ID_Mercaderia);

                ordenesDePreparacionItems.ID_DepositoMercaderias = 0;
                ordenesDePreparacionItems.Cantidad_Mercaderia = int.Parse(item.SubItems[1].Text);

                CrearOrdnesDePreparacion_model.CrearOrdenesDePreparacionItem(ordenesDePreparacionItems);
            }


            MessageBox.Show("Se creo la orden de preparacion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string descripcionMercaderia_ComboBox_Completo = DescripcionMercaderia_ComboBox.Text.Trim();

            string descripcionMercaderia_ComboBox = descripcionMercaderia_ComboBox_Completo.Split('-')[1];

            int cantidad;
            string descripcionDeposito_Combobox = DescripcionDeposito_Combobox.Text.Trim();

            var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Descripcion_Mercaderia == descripcionMercaderia_ComboBox.Trim()).FirstOrDefault();
            var deposito = CrearOrdnesDePreparacion_model.Depositos.Where(x => x.Nombre_Deposito == descripcionDeposito_Combobox).FirstOrDefault();

            var depositoMercaderia = CrearOrdnesDePreparacion_model.DepositoMercaderias.Where(x => x.ID_Deposito == deposito.ID_Deposito).FirstOrDefault();

            string? depositoSeleccionado = DescripcionDeposito_Combobox.SelectedItem?.ToString();


            if (!int.TryParse(Cantidad_textbox.Text.Trim(), out cantidad))
            {
                MessageBox.Show("Cantidad debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionDeposito_Combobox.Focus();
                return;
            }

            int cantidadNueva = cantidad;
            int cantidadExistente = 0;
            int cantidadItem = 0;


            foreach (ListViewItem item in listView_MercaderiasOrdenes.Items)
            {
                string SubItems_Completo = item.SubItems[0].Text;

                string SubItems = SubItems_Completo.Split('-')[1];

                if (SubItems.Trim() == mercaderia.Descripcion_Mercaderia)
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

                        mercaderia.ID_Mercaderia + " - "+ mercaderia.Descripcion_Mercaderia,
                        Cantidad_textbox.Text.ToString(),

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
            DescripcionDeposito_Combobox.Items.Clear();
            DescripcionMercaderia_ComboBox.Items.Clear();

            Cantidad_textbox.Enabled = false;
            Cantidad_textbox.Text = "";

            string ID_Cliente = IdCliente_textbox.Text.Trim();

            //CLIENTE
            if (ID_Cliente.All(char.IsDigit) && !string.IsNullOrEmpty(ID_Cliente))
            {
                var clientes = CrearOrdnesDePreparacion_model.Clientes.Where(x => x.ID_Cliente == int.Parse(ID_Cliente)).FirstOrDefault();

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

        private void Dni_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
