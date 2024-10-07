using GrupoF.Prototipo._0.Menu;
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


namespace GrupoF.Prototipo._5.Crear_Remito
{
    public partial class CrearRemito_form : Form
    {
        private CrearRemito_model CrearRemito_model = new CrearRemito_model();
        private CrearOrdnesDePreparacion_model CrearOrdnesDePreparacion_model = new CrearOrdnesDePreparacion_model();

        public CrearRemito_form(int id = 0)
        {
            InitializeComponent();
            CargarDatos(id);
        }

        private void CargarDatos(int id)
        {
            var orden = CrearRemito_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == id).FirstOrDefault();

            if (orden != null)
            {
                var cliente = CrearOrdnesDePreparacion_model.Clientes.Where(x => x.Id_Cliente == id).FirstOrDefault();
                var mercaderia = CrearOrdnesDePreparacion_model.Mercaderias.Where(x => x.Id_Mercaderia == id).FirstOrDefault();

                NombreCliente_textBox.Text = cliente?.NombreApellido ?? "";
                DescripcionMercaderia_textBox.Text = mercaderia?.Descripcion_Mercaderia ?? "";
                CondicionFrenteAlIva_textbox.Text = cliente?.CondIva ?? "";
                CUIT_textBox.Text = cliente?.Cuit.ToString();
                Cantidad_textBox.Text = orden.Cantidad_OrdenDePreparacion.ToString();
                Domicilio_textBox.Text = cliente?.Domicilio ?? "";
                DNI_textBox.Text = orden.Dni_Transportista.ToString();
                NombreApellido_textBox.Text = orden.NombreApellido_Transportista;
            }
        }


        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            string idOP = Ingresar_ID_OP_textBox.Text;

            this.Hide();
            CrearRemito_form nuevaForma = new CrearRemito_form(int.Parse(idOP));
            nuevaForma.Show();
        }

        private void button_Emitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se creo el remito con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            Menu_form nuevaForma = new Menu_form();
            nuevaForma.Show();
        }
    }
}
