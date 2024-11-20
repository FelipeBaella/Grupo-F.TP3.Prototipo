using GrupoF.Prototipo._1._2_Detalles_Op;
using GrupoF.Prototipo.Almacenes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrupoF.Prototipo._1._1_Reportes_OP
{
    public partial class ReporteOP_form : Form
    {
        private ReporteOP_model model = new ReporteOP_model();

        public ReporteOP_form()
        {
            InitializeComponent();
            CargarListaOps();
            CargarEstadosOp();
        }

        private void CargarListaOps()
        {
            var lista = model.CargarOps();

            var ver = "ver";

            foreach (var op in lista)
            {
                var deposito = model.Depositos().Where(x => x.ID_Deposito == op.ID_Deposito).SingleOrDefault().Descripcion_Deposito;

                var cliente = model.Clientes().Where(x => x.ID_Cliente == op.ID_Cliente).SingleOrDefault().NombreApellido_Cliente;

                var prioridad = op.Prioridad_OP.ToString();

                if (prioridad == "True")
                {
                    prioridad = "prioritario";
                }
                else { prioridad = "no prioritario"; }

                ListViewItem listViewItem = new ListViewItem(new string[] {

                     op.ID_OP.ToString(),
                     op.Estado_OP.ToString(),
                     prioridad.ToString(),
                     cliente.ToString(),
                     deposito.ToString(),
                     op.FechaEmision_OP.ToString(),
                     op.FechaEntrega_OP.ToString(),
                     op.DNI_Transportista.ToString(),
                     ver.ToString()


                }, -1);

                listaOps.Items.Add(listViewItem);
            }
        }


        private void CargarEstadosOp()
        {
            var lista = model.CargarListaEstadosOp();

            var ver = "ver";

            foreach (var estOp in lista)
            {
                estadosOp.Items.Add(estOp);
            }
        }

        private void VerItems_Click(object sender, EventArgs e)
        {
            var id = detalle.Text;

            DetalleOp_form nuevaForma = new DetalleOp_form(id);
            nuevaForma.Show();
        }
    }
}
