using GrupoF.Prototipo._0.Menu;
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
    public partial class ProcesarOrdenDeEntrega_form : Form
    {
        public ProcesarOrdenDeEntrega_form()
        {
            InitializeComponent();
        }

        private void ProcesarOrdenDeEntrega_button_Click(object sender, EventArgs e)
        {

        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }
    }
}
