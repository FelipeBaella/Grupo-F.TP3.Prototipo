using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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
        private ProcesarOrdenDeEntrega_model ProcesarOrdenDeEntrega_model_ = new ProcesarOrdenDeEntrega_model();

        public ProcesarOrdenDeEntrega_form()
        {
            InitializeComponent();
            CargarOrdenesDeEntrega();
        }

        private void ProcesarOrdenDeEntrega_button_Click(object sender, EventArgs e)
        {
            string Id_Orden = IdOrdenDeEntrega_textBox.Text.Trim();

            if (Id_Orden == "")
            {
                MessageBox.Show("Id no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            if (!Id_Orden.All(char.IsDigit))
            {
                MessageBox.Show("Id debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            if (!ProcesarOrdenDeEntrega_model_.OrdenesDeEntrega.Any(o => o.Id_OrdenDeEntrega == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdOrdenDeEntrega_textBox.Focus();
                return;
            }

            var Id_Remito = CrearOrdenDeSeleccion_model.OrdenesDePreparacion
            .Where(o => o.Id_OrdenDePreparacion == int.Parse(Id_Orden))
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

    }
}
