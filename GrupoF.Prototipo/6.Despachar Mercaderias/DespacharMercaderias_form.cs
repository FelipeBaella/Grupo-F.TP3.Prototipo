using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Base_de_Datos;
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
        private Datos_model Datos_model = new Datos_model();

        public DespacharMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDeEntrega();
        }

        private void CargarOrdenesDeEntrega()
        {
            listView_OrdenesDeEntrega.Items.Clear();

            var ordenes = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Transportista == 0).ToList();

            var dni_Transportista = DniTransportista_textBox.Text;

            if (dni_Transportista != "")
            {
                var transportista = Datos_model.Transportistas.Where(x => x.Dni_Transportista == int.Parse(dni_Transportista)).FirstOrDefault();

                ordenes = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Transportista == transportista.Id_Transportista).ToList();
            }

            foreach (var orden in ordenes)
            {
                var OrdnesDePreparacion = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Transportista == orden.Id_Transportista).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    OrdnesDePreparacion.Id_OrdenDePreparacion.ToString(),

                }, -1);

                listView_OrdenesDeEntrega.Items.Add(listViewItem);
            }
        }

        private void ProcesarOrdenDeEntrega_button_Click(object sender, EventArgs e)
        {
            string Id_Transportista = DniTransportista_textBox.Text.Trim();

            if (Id_Transportista == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTransportista_textBox.Focus();
                return;
            }

            if (!Id_Transportista.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTransportista_textBox.Focus();
                return;
            }

            if (!Datos_model.Transportistas.Any(o => o.Dni_Transportista == int.Parse(Id_Transportista)))
            {
                MessageBox.Show("Debes seleccionar un Transportista valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string Id_Transportista = DniTransportista_textBox.Text.Trim();

            MessageBox.Show("Se emitio el remito con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            DespacharMercaderias_form nuevaForma = new DespacharMercaderias_form();
            nuevaForma.Show();
        }
    }
}
