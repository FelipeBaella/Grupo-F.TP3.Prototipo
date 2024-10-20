using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
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
        private Datos_model Datos_model = new Datos_model();

        public ProcesarOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacionLista();    
        }

        private void CargarOrdenesDePreparacion(string id)
        {
            ProcesarOrdenesDeSeleccion_listView.Items.Clear();

            var OrdenesDeSeleccion = Datos_model.OrdenesDeSeleccion.Where(x => x.Id_OrdenDeSeleccion == int.Parse(id)).FirstOrDefault();

            var ordenes = Datos_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDeSeleccion == OrdenesDeSeleccion.Id_OrdenDeSeleccion).ToList();

            foreach (var orden in ordenes)
            {
                var OrdenDePreparacion = Datos_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();
                var OrdenesDePreparacionItems = Datos_model.OrdenesDePreparacionItems.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();
                var DepositoMercaderias = Datos_model.DepositoMercaderias.Where(x => x.Id_DepositoMercaderias == OrdenesDePreparacionItems.Id_DepositoMercaderias).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == DepositoMercaderias.Id_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem1 = new ListViewItem(new string[] {

                    DepositoMercaderias.Coordenadas_DepositoMercaderias.ToString(),
                    mercaderia.Descripcion_Mercaderia,
                    OrdenDePreparacion.Cantidad_OrdenDePreparacion.ToString(),


                }, -1);

                ProcesarOrdenesDeSeleccion_listView.Items.Add(listViewItem1);
            }
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void CargarOrdenesDePreparacionLista()
        {
            var OrdenesDeSeleccion = Datos_model.OrdenesDeSeleccion.Where(x => x.Id_EstadoOS == 1).Select(x => x.Id_OrdenDeSeleccion).ToList();

            foreach (var orden in OrdenesDeSeleccion)
            {
                OS_Pendientes_comboBox.Items.AddRange(new object[] { orden });
            }
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            ProcesarOrdenDeSeleccion_form nuevaForma = new ProcesarOrdenDeSeleccion_form();
            nuevaForma.Show();
        }

        private void OS_Pendientes_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = OS_Pendientes_comboBox.Text;

            CargarOrdenesDePreparacion(id);
        }
    }
}
