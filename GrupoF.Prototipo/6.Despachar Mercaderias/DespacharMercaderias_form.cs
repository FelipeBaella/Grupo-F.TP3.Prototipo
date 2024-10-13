using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    public partial class DespacharMercaderias_form : Form
    {
        private Datos_model Datos_model = new Datos_model();

        public DespacharMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDeEntrega();
        }

        private void ProcesarOrdenDeEntrega_button_Click(object sender, EventArgs e)
        {
            string Id_Transportista = IdOrdenDeEntrega_textBox.Text.Trim();

            if (Id_Transportista == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            if (!Id_Transportista.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            if (!Datos_model.Transportistas.Any(o => o.Dni_Transportista == int.Parse(Id_Transportista)))
            {
                MessageBox.Show("Debes seleccionar un Transportista valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            var Id_Remito = Datos_model.OrdenesDePreparacion
            .Where(o => o.Id_OrdenDePreparacion == int.Parse(Id_Transportista))
            .Select(o => o.Id_Remito)
            .FirstOrDefault();

            if (Id_Remito == null)
            {
                MessageBox.Show("Para procesar la Orden de Entrega, primero se le deberá crear un remito a la Orden de Preparación asociada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DespacharMercaderias_form_Load(object sender, EventArgs e)
        {

        }
    }
}
