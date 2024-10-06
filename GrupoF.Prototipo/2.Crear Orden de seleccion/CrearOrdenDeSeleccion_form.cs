using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
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

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    public partial class ProcesarOrdenesDeSeleccion_form : Form
    {
        private CrearOrdenDeSeleccion_model _ordenesDeSeleccionModel = new CrearOrdenDeSeleccion_model();

        public ProcesarOrdenesDeSeleccion_form()
        {
            InitializeComponent();
        }

        private void Button_Crear_Orden_Click(object sender, EventArgs e)
        {
            string Id_Orden = textBox_Id_Orden.Text.Trim();


            if (!_ordenesDeSeleccionModel.OrdenesDePreparacion.Any(o => o.Id_OrdenDePreparacion == int.Parse(Id_Orden)))
            {
                MessageBox.Show("Debes seleccionar una orden valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Id_Orden.Focus();
                return;
            }

            MessageBox.Show("Se creo la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            Generar_orden_preparacion nuevaForma = new Generar_orden_preparacion();
            nuevaForma.Show();
        }
    }
}
