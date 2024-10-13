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

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void button_CrearOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            //se deberia quitar ya que no se utiliza
            /*
            string Id_Orden = IdOrdenDePreparacion_textbox.Text.Trim();

            if (Id_Orden == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDePreparacion_textbox.Focus();
                return;
            }

            if (!Id_Orden.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDePreparacion_textbox.Focus();
                return;
            }

            if (!Datos_model.OrdenesDeSeleccion.Any(o => o.Id_OrdenDeSeleccion == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDePreparacion_textbox.Focus();
                return;
            }

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
            */
        }

        private void IdOrdenDePreparacion_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpaquetarMercaderias_form_Load(object sender, EventArgs e)
        {

        }
    }
}
