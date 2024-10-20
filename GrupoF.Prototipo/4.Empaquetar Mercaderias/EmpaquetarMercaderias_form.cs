﻿using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;

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

namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    public partial class EmpaquetarMercaderias_form : Form
    {
        private EmpaquetarMercaderias_model EmpaquetarMercaderias_model = new EmpaquetarMercaderias_model();

        public EmpaquetarMercaderias_form()
        {
            InitializeComponent();
            CargarOrdenesDePreparacion();
        }

        private void CargarOrdenesDePreparacion()
        {
            var ordenes = EmpaquetarMercaderias_model.OrdenesDePreparacion.Where(X => X.Id_EstadoOP == 3).First();

            var OrdenesDePreparacionItems = EmpaquetarMercaderias_model.OrdenesDePreparacionItems.Where(X => X.Id_OrdenDePreparacion == ordenes.Id_OrdenDePreparacion).ToList();

            foreach (var orden in OrdenesDePreparacionItems) 
            {
                var cliente = EmpaquetarMercaderias_model.Clientes.Where(x => x.Id_Cliente == ordenes.Id_Cliente).FirstOrDefault();
                var DepositoMercaderias = EmpaquetarMercaderias_model.DepositoMercaderias.Where(x => x.Id_DepositoMercaderias == orden.Id_DepositoMercaderias).FirstOrDefault();
                var mercaderia = EmpaquetarMercaderias_model.Mercaderias.Where(x => x.Id_Mercaderia == DepositoMercaderias.Id_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    mercaderia.Descripcion_Mercaderia,
                    orden.Cantidad_Mercaderia.ToString(),

                }, -1);

                OrdenesDePreparacion_listView.Items.Add(listViewItem);
            }     
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void button_empaquetar_Click(object sender, EventArgs e)
        {
            var id = EmpaquetarMercaderias_model.OrdenesDePreparacion.First().Id_OrdenDePreparacion;

            EmpaquetarMercaderias_model.EditarEstadoOP(id);

            MessageBox.Show("Se listo con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            EmpaquetarMercaderias_form nuevaForma = new EmpaquetarMercaderias_form();
            nuevaForma.Show();
        }

        private void IdOrdenDePreparacion_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpaquetarMercaderias_form_Load(object sender, EventArgs e)
        {

        }
    }
}
