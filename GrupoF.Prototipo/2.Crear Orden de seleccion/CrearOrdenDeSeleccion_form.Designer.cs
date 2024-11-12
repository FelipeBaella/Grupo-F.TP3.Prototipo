
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System.Windows.Forms;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{


    partial class CrearOrdenDeSeleccion_form
    {
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
            agregarTodo_button = new Button();
            Ver_button = new Button();
            filtrar_groupBox4 = new GroupBox();
            button = new Button();
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
            Items_OS_listView = new ListView();
            ID_OP2 = new ColumnHeader();
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
            OrdenesDePreparacion_ListView.Location = new Point(4, 148);
            OrdenesDePreparacion_ListView.Margin = new Padding(4, 5, 4, 5);
            OrdenesDePreparacion_ListView.Name = "OrdenesDePreparacion_ListView";
            OrdenesDePreparacion_ListView.Size = new Size(858, 594);
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
            CrearOrden_button.Location = new Point(519, 947);
            CrearOrden_button.Margin = new Padding(4, 5, 4, 5);
            CrearOrden_button.Name = "CrearOrden_button";
            CrearOrden_button.Size = new Size(240, 55);
            CrearOrden_button.TabIndex = 1;
            CrearOrden_button.Text = "Crear orden de seleccion";
            CrearOrden_button.UseVisualStyleBackColor = true;
            CrearOrden_button.Click += button_Crear_Orden_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(767, 947);
            VolverAlMenu_button.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(144, 53);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(agregarTodo_button);
            groupBox1.Controls.Add(Ver_button);
            groupBox1.Controls.Add(filtrar_groupBox4);
            groupBox1.Controls.Add(Agregar_button);
            groupBox1.Controls.Add(OrdenesDePreparacion_ListView);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(873, 813);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de Preparacion Pendientes";
            // 
            // agregarTodo_button
            // 
            agregarTodo_button.Location = new Point(717, 755);
            agregarTodo_button.Margin = new Padding(4, 5, 4, 5);
            agregarTodo_button.Name = "agregarTodo_button";
            agregarTodo_button.Size = new Size(147, 48);
            agregarTodo_button.TabIndex = 9;
            agregarTodo_button.Text = "Agregar Todo";
            agregarTodo_button.Click += agregarTodo_button_Click;
            // 
            // Ver_button
            // 
            Ver_button.Location = new Point(451, 755);
            Ver_button.Margin = new Padding(4, 5, 4, 5);
            Ver_button.Name = "Ver_button";
            Ver_button.Size = new Size(120, 48);
            Ver_button.TabIndex = 2;
            Ver_button.Text = "Ver";
            Ver_button.Click += Ver_button_Click;
            // 
            // filtrar_groupBox4
            // 
            filtrar_groupBox4.Controls.Add(button);
            filtrar_groupBox4.Controls.Add(comboBox1);
            filtrar_groupBox4.Location = new Point(4, 35);
            filtrar_groupBox4.Margin = new Padding(4, 5, 4, 5);
            filtrar_groupBox4.Name = "filtrar_groupBox4";
            filtrar_groupBox4.Padding = new Padding(4, 5, 4, 5);
            filtrar_groupBox4.Size = new Size(507, 103);
            filtrar_groupBox4.TabIndex = 8;
            filtrar_groupBox4.TabStop = false;
            filtrar_groupBox4.Text = "Ordenar";
            // 
            // button
            // 
            button.Location = new Point(334, 35);
            button.Margin = new Padding(4, 5, 4, 5);
            button.Name = "button";
            button.Size = new Size(119, 42);
            button.TabIndex = 1;
            button.Text = "Aplicar";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID OP", "Prioridad Cliente ", "Fecha Entrega ", "Nombre Cliente" });
            comboBox1.Location = new Point(4, 35);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 36);
            comboBox1.TabIndex = 0;
            // 
            // Agregar_button
            // 
            Agregar_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Agregar_button.Location = new Point(580, 755);
            Agregar_button.Margin = new Padding(4, 5, 4, 5);
            Agregar_button.Name = "Agregar_button";
            Agregar_button.Size = new Size(129, 48);
            Agregar_button.TabIndex = 7;
            Agregar_button.Text = "Agregar";
            Agregar_button.UseVisualStyleBackColor = true;
            Agregar_button.Click += Agregar_button_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ItemsOP_listView2);
            groupBox2.Location = new Point(930, 25);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(660, 570);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Items Orden de Preparacion";
            // 
            // ItemsOP_listView2
            // 
            ItemsOP_listView2.Columns.AddRange(new ColumnHeader[] { Item2, Descripcion, Cantidad });
            ItemsOP_listView2.Location = new Point(9, 37);
            ItemsOP_listView2.Margin = new Padding(4, 5, 4, 5);
            ItemsOP_listView2.Name = "ItemsOP_listView2";
            ItemsOP_listView2.Size = new Size(633, 521);
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
            Descripcion.Text = "Descripcion MercaderiaEnt";
            Descripcion.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad MercaderiaEnt";
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
            Descrip_Merc.Text = "Descripcion MercaderiaEnt";
            Descrip_Merc.Width = 140;
            // 
            // Cant_Merc
            // 
            Cant_Merc.Text = "Cantidad MercaderiaEnt";
            Cant_Merc.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Remover_button);
            groupBox3.Controls.Add(Items_OS_listView);
            groupBox3.Location = new Point(930, 605);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(647, 403);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Items Orden de Seleccion";
            // 
            // Remover_button
            // 
            Remover_button.Location = new Point(521, 350);
            Remover_button.Margin = new Padding(4, 5, 4, 5);
            Remover_button.Name = "Remover_button";
            Remover_button.Size = new Size(107, 38);
            Remover_button.TabIndex = 0;
            Remover_button.Text = "Remover";
            Remover_button.Click += Remover_button_Click;
            // 
            // Items_OS_listView
            // 
            Items_OS_listView.CheckBoxes = true;
            Items_OS_listView.Columns.AddRange(new ColumnHeader[] { ID_OP2, Nombre_Cliente1 });
            Items_OS_listView.Location = new Point(16, 35);
            Items_OS_listView.Margin = new Padding(4, 5, 4, 5);
            Items_OS_listView.Name = "Items_OS_listView";
            Items_OS_listView.Size = new Size(495, 354);
            Items_OS_listView.TabIndex = 1;
            Items_OS_listView.UseCompatibleStateImageBehavior = false;
            Items_OS_listView.View = View.Details;
            // 
            // ID_OP2
            // 
            ID_OP2.Text = "ID OP";
            ID_OP2.Width = 100;
            // 
            // Nombre_Cliente1
            // 
            Nombre_Cliente1.Text = "Nombre Cliente";
            Nombre_Cliente1.Width = 120;
            // 
            // CrearOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 1020);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(CrearOrden_button);
            Margin = new Padding(4, 5, 4, 5);
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
        private ColumnHeader DepositoEnt;
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
        private ListView Items_OS_listView;
        private ColumnHeader Item;
        private ColumnHeader ID_OP2;
        private ColumnHeader Nombre_Cliente1;
        private Button Remover_button;
        private ListView ItemsOP_listView2;
        private ColumnHeader Item2;
        private ColumnHeader Descripcion;
        private ColumnHeader Cantidad;
        private GroupBox filtrar_groupBox4;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button;
        private ColumnHeader VER;
        private Button Ver_button;
        private Button agregarTodo_button;
    }
}