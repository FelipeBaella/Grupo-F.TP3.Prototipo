using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo.Almacenes;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections;
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
        private ProcesarOrdenDeSeleccion_model model = new ProcesarOrdenDeSeleccion_model();

        public ProcesarOrdenDeSeleccion_form()
        {
            InitializeComponent();
            CargarOrdenesDeSeleccion();
        }

        private void CargarOrdenesDePreparacionItems(string id)
        {
            var usuarioDeposito = model.ObtenerUsuarioDeposito();

            ProcesarOrdenesDeSeleccion_listView.Items.Clear();

            var OS = model.ObtenerOSs().Where(x => x.ID_OS == int.Parse(id)).SingleOrDefault();

            var OrdenesPreparacion_OS = OS.OrdenesPreparacion_OS;

            var lista = new Dictionary<int, (int, int, int, int)>();

            var i = 1;

            foreach (var item in OrdenesPreparacion_OS)
            {
                var OP = model.ObtenerOPs().Where(x => x.ID_OP == item && x.ID_Deposito == usuarioDeposito).SingleOrDefault();

                if (OP != null)
                {
                    var ID_Cliente = OP.ID_Cliente;
                    var ID_Deposito = OP.ID_Deposito;
                    var Mercaderias_OP = OP.Mercaderias_OP;

                    // Recorremos cada orden de preparación
                    foreach (var mercaderia in Mercaderias_OP)
                    {
                        lista.Add(i, (ID_Cliente, ID_Deposito, mercaderia.ID_Mercaderia, mercaderia.Cantidad_Mercaderia));

                        i++;
                    }
                }
            }

            var Mercaderias_OP_agrupadas = lista
             .GroupBy(x => new { x.Value.Item1, x.Value.Item2, x.Value.Item3 })  // Agrupamos por ID_Cliente, ID_Deposito, ID_Mercaderia
             .ToDictionary(
                 g => g.Key,  // La clave es el grupo de ID_Cliente, ID_Deposito, ID_Mercaderia
                 g => (
                     g.Key.Item1,  // ID_Cliente
                     g.Key.Item2,  // ID_Deposito
                     g.Key.Item3,  // ID_Mercaderia
                     g.Sum(x => x.Value.Item4)  // Suma de las cantidades
                 )
             );

            var depositosUsados = new HashSet<int>();

            var listViewItems = new Dictionary<int, (string, string, string)>();

            int e = 0;

            foreach (var item in Mercaderias_OP_agrupadas)
            {
                var cantidadRestante = item.Value.Item4;

                while (cantidadRestante > 0)
                {
                    var ID_Cliente = item.Value.Item1;
                    var ID_Deposito = item.Value.Item2;
                    var ID_Mercaderia = item.Value.Item3;

                    var ObtenerDepositosMercaderias = model.ObtenerDepositosMercaderias();

                    // Buscar un depósito con suficiente mercadería o el próximo disponible, excluyendo los ya usados
                    var depositoMercaderia = ObtenerDepositosMercaderias
                        .Where(x => x.ID_Cliente == ID_Cliente &&
                                    x.ID_Deposito == ID_Deposito &&
                                    x.ID_Mercaderia == ID_Mercaderia &&
                                    x.Cantidad_DepositoMercaderia > 0 &&
                                    !depositosUsados.Contains(x.ID_DepositoMercaderia))     
                        .FirstOrDefault();

                    if (depositoMercaderia != null)
                    {
                        // Añadir el depósito a la lista de usados
                        depositosUsados.Add(depositoMercaderia.ID_DepositoMercaderia);


                        var mercaderia = model.ObtenerMercaderias()
                            .Where(x => x.ID_Mercaderia == item.Value.Item3)
                            .FirstOrDefault()?.Descripcion_Mercaderia;

                        if (depositoMercaderia.Cantidad_DepositoMercaderia >= cantidadRestante)
                        {
                            listViewItems.Add(e, (depositoMercaderia.Coordenadas_DepositoMercaderia.ToString(), mercaderia, cantidadRestante.ToString()));

                            cantidadRestante = 0;

                            e++;
                        }
                        else
                        {
                            listViewItems.Add(e, (depositoMercaderia.Coordenadas_DepositoMercaderia.ToString(), mercaderia, depositoMercaderia.Cantidad_DepositoMercaderia.ToString()));

                            cantidadRestante -= depositoMercaderia.Cantidad_DepositoMercaderia;

                            e++;
                        }
                    }
                }
            }

            var itemsOrdenados = listViewItems.OrderBy(x => x.Value.Item1).ToList();

            foreach (var item in itemsOrdenados)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[]
                {
                          item.Value.Item1.ToString(),
                          item.Value.Item2.ToString(),
                          item.Value.Item3.ToString(),
                }, -1);

                ProcesarOrdenesDeSeleccion_listView.Items.Add(listViewItem1);
            }
        }

        private void VolverAlMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu_form nuevaForma = new Menu_form();

            nuevaForma.Show();
        }

        private void CargarOrdenesDeSeleccion()
        {
            var OrdenesDeSeleccion = model.ObtenerOSs().Where(x => x.Estado_OS == EstadoOSEnum.Emitida).ToList();
            var usuarioDeposito = model.ObtenerUsuarioDeposito();

            foreach (var orden in OrdenesDeSeleccion)
            {
                var depositoCorrecto = false;

                var Ops = orden.OrdenesPreparacion_OS;

                foreach (var op in Ops)
                {
                    var Op = model.ObtenerOPs().Any(x => x.ID_OP == op && x.ID_Deposito == usuarioDeposito);

                    if (Op == true)
                    {
                        depositoCorrecto = true;
                    }
                }

                if (depositoCorrecto == true)
                {
                    OS_Pendientes_comboBox.Items.AddRange(new object[] { orden.ID_OS.ToString() });
                }
            }
        }

        private void button_ProcesarOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            int id = 0;

            if (int.TryParse(OS_Pendientes_comboBox.Text, out id))
            {
                ProcesarOrdenDeSeleccion_model.EditarEstadoOS(id);

                MessageBox.Show("Se proceso la orden de seleccion con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                ProcesarOrdenDeSeleccion_form nuevaForma = new ProcesarOrdenDeSeleccion_form();
                nuevaForma.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una orden de seleccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OS_Pendientes_comboBox.Focus();
                return;
            }

        }

        private void OS_Pendientes_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = OS_Pendientes_comboBox.Text;

            CargarOrdenesDePreparacionItems(id);
        }
    }
}
