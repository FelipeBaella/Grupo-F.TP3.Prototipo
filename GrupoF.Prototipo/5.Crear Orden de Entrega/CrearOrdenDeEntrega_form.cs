using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo._4.Crear_Orden_de_Entrega;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.Prototipo._5.Crear_Orden_deEntrega
{
    public partial class CrearOrdenDeEntrega_form : Form
    {
        private CrearOrdenDeEntrega_model CrearOrdenDeEntrega_model = new CrearOrdenDeEntrega_model();

        public CrearOrdenDeEntrega_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
        }

        private void CargarOrdenesDePreparacion()
        {
            var ordenes = CrearOrdenDeEntrega_model.OrdenesDePreparacion.Where(x => x.Id_EstadoOP == 4).ToList();

            OrdenesDePreparacion_ListView.Items.Clear();

            foreach (var orden in ordenes)
            {
                var cliente = CrearOrdenDeEntrega_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.Id_OrdenDePreparacion.ToString(),

                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
            }

        }

        private void EnviadoADespacho_button_Click(object sender, EventArgs e)
        {
            var ordenesDeEntrega = new OrdenesDeEntrega();

            var Id_OrdenDeEntrega = CrearOrdenDeEntrega_model.OrdenesDeEntrega.Count + 1;

            ordenesDeEntrega.Id_OrdenDeEntrega = Id_OrdenDeEntrega;
            ordenesDeEntrega.Emision_OrdenDeEntrega = DateTime.Now;
            ordenesDeEntrega.Procesado_OrdenDeEntrega = true;

            CrearOrdenDeEntrega_model.CrearOrdenesDeEntrega(ordenesDeEntrega);


            var id = CrearOrdenDeEntrega_model.OrdenesDePreparacion.First().Id_OrdenDePreparacion;

            CrearOrdenDeEntrega_model.EditarEstadoOP(id);


            MessageBox.Show("Se envio a despacho con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            CrearOrdenDeEntrega_form nuevaForma = new CrearOrdenDeEntrega_form();
            nuevaForma.Show();
        }

        private void Salir_button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void CrearOrdenDeEntrega_form_Load(object sender, EventArgs e)
        {

        }
    }
}
