using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    public partial class ProcesarOrdenDeSeleccion_form : Form
    {
        private ProcesarOrdenDeSeleccion_model model = new ProcesarOrdenDeSeleccion_model();

        public ProcesarOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDeSeleccion();
        }

        private void CargarOrdenesDePreparacionItems(string id)
        {
            ProcesarOrdenesDeSeleccion_listView.Items.Clear();

            var OS = model.ObtenerOSs().Where(x => x.ID_OS == int.Parse(id)).SingleOrDefault();

            var OrdenesPreparacion_OS = OS.OrdenesPreparacion_OS;

            foreach (var item in OrdenesPreparacion_OS)
            {
                var OP = model.ObtenerOPs().Where(x => x.ID_OP == item).SingleOrDefault();

                var cliente = OP.ID_Cliente;
                var deposito = OP.ID_Deposito;

                var mercaderias = OP.Mercaderias_OP;

                foreach (var items in mercaderias)
                {
                    var mercaderia = model.ObtenerMercaderias().Where(x => x.ID_Mercaderia == items.ID_Mercaderia).SingleOrDefault();
                    var depositoMercaderia = model.ObtenerDepositosMercaderias().Where(x => x.ID_Mercaderia == mercaderia.ID_Mercaderia && x.ID_Cliente == cliente && x.ID_Deposito == deposito).FirstOrDefault();

                    if (depositoMercaderia != null)
                    {
                        ListViewItem listViewItem1 = new ListViewItem(new string[] {

                            depositoMercaderia.Coordenadas_DepositoMercaderia.ToString(),
                            mercaderia.Descripcion_Mercaderia,
                            items.Cantidad_Mercaderia.ToString(),

                        }, -1);

                        ProcesarOrdenesDeSeleccion_listView.Items.Add(listViewItem1);
                    }
                }
            }
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void CargarOrdenesDeSeleccion()
        {
            var OrdenesDeSeleccion = model.ObtenerOSs().Where(x => x.Estado_OS == EstadoOSEnum.Emitida).Select(x => x.ID_OS).ToList();

            foreach (var orden in OrdenesDeSeleccion)
            {
                OS_Pendientes_comboBox.Items.AddRange(new object[] { orden });
            }
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (int.TryParse(OS_Pendientes_comboBox.Text, out id))
            {
                ProcesarOrdenDeSeleccion_model.EditarEstadoOS(id);

                MessageBox.Show("Se proceso la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                ProcesarOrdenDeSeleccion_form nuevaForma = new ProcesarOrdenDeSeleccion_form();
                nuevaForma.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una orden de seleccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OS_Pendientes_comboBox.Focus();
                return;
            }

        }

        private void OS_Pendientes_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = OS_Pendientes_comboBox.Text;

            CargarOrdenesDePreparacionItems(id);
        }
    }
}
