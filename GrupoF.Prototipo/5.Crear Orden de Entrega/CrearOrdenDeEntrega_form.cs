using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo._4.Crear_Orden_de_Entrega;
using GrupoF.Prototipo.Almacenes;
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

        public CrearOrdenDeEntrega_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
        }

        private void CargarOrdenesDePreparacion()
        {
            var ordenes = OrdenDePreparacionAlmacen.OrdenesDePreparacion.Where(x => x.Estado_OP == EstadoOPEnum.Preparada).ToList();

            OrdenesDePreparacion_ListView.Items.Clear();

            foreach (var orden in ordenes)
            {

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.ID_OP.ToString(),

                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
            }

        }

        private void EnviadoADespacho_button_Click(object sender, EventArgs e)
        {
            if (OrdenesDePreparacion_ListView.Items.Count > 0)
            {

                var ordenesDeEntrega = new OrdenDeEntregaEnt();

                ordenesDeEntrega.FechaEmision_OE = DateTime.Now;

                var ops = new List<int>();

                foreach (var item in OrdenesDePreparacion_ListView.Items)
                {
                    ListViewItem op = item as ListViewItem;

                    if (op != null)
                    {
                        var opId = op.SubItems[0].Text;
                        ops.Add(int.Parse(opId));
                    }
                }

                ordenesDeEntrega.OrdenesPreparacion_OE = ops;

                CrearOrdenDeEntrega_model.CrearOrdenesDeEntrega(ordenesDeEntrega);

                MessageBox.Show("Se envió a despacho con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                CrearOrdenDeEntrega_form nuevaForma = new CrearOrdenDeEntrega_form();
                nuevaForma.Show();
            }
            else 
            {
                MessageBox.Show("No hay órdenes de preparacion pendientes de envio a despacho.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
