using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo._4.Crear_Orden_de_Entrega;
using GrupoF.Prototipo._5.Crear_Orden_deEntrega;
using GrupoF.Prototipo._6.Procesar_Orden_de_Entrega;
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

namespace GrupoF.Prototipo._0.Menu
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void button_CrearOrdenDePreparacion_Click(object sender, EventArgs e)
        {
            this.Hide();

            CrearOrdenDePreparacion_form nuevaForma = new CrearOrdenDePreparacion_form();
            nuevaForma.Show();
        }

        private void button_CrearOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            this.Hide();

            CrearOrdenDeSeleccion_form nuevaForma = new CrearOrdenDeSeleccion_form();
            nuevaForma.Show();
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProcesarOrdenDeSeleccion_form nuevaForma = new ProcesarOrdenDeSeleccion_form();
            nuevaForma.Show();
        }      

        private void button_ProcesarOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            this.Hide();

            DespacharMercaderias_form nuevaForma = new DespacharMercaderias_form();
            nuevaForma.Show();
        }

        private void button_CrearOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmpaquetarMercaderias_form nuevaForma = new EmpaquetarMercaderias_form();
            nuevaForma.Show();
        }

        private void button_DesacharMercaderias_Click(object sender, EventArgs e)
        {
            this.Hide();

            CrearOrdenDeEntrega_form nuevaForma = new CrearOrdenDeEntrega_form();
            nuevaForma.Show();
        }


        private void button_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }        
        }
    }
}
