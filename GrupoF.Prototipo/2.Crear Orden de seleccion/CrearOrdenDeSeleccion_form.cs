using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;

using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

using GrupoF.Prototipo.Almacenes;




namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class CrearOrdenDeSeleccion_form : Form
    {
        private CrearOrdenDeSeleccion_model model = new CrearOrdenDeSeleccion_model();

        public CrearOrdenDeSeleccion_form()
        {
            var listview = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.Estado_OP == EstadoOPEnum.Emitida).ToList();

            InitializeComponent();
            CargarOrdenesDePreparacion(listview);
        }

        private void CargarOrdenesDePreparacion(IReadOnlyCollection<OrdenDePreparacionEnt> ordenes)
        {
            OrdenesDePreparacion_ListView.Items.Clear();

            foreach (var orden in ordenes)
            {
                var cliente = model.ObtenerClientes().Where(x => x.ID_Cliente == orden.ID_Cliente).FirstOrDefault();

                var prioridad = "";

                if (orden.Prioridad_OP == true)
                {
                    prioridad = "Si";
                }
                else
                {
                    prioridad = "No";
                }

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.ID_OP.ToString(),
                        prioridad,
                        orden.FechaEntrega_OP.ToString("dd-MM-yyyy"),
                        cliente.NombreApellido_Cliente,

                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
            }

        }

        private void CargarItemsOrdenesDePreparacion(int ID_ordenDePrparacion)
        {
            ItemsOP_listView2.Items.Clear();

            var OP = model.ObtenerOPs().Where(x => x.ID_OP == ID_ordenDePrparacion).SingleOrDefault();

            var Mercaderias_OP = OP.Mercaderias_OP;

            var i = 1;

            foreach (var item in Mercaderias_OP)
            {           
                var mercaderia = model.ObtenerMercaderias().Where(x => x.ID_Mercaderia == item.ID_Mercaderia).SingleOrDefault(); 

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        i.ToString(),
                        mercaderia.Descripcion_Mercaderia.ToString(),
                        item.Cantidad_Mercaderia.ToString(),

                }, -1);

                ItemsOP_listView2.Items.Add(listViewItem);

                i++;
            }
        }

        private void button_Crear_Orden_Click(object sender, EventArgs e)
        {
            var items = Items_OS_listView.Items.Count;

            if (items < 1)
            {
                MessageBox.Show("Seleccione al menos 1 item para la orden de seleccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Items_OS_listView.Focus();
                return;
            }
       
            var Ops = new List<int>();

            foreach (ListViewItem item in Items_OS_listView.Items)
            {
                Ops.Add(int.Parse(item.SubItems[0].Text));
            }

            model.CrearOrdenesDeSeleccion(Ops);

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            CrearOrdenDeSeleccion_form nuevaForma = new CrearOrdenDeSeleccion_form();
            nuevaForma.Show();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            int cantidad = Items_OS_listView.Items.Count;

            var i = 1;

            foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
            {
                if (item.Checked)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.SubItems[0].Text, //1
                        item.SubItems[3].Text,//2


                        item.SubItems[1].Text, //3
                        item.SubItems[2].Text, //4

                    }, -1);

                    Items_OS_listView.Items.Add(listViewItem);

                    OrdenesDePreparacion_ListView.Items.Remove(item);

                    i++;
                }
            }

            button.Enabled = false;
        }

        private void agregarTodo_button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.SubItems[0].Text, //1
                        item.SubItems[3].Text,//2


                        item.SubItems[1].Text, //3
                        item.SubItems[2].Text, //4

                    }, -1);

                Items_OS_listView.Items.Add(listViewItem);

                OrdenesDePreparacion_ListView.Items.Remove(item);
            }

            button.Enabled = false;
        }

        private void Remover_button_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Items_OS_listView.Items)
            {
                if (item.Checked)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.SubItems[0].Text, //0
                        item.SubItems[2].Text, //1
                        item.SubItems[3].Text, //2
                        item.SubItems[1].Text, //3

                    }, -1);

                    OrdenesDePreparacion_ListView.Items.Add(listViewItem);

                    Items_OS_listView.Items.Remove(item);
                }
            }

            if (Items_OS_listView.Items.Count == 0)
            {
                button.Enabled = true;
            }
        }

        private void Ver_button_Click(object sender, EventArgs e)
        {
            var cantidad = 0;

            foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
            {
                if (item.Checked)
                {
                    cantidad++;
                }
            }

            if (cantidad < 1)
            {
                MessageBox.Show("Debe seleccionar una Orden de preparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cantidad > 1)
            {
                MessageBox.Show("No debe seleccionar mas de una Orden de preparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {
                    if (item.Checked)
                    {
                        CargarItemsOrdenesDePreparacion(int.Parse(item.SubItems[0].Text));
                        break;
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            var listview = model.ObtenerOPs().Where(x => x.Estado_OP == EstadoOPEnum.Emitida).ToList();

            if (comboBox1.SelectedIndex == 0)
            {
                listview = listview.OrderBy(x => x.ID_OP).ToList();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                listview = listview.OrderByDescending(x => x.Prioridad_OP).ToList();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                listview = listview.OrderBy(x => x.FechaEntrega_OP).ToList();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                var nombres = new List<(string, string, string, string)>();

                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {
                    var nombre = item.SubItems[3].Text;

                    nombres.Add((item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text));
                }

                nombres = nombres.OrderBy(nombre => nombre.Item4).ToList();

                OrdenesDePreparacion_ListView.Items.Clear();

                foreach (var orden in nombres)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.Item1.ToString(),
                        orden.Item2.ToString(),
                        orden.Item3.ToString(),
                        orden.Item4.ToString(),

                    }, -1);

                    OrdenesDePreparacion_ListView.Items.Add(listViewItem);
                }
            }

            if (comboBox1.SelectedIndex != 3)
            {
                CargarOrdenesDePreparacion(listview);
            }

        }    
    }
}
