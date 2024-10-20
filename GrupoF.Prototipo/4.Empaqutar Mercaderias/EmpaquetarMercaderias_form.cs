using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    public partial class EmpaquetarMercaderias_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public EmpaquetarMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
        }

        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in Datos_model.OrdenesDePreparacion)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();
                var OrdenesDePreparacionItems = Datos_model.OrdenesDePreparacionItems.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();
                var DepositoMercaderias = Datos_model.DepositoMercaderias.Where(x => x.Id_DepositoMercaderias == OrdenesDePreparacionItems.Id_DepositoMercaderias).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == DepositoMercaderias.Id_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    mercaderia.Descripcion_Mercaderia,
                    OrdenesDePreparacionItems.Cantidad_Mercaderia.ToString(),

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
            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            EmpaquetarMercaderias_form nuevaForma = new EmpaquetarMercaderias_form();
            nuevaForma.Show();
        }

        private void IdOrdenDePreparacion_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpaquetarMercaderias_form_Load(object sender, EventArgs e)
        {

        }
    }
}
