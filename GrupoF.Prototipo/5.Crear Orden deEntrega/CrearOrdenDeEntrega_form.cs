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

namespace GrupoF.Prototipo._5.Crear_Orden_deEntrega
{
    public partial class CrearOrdenDeEntrega_form : Form
    {
        public CrearOrdenDeEntrega_form()
        {
            InitializeComponent();
        }

        private void EnviadoADespacho_button1_Click(object sender, EventArgs e)
        {

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
