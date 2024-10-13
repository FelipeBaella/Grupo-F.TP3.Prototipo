using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class CrearOrdenDeSeleccion_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public CrearOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
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

                        ItemsOP_listView2.Items.Add((ListViewItem)item.Clone());


                        OrdenesDePreparacion_ListView.Items.Remove(item);

                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                 OrdenesDePreparacion_ListView.ListViewItemSorter = new ListViewNumberComparer(2);  
                 OrdenesDePreparacion_ListView.Sort();
            }
        }
        public class ListViewNumberComparer : IComparer
        {
            private int col;

            public ListViewNumberComparer(int column)
            {
                col = column;
            }

            public int Compare(object x, object y)
            {
               
                ListViewItem item1 = x as ListViewItem;
                ListViewItem item2 = y as ListViewItem;

               
                int number1 = int.Parse(item1.SubItems[col].Text);
                int number2 = int.Parse(item2.SubItems[col].Text);

               
                return number1.CompareTo(number2);
            }
        }
    }
}
