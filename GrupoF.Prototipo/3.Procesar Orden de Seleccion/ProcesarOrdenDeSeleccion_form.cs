using GrupoF.Prototipo._0.Menu;
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

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    public partial class ProcesarOrdenDeSeleccion_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public ProcesarOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {      
            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }


    }
}
