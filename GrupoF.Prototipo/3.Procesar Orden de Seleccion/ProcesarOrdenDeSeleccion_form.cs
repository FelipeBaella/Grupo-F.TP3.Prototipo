using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._1.Crear_Orden_de_Preparacion;
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
        private ProcesarOrdenDeSeleccion_model ProcesarOrdenDeSeleccion_model = new ProcesarOrdenDeSeleccion_model();


        public ProcesarOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDeSeleccion();
        }

        private void CargarOrdenesDePreparacionItems(string id)
        {
            ProcesarOrdenesDeSeleccion_listView.Items.Clear();

            var lista = (from OS in ProcesarOrdenDeSeleccion_model.OrdenesDeSeleccion
                         join OP in ProcesarOrdenDeSeleccion_model.OrdenesDePreparacion on OS.ID_OS equals OP.ID_OS
                         join OPM in ProcesarOrdenDeSeleccion_model.OrdenesDePreparacionItems on OP.ID_OP equals OPM.ID_OP
                         join DP in ProcesarOrdenDeSeleccion_model.DepositoMercaderias on OPM.ID_DepositoMercaderias equals DP.ID_DepositoMercaderias
                         join M in ProcesarOrdenDeSeleccion_model.Mercaderias on DP.ID_Mercaderia equals M.ID_Mercaderia                  
                         where OS.ID_OS == int.Parse(id)
                         orderby OP.ID_OP
                         select new {DP.Coordenadas_DepositoMercaderias, M.Descripcion_Mercaderia, OPM.Cantidad_Mercaderia }).ToList();

            foreach (var orden in lista)
            {

                ListViewItem listViewItem1 = new ListViewItem(new string[] {

                    orden.Coordenadas_DepositoMercaderias.ToString(),
                    orden.Descripcion_Mercaderia,
                    orden.Cantidad_Mercaderia.ToString(),


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

        private void CargarOrdenesDeSeleccion()
        {
            var OrdenesDeSeleccion = ProcesarOrdenDeSeleccion_model.OrdenesDeSeleccion.Where(x => x.Estado_OS == GrupoF.Prototipo._2.Crear_Orden_de_seleccion.EstadoOSEnum.EMITIDA).Select(x => x.ID_OS).ToList();

            foreach (var orden in OrdenesDeSeleccion)
            {
                OS_Pendientes_comboBox.Items.AddRange(new object[] { orden });
            }
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(OS_Pendientes_comboBox.Text, out int id))
            {                        
                ProcesarOrdenDeSeleccion_model.EditarEstadoOS(id);

                ProcesarOrdenDeSeleccion_model.EditarEstadoOP(id);

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
