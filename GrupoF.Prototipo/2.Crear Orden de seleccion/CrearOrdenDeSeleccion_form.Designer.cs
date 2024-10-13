using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{


    partial class CrearOrdenDeSeleccion_form
    {    
        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in Datos_model.OrdenesDePreparacion)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == orden.Id_Mercaderia).FirstOrDefault();
                var depositos = Datos_model.Depositos.Where(x => x.Id_Deposito == orden.Id_Deposito).FirstOrDefault();


                ListViewItem listViewItem = new ListViewItem(new string[] {

                    orden.Emision_OrdenDePreparacion.ToString(),
                    orden.Prioridad_OrdenDePreparacion.ToString(),
                    orden.Id_OrdenDePreparacion.ToString(),
                    orden.Id_Cliente.ToString(),
                    cliente.NombreApellido,
                    orden.Emision_OrdenDePreparacion.ToString(),
                    mercaderia.Descripcion_Mercaderia,
                    orden.Cantidad_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,
                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
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
            Estado_OP = new ColumnHeader();
            Deposito = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_cliente = new ColumnHeader();
            Nombre_Cliente = new ColumnHeader();
            Fecha_Entrega_OP = new ColumnHeader();
            CrearOrden_button = new Button();
            VolverAlMenu_button = new Button();
            groupBox1 = new GroupBox();
            Agregar_button1 = new Button();
            groupBox2 = new GroupBox();
            ItemsOP_listView2 = new ListView();
            ID_OP3 = new ColumnHeader();
            Itm_OP = new ColumnHeader();
            Descrip_merc1 = new ColumnHeader();
            Cant_Merc1 = new ColumnHeader();
            ID_OP1 = new ColumnHeader();
            Item_OP = new ColumnHeader();
            Descrip_Merc = new ColumnHeader();
            Cant_Merc = new ColumnHeader();
            groupBox3 = new GroupBox();
            Remover_button1 = new Button();
            Items_OS_listView2 = new ListView();
            Item = new ColumnHeader();
            Id_OP2 = new ColumnHeader();
            Nombre_Cliente1 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesDePreparacion_ListView
            // 
            OrdenesDePreparacion_ListView.CheckBoxes = true;
            OrdenesDePreparacion_ListView.Columns.AddRange(new ColumnHeader[] { Estado_OP, Deposito, ID_OP, Prioridad_cliente, Nombre_Cliente, Fecha_Entrega_OP });
            OrdenesDePreparacion_ListView.Location = new Point(11, 22);
            OrdenesDePreparacion_ListView.Name = "OrdenesDePreparacion_ListView";
            OrdenesDePreparacion_ListView.Size = new Size(604, 288);
            OrdenesDePreparacion_ListView.TabIndex = 0;
            OrdenesDePreparacion_ListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_ListView.View = View.Details;
            // 
            // Estado_OP
            // 
            Estado_OP.Text = "Estado OP";
            Estado_OP.Width = 70;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
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
            // Nombre_Cliente
            // 
            Nombre_Cliente.Text = "Nombre Cliente";
            Nombre_Cliente.Width = 140;
            // 
            // Fecha_Entrega_OP
            // 
            Fecha_Entrega_OP.Text = "Fecha Entrega OP";
            Fecha_Entrega_OP.Width = 120;
            // 
            // CrearOrden_button
            // 
            CrearOrden_button.Location = new Point(805, 568);
            CrearOrden_button.Name = "CrearOrden_button";
            CrearOrden_button.Size = new Size(168, 33);
            CrearOrden_button.TabIndex = 1;
            CrearOrden_button.Text = "Crear orden de seleccion";
            CrearOrden_button.UseVisualStyleBackColor = true;
            CrearOrden_button.Click += button_Crear_Orden_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(1000, 568);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(101, 32);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Agregar_button1);
            groupBox1.Controls.Add(OrdenesDePreparacion_ListView);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 348);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de Preparacion Pendientes";
            // 
            // Agregar_button1
            // 
            Agregar_button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Agregar_button1.Location = new Point(525, 316);
            Agregar_button1.Name = "Agregar_button1";
            Agregar_button1.Size = new Size(90, 29);
            Agregar_button1.TabIndex = 7;
            Agregar_button1.Text = "Agregar";
            Agregar_button1.UseVisualStyleBackColor = true;
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
            ItemsOP_listView2.CheckBoxes = true;
            ItemsOP_listView2.Columns.AddRange(new ColumnHeader[] { ID_OP3, Itm_OP, Descrip_merc1, Cant_Merc1 });
            ItemsOP_listView2.Location = new Point(6, 22);
            ItemsOP_listView2.Name = "ItemsOP_listView2";
            ItemsOP_listView2.Size = new Size(444, 314);
            ItemsOP_listView2.TabIndex = 9;
            ItemsOP_listView2.UseCompatibleStateImageBehavior = false;
            ItemsOP_listView2.View = View.Details;
            // 
            // ID_OP3
            // 
            ID_OP3.Text = "Estado OP";
            ID_OP3.Width = 70;
            // 
            // Itm_OP
            // 
            Itm_OP.Text = "Deposito";
            Itm_OP.Width = 100;
            // 
            // Descrip_merc1
            // 
            Descrip_merc1.Text = "Descripcion Mercaderia";
            Descrip_merc1.Width = 140;
            // 
            // Cant_Merc1
            // 
            Cant_Merc1.Text = "Cantidad Mercaderia";
            Cant_Merc1.Width = 130;
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
            groupBox3.Controls.Add(Remover_button1);
            groupBox3.Controls.Add(Items_OS_listView2);
            groupBox3.Location = new Point(12, 366);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(453, 242);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Items Orden de Seleccion";
            // 
            // Remover_button1
            // 
            Remover_button1.Location = new Point(365, 211);
            Remover_button1.Name = "Remover_button1";
            Remover_button1.Size = new Size(82, 24);
            Remover_button1.TabIndex = 2;
            Remover_button1.Text = "Remover";
            Remover_button1.UseVisualStyleBackColor = true;
            // 
            // Items_OS_listView2
            // 
            Items_OS_listView2.CheckBoxes = true;
            Items_OS_listView2.Columns.AddRange(new ColumnHeader[] { Item, Id_OP2, Nombre_Cliente1 });
            Items_OS_listView2.Location = new Point(11, 21);
            Items_OS_listView2.Name = "Items_OS_listView2";
            Items_OS_listView2.Size = new Size(348, 214);
            Items_OS_listView2.TabIndex = 1;
            Items_OS_listView2.UseCompatibleStateImageBehavior = false;
            Items_OS_listView2.View = View.Details;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.Width = 70;
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
            Text = "Crear Orden de seleccion";
            groupBox1.ResumeLayout(false);
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
        private Button Agregar_button1;
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
        private Button Remover_button1;
        private ListView ItemsOP_listView2;
        private ColumnHeader ID_OP3;
        private ColumnHeader Itm_OP;
        private ColumnHeader Descrip_merc1;
        private ColumnHeader Cant_Merc1;
    }
}