using GrupoF.Prototipo.Almacenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.Prototipo._1._2_Detalles_Op
{
    public partial class DetalleOp_form : Form
    {
        private DetalleOp_model model = new DetalleOp_model();

        public DetalleOp_form(string id)
        {
            InitializeComponent();
            CargarItemsOp(int.Parse(id));

        }
        private void CargarItemsOp(int id)
        {
            var lista = model.CargarItemsOp(id);

            foreach (var item in lista)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {

                     item.Value.Item1.ToString(),                  
                     item.Value.Item2.ToString(),                  
                     item.Value.Item3.ToString(),                  
                     item.Value.Item4.ToString(),                  

                }, -1);

                listaItemsOp.Items.Add(listViewItem);
            }
        }


    }
}
