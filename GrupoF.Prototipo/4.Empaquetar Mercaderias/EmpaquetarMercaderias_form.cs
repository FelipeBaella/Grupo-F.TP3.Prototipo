using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    public partial class EmpaquetarMercaderias_form : Form
    {
        private EmpaquetarMercaderias_model EmpaquetarMercaderias_model = new EmpaquetarMercaderias_model();

        public EmpaquetarMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacionItems();
        }

        private void CargarOrdenesDePreparacionItems()
        {
            var ordenes = OrdenDePreparacionAlmacen.OrdenesDePreparacion
             .Where(x => x.Estado_OP == EstadoOPEnum.EnPreparacion)
             .First();

            var OPItems = ordenes.Mercaderias_OP;

            foreach (var orden in OPItems)
            {         
                var MercaderiaEnt = MercaderiaAlmacen.Mercaderias.Where(x => x.ID_Mercaderia == orden.ID_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    MercaderiaEnt.Descripcion_Mercaderia,
                    orden.Cantidad_Mercaderia.ToString(),

                }, -1);

                OrdenesDePreparacion_listView.Items.Add(listViewItem);
            }
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void button_empaquetar_Click(object sender, EventArgs e)
        {
            var id = OrdenDePreparacionAlmacen.OrdenesDePreparacion
             .Where(x => x.Estado_OP == EstadoOPEnum.EnPreparacion)
             .First().ID_OP;

            EmpaquetarMercaderias_model.EditarEstadoOP(id);

            MessageBox.Show("Se listo con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            EmpaquetarMercaderias_form nuevaForma = new EmpaquetarMercaderias_form();
            nuevaForma.Show();
        }


    }
}
