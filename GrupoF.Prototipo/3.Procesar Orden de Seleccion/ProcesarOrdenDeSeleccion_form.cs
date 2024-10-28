using GrupoF.Prototipo._0.Menu;

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

            var OrdenesDeSeleccion = ProcesarOrdenDeSeleccion_model.OrdenesDeSeleccion
            .Where(x => x.Id_OrdenDeSeleccion == int.Parse(id))
            .FirstOrDefault();

            var ordenes = ProcesarOrdenDeSeleccion_model.OrdenesDePreparacion
                .Where(x => x.Id_OrdenDeSeleccion == OrdenesDeSeleccion.Id_OrdenDeSeleccion && x.Id_EstadoOP == 2)
                .ToList();

            var ordenesIds = ordenes.Select(x => x.Id_OrdenDePreparacion).ToList();

            var OrdenesDePreparacionItems = from item in ProcesarOrdenDeSeleccion_model.OrdenesDePreparacionItems
                                            join deposito in ProcesarOrdenDeSeleccion_model.DepositoMercaderias
                                            on item.Id_DepositoMercaderias equals deposito.Id_DepositoMercaderias
                                            where ordenesIds.Contains(item.Id_OrdenDePreparacion)
                                            orderby deposito.Coordenadas_DepositoMercaderias
                                            select item;

            var resultado = OrdenesDePreparacionItems.ToList();

            foreach (var orden in resultado)
            {
                var OrdenDePreparacion = ProcesarOrdenDeSeleccion_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();
                var DepositoMercaderias = ProcesarOrdenDeSeleccion_model.DepositoMercaderias.Where(x => x.Id_DepositoMercaderias == orden.Id_DepositoMercaderias).FirstOrDefault();
                var mercaderia = ProcesarOrdenDeSeleccion_model.Mercaderias.Where(x => x.Id_Mercaderia == DepositoMercaderias.Id_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem1 = new ListViewItem(new string[] {

                    DepositoMercaderias.Coordenadas_DepositoMercaderias.ToString(),
                    mercaderia.Descripcion_Mercaderia,
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
            var OrdenesDeSeleccion = ProcesarOrdenDeSeleccion_model.OrdenesDeSeleccion.Where(x => x.Id_EstadoOS == 1).Select(x => x.Id_OrdenDeSeleccion).ToList();

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
