using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    public partial class DespacharMercaderias_form : Form
    {
        private DespacharMercaderias_model DespacharMercaderias_model = new DespacharMercaderias_model();

        public DespacharMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDeEntrega();
        }

        private void CargarOrdenesDeEntrega()
        {
            listView_OrdenesDeEntrega.Items.Clear();

            var ordenes = DespacharMercaderias_model.OrdenesDePreparacion.Where(x => x.Dni_transportista == 0).ToList();

            var dni_Transportista = DniTransportista_textBox.Text;

            if (dni_Transportista != "")
            {
                ordenes = DespacharMercaderias_model.OrdenesDePreparacion.Where(x => x.Dni_transportista == int.Parse(dni_Transportista) && x.Id_EstadoOP == 5).ToList();
            }

            foreach (var orden in ordenes)
            {
                var OrdnesDePreparacion = DespacharMercaderias_model.OrdenesDePreparacion.Where(x => x.Dni_transportista == orden.Dni_transportista).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    OrdnesDePreparacion.Id_OrdenDePreparacion.ToString(),

                }, -1);

                listView_OrdenesDeEntrega.Items.Add(listViewItem);
            }
        }

        private void ProcesarOrdenDeEntrega_button_Click(object sender, EventArgs e)
        {
            string Dni_transportista = DniTransportista_textBox.Text.Trim();

            if (Dni_transportista == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTransportista_textBox.Focus();
                return;
            }

            if (!Dni_transportista.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTransportista_textBox.Focus();
                return;
            }

            CargarOrdenesDeEntrega();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void EmitirRemito_button_Click(object sender, EventArgs e)
        {
            int OrdenesDeEntrega = listView_OrdenesDeEntrega.Items.Count;

            if(OrdenesDeEntrega > 0)
            {
                var ordenesDePreparacion = new List<int>();

                foreach (ListViewItem item in listView_OrdenesDeEntrega.Items)
                {
                    ordenesDePreparacion.Add(int.Parse(item.SubItems[0].Text));
                }

                DespacharMercaderias_model.EditarEstadoOP(ordenesDePreparacion);

                MessageBox.Show("Se emitio el remito con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                DespacharMercaderias_form nuevaForma = new DespacharMercaderias_form();
                nuevaForma.Show();
            }
            else 
            {
                MessageBox.Show("El listado de ordenes de preparacion no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listView_OrdenesDeEntrega.Focus();
                return;
            }

        }
    }
}
