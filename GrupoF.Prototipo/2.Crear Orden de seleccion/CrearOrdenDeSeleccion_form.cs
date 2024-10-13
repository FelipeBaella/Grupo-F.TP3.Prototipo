using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Base_de_Datos;
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


namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class CrearOrdenDeSeleccion_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public CrearOrdenDeSeleccion_form()
        {
            var listview = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Estado == 2).ToList(); 

            InitializeComponent();
            CargarOrdenesDePreparacion(listview);
        }

        private void button_Crear_Orden_Click(object sender, EventArgs e)
        {
            string Id_Orden = IdOrden_textBox.Text.Trim();

            if (Id_Orden == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            if (!Id_Orden.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            if (!Datos_model.OrdenesDePreparacion.Any(o => o.Id_OrdenDePreparacion == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrden_textBox.Focus();
                return;
            }

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Agregar_button1_Click(object sender, EventArgs e)
        {
            {

                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {

                    if (item.Checked)
                    {

                        Items_OS_listView2.Items.Add((ListViewItem)item.Clone());


                        OrdenesDePreparacion_ListView.Items.Remove(item);

                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex == 0)
            //{
            //     OrdenesDePreparacion_ListView.ListViewItemSorter = new ListViewNumberComparer(2);  
            //     OrdenesDePreparacion_ListView.Sort();
            //}

            var listview = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Estado == 2).ToList();

            if (comboBox1.SelectedIndex == 1)
            {
                listview = listview.OrderBy(x => x.Id_OrdenDePreparacion).ToList();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                listview = listview.OrderByDescending(x => x.Prioridad_OrdenDePreparacion).ToList();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                listview = listview.OrderBy(x => x.Emision_OrdenDePreparacion).ToList();
            }

            if (comboBox1.SelectedIndex == 4)
            {
                var nombres = new List<(string, string, string, string, string, string)>();

                foreach (ListViewItem item in OrdenesDePreparacion_ListView.Items)
                {
                    var nombre = item.SubItems[5].Text;

                    nombres.Add((item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text));
                }

                nombres = nombres.OrderBy(nombre => nombre.Item6).ToList();

                OrdenesDePreparacion_ListView.Items.Clear();

                foreach (var orden in nombres)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.Item1.ToString(),
                        orden.Item2.ToString(),
                        orden.Item3.ToString(),
                        orden.Item4.ToString(),
                        orden.Item5.ToString(),
                        orden.Item6.ToString(),

                }, -1);

                    OrdenesDePreparacion_ListView.Items.Add(listViewItem);
                }
            }

            if (comboBox1.SelectedIndex != 4)
            {
                CargarOrdenesDePreparacion(listview);
            }

      
        }

        public class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}
