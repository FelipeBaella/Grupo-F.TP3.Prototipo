using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Base_de_Datos;
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
        private Datos_model Datos_model = new Datos_model();

        public CrearOrdenDeEntrega_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
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
