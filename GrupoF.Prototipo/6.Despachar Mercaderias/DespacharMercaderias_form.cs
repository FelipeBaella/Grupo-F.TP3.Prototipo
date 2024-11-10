using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    public partial class DespacharMercaderias_form : Form
    {
        private DespacharMercaderias_model DespacharMercaderias_model = new DespacharMercaderias_model();

        public DespacharMercaderias_form()
        {
            InitializeComponent();
            //CargarOrdenesDePreparacion();
        }

        //private void CargarOrdenesDePreparacion(int dniTransportista = 0)
        //{
        //    listView_OrdenesDePreparacion.Items.Clear();

        //    //var ordenes = DespacharMercaderias_model.OrdenDePreparacionEnt.Where(x => x.DNI_Transportista == 0).ToList();

        //    //if (dniTransportista != 0)
        //    //{
        //    //    ordenes = DespacharMercaderias_model.OrdenDePreparacionEnt.Where(x => x.DNI_Transportista == dniTransportista && x.Estado_OP == EstadoOPEnum.EnDespacho).ToList();
        //    //}

        //    foreach (var orden in ordenes)
        //    {
        //        ListViewItem listViewItem = new ListViewItem(new string[] {

        //            orden.ID_OP.ToString(),

        //        }, -1);

        //        listView_OrdenesDePreparacion.Items.Add(listViewItem);
        //    }
        //}

        private void Button_Buscar_OP_Transportista_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(DniTransportista_textBox.Text, out int dniTransportista))
            {
                MessageBox.Show("El campo transportista solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DniTransportista_textBox.Focus();
                return;
            }

            //CargarOrdenesDePreparacion(dniTransportista);
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Button_EmitirRemito_Click(object sender, EventArgs e)
        {
            int OrdenesDeEntrega = listView_OrdenesDePreparacion.Items.Count;

            if (OrdenesDeEntrega > 0)
            {
                var OrdenDePreparacionEnt = new List<int>();

                foreach (ListViewItem item in listView_OrdenesDePreparacion.Items)
                {
                    OrdenDePreparacionEnt.Add(int.Parse(item.SubItems[0].Text));
                }

                //DespacharMercaderias_model.EditarEstadoOP(OrdenDePreparacionEnt);

                MessageBox.Show("Se emitio el remito con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                DespacharMercaderias_form nuevaForma = new DespacharMercaderias_form();
                nuevaForma.Show();
            }
            else 
            {
                MessageBox.Show("El listado de ordenes de preparacion no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listView_OrdenesDePreparacion.Focus();
                return;
            }

        }
    }
}
