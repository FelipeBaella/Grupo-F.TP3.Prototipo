using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System.Windows.Forms;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{


    partial class CrearOrdenDeSeleccion_form
    {
        private void CargarOrdenesDePreparacion(List<OrdenesDePreparacion> ordenes)
        {
            OrdenesDePreparacion_ListView.Items.Clear();

            foreach (var orden in ordenes)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();

                var prioridad = "";

                if (orden.Prioridad_OrdenDePreparacion == true)
                {
                    prioridad = "Si";
                }
                else
                {
                    prioridad = "No";
                }

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        orden.Id_OrdenDePreparacion.ToString(),
                        prioridad,
                        orden.Emision_OrdenDePreparacion.ToString(),
                        cliente.NombreApellido,

                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
            }

        }

        private void CargarItemsOrdenesDePreparacion(int Id_ordenDePrparacion)
        {
            ItemsOP_listView2.Items.Clear();

            var listado = Datos_model.OrdenesDePreparacionItems.Where(x => x.Id_OrdenDePreparacion == Id_ordenDePrparacion).ToList();

            foreach (var item in listado)
            {
                var DepositoMercaderias = Datos_model.DepositoMercaderias.Where(x => x.Id_DepositoMercaderias == item.Id_DepositoMercaderias).FirstOrDefault();

                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == DepositoMercaderias.Id_Mercaderia).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                        item.Id_OrdenDePreparacionMercaderia.ToString(),
                        mercaderia.Descripcion_Mercaderia,
                        item.Cantidad_Mercaderia.ToString(),

                }, -1);

                ItemsOP_listView2.Items.Add(listViewItem);
            }
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdenesDePreparacion_ListView = new ListView();
            ID_OP = new ColumnHeader();
            Prioridad_cliente = new ColumnHeader();
            Fecha_Entrega_OP = new ColumnHeader();
            Nombre_Cliente = new ColumnHeader();
            CrearOrden_button = new Button();
            VolverAlMenu_button = new Button();
            groupBox1 = new GroupBox();
            seleccionarTodo_button = new Button();
            Ver_button = new Button();
            filtrar_groupBox4 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            Agregar_button = new Button();
            groupBox2 = new GroupBox();
            ItemsOP_listView2 = new ListView();
            Item2 = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Cantidad = new ColumnHeader();
            ID_OP1 = new ColumnHeader();
            Item_OP = new ColumnHeader();
            Descrip_Merc = new ColumnHeader();
            Cant_Merc = new ColumnHeader();
            groupBox3 = new GroupBox();
            Remover_button = new Button();
            Items_OS_listView2 = new ListView();
            Id_OP2 = new ColumnHeader();
            Nombre_Cliente1 = new ColumnHeader();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            filtrar_groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesDePreparacion_ListView
            // 
            OrdenesDePreparacion_ListView.BackColor = SystemColors.Window;
            OrdenesDePreparacion_ListView.BackgroundImageTiled = true;
            OrdenesDePreparacion_ListView.CheckBoxes = true;
            OrdenesDePreparacion_ListView.Columns.AddRange(new ColumnHeader[] { ID_OP, Prioridad_cliente, Fecha_Entrega_OP, Nombre_Cliente });
            OrdenesDePreparacion_ListView.FullRowSelect = true;
            OrdenesDePreparacion_ListView.GridLines = true;
            OrdenesDePreparacion_ListView.LabelEdit = true;
            OrdenesDePreparacion_ListView.Location = new Point(3, 89);
            OrdenesDePreparacion_ListView.Name = "OrdenesDePreparacion_ListView";
            OrdenesDePreparacion_ListView.Size = new Size(602, 358);
            OrdenesDePreparacion_ListView.TabIndex = 0;
            OrdenesDePreparacion_ListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_ListView.View = View.Details;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // Prioridad_cliente
            // 
            Prioridad_cliente.Text = "Prioridad Cliente";
            Prioridad_cliente.Width = 100;
            // 
            // Fecha_Entrega_OP
            // 
            Fecha_Entrega_OP.Text = "Fecha Entrega OP";
            Fecha_Entrega_OP.Width = 120;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.Text = "Nombre Cliente";
            Nombre_Cliente.Width = 140;
            // 
            // CrearOrden_button
            // 
            CrearOrden_button.Location = new Point(363, 568);
            CrearOrden_button.Name = "CrearOrden_button";
            CrearOrden_button.Size = new Size(168, 33);
            CrearOrden_button.TabIndex = 1;
            CrearOrden_button.Text = "Crear orden de seleccion";
            CrearOrden_button.UseVisualStyleBackColor = true;
            CrearOrden_button.Click += button_Crear_Orden_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(537, 568);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(101, 32);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(seleccionarTodo_button);
            groupBox1.Controls.Add(Ver_button);
            groupBox1.Controls.Add(filtrar_groupBox4);
            groupBox1.Controls.Add(Agregar_button);
            groupBox1.Controls.Add(OrdenesDePreparacion_ListView);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 488);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de Preparacion Pendientes";
            // 
            // seleccionarTodo_button
            // 
            seleccionarTodo_button.Location = new Point(3, 453);
            seleccionarTodo_button.Name = "seleccionarTodo_button";
            seleccionarTodo_button.Size = new Size(132, 29);
            seleccionarTodo_button.TabIndex = 9;
            seleccionarTodo_button.Text = "Seleccionar Todo";
            seleccionarTodo_button.Click += button2_Click;
            // 
            // Ver_button
            // 
            Ver_button.Location = new Point(427, 453);
            Ver_button.Name = "Ver_button";
            Ver_button.Size = new Size(84, 29);
            Ver_button.TabIndex = 2;
            Ver_button.Text = "Ver";
            Ver_button.Click += Ver_button_Click;
            // 
            // filtrar_groupBox4
            // 
            filtrar_groupBox4.Controls.Add(button1);
            filtrar_groupBox4.Controls.Add(comboBox1);
            filtrar_groupBox4.Location = new Point(3, 21);
            filtrar_groupBox4.Name = "filtrar_groupBox4";
            filtrar_groupBox4.Size = new Size(355, 62);
            filtrar_groupBox4.TabIndex = 8;
            filtrar_groupBox4.TabStop = false;
            filtrar_groupBox4.Text = "Filtros";
            // 
            // button1
            // 
            button1.Location = new Point(234, 21);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 1;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "---", "ID OP", "Prioridad Cliente ", "Fecha Entrega ", "Nombre Cliente" });
            comboBox1.Location = new Point(3, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 25);
            comboBox1.TabIndex = 0;
            // 
            // Agregar_button
            // 
            Agregar_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Agregar_button.Location = new Point(517, 453);
            Agregar_button.Name = "Agregar_button";
            Agregar_button.Size = new Size(90, 29);
            Agregar_button.TabIndex = 7;
            Agregar_button.Text = "Agregar";
            Agregar_button.UseVisualStyleBackColor = true;
            Agregar_button.Click += Agregar_button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ItemsOP_listView2);
            groupBox2.Location = new Point(651, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 342);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items Orden de Preparacion";
            // 
            // ItemsOP_listView2
            // 
            ItemsOP_listView2.Columns.AddRange(new ColumnHeader[] { Item2, Descripcion, Cantidad });
            ItemsOP_listView2.Location = new Point(6, 22);
            ItemsOP_listView2.Name = "ItemsOP_listView2";
            ItemsOP_listView2.Size = new Size(444, 314);
            ItemsOP_listView2.TabIndex = 9;
            ItemsOP_listView2.UseCompatibleStateImageBehavior = false;
            ItemsOP_listView2.View = View.Details;
            // 
            // Item2
            // 
            Item2.Text = "Item";
            Item2.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion Mercaderia";
            Descripcion.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad Mercaderia";
            Cantidad.Width = 130;
            // 
            // ID_OP1
            // 
            ID_OP1.Text = "ID OP";
            ID_OP1.Width = 70;
            // 
            // Item_OP
            // 
            Item_OP.Text = "Item OP";
            Item_OP.Width = 100;
            // 
            // Descrip_Merc
            // 
            Descrip_Merc.Text = "Descripcion Mercaderia";
            Descrip_Merc.Width = 140;
            // 
            // Cant_Merc
            // 
            Cant_Merc.Text = "Cantidad Mercaderia";
            Cant_Merc.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Remover_button);
            groupBox3.Controls.Add(Items_OS_listView2);
            groupBox3.Location = new Point(651, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(453, 242);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Items Orden de Seleccion";
            // 
            // Remover_button
            // 
            Remover_button.Location = new Point(365, 210);
            Remover_button.Name = "Remover_button";
            Remover_button.Size = new Size(75, 23);
            Remover_button.TabIndex = 0;
            Remover_button.Text = "Remover";
            Remover_button.Click += Remover_button_Click;
            // 
            // Items_OS_listView2
            // 
            Items_OS_listView2.CheckBoxes = true;
            Items_OS_listView2.Columns.AddRange(new ColumnHeader[] { Id_OP2, Nombre_Cliente1 });
            Items_OS_listView2.Location = new Point(11, 21);
            Items_OS_listView2.Name = "Items_OS_listView2";
            Items_OS_listView2.Size = new Size(348, 214);
            Items_OS_listView2.TabIndex = 1;
            Items_OS_listView2.UseCompatibleStateImageBehavior = false;
            Items_OS_listView2.View = View.Details;
            // 
            // Id_OP2
            // 
            Id_OP2.Text = "ID OP";
            Id_OP2.Width = 100;
            // 
            // Nombre_Cliente1
            // 
            Nombre_Cliente1.Text = "Nombre Cliente";
            Nombre_Cliente1.Width = 120;
            // 
            // CrearOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 612);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(CrearOrden_button);
            Name = "CrearOrdenDeSeleccion_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Orden de seleccion";
            groupBox1.ResumeLayout(false);
            filtrar_groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private ListView OrdenesDePreparacion_ListView;
        private ColumnHeader Estado_OP;
        private ColumnHeader Prioridad_cliente;
        private ColumnHeader ID_OP;
        private ColumnHeader Nombre_Cliente;
        private ColumnHeader Fecha_Entrega_OP;
        private ColumnHeader Deposito;
        private Button CrearOrden_button;
        private TextBox textBox1;
        private TextBox prueba6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ColumnHeader Nombre;
        private TextBox IdOrden_textBox;
        private Label label2;
        private Button VolverAlMenu_button;
        private GroupBox groupBox1;
        private Button Agregar_button;
        private GroupBox groupBox2;

        public ListView ItemsOP_listView1 { get; private set; }

        private ListView listView1;
        private ColumnHeader ID_OP1;
        private ColumnHeader Item_OP;
        private ColumnHeader Descrip_Merc;
        private ColumnHeader Cant_Merc;
        private GroupBox groupBox3;
        private ListView Items_OS_listView2;
        private ColumnHeader Item;
        private ColumnHeader Id_OP2;
        private ColumnHeader Nombre_Cliente1;
        private Button Remover_button;
        private ListView ItemsOP_listView2;
        private ColumnHeader Item2;
        private ColumnHeader Descripcion;
        private ColumnHeader Cantidad;
        private GroupBox filtrar_groupBox4;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private ColumnHeader VER;
        private Button Ver_button;
        private Button seleccionarTodo_button;
    }
}