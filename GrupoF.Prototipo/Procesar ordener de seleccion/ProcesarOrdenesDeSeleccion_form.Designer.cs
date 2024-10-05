namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{
    partial class ProcesarOrdenesDeSeleccion_form
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
            ListViewItem listViewItem1 = new ListViewItem("");
            listView1 = new ListView();
            Estado = new ColumnHeader();
            ID_Orden = new ColumnHeader();
            ID_Cliente = new ColumnHeader();
            Nombre_Cliente = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            Button_Crear_Orden = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Estado, Prioridad, ID_Orden, ID_Cliente, Nombre_Cliente, Fecha_Emision, Descripcion_Mercaderia, Cantidad, Deposito });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(12, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(879, 207);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 50;
            // 
            // ID_Orden
            // 
            ID_Orden.Text = "ID Orden";
            // 
            // ID_Cliente
            // 
            ID_Cliente.Text = "ID Cliente";
            ID_Cliente.Width = 70;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.Text = "Nombre Cliente";
            Nombre_Cliente.Width = 140;
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.Text = "Fecha Emision";
            Fecha_Emision.Width = 90;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 170;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // Button_Crear_Orden
            // 
            Button_Crear_Orden.Location = new Point(343, 314);
            Button_Crear_Orden.Name = "Button_Crear_Orden";
            Button_Crear_Orden.Size = new Size(158, 23);
            Button_Crear_Orden.TabIndex = 1;
            Button_Crear_Orden.Text = "Crear orden de seleccion";
            Button_Crear_Orden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 2;
            label1.Text = "Ordenes de preparacion";
            label1.Click += label1_Click;
            // 
            // ProcesarOrdenesDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 376);
            Controls.Add(label1);
            Controls.Add(Button_Crear_Orden);
            Controls.Add(listView1);
            Name = "ProcesarOrdenesDeSeleccion_form";
            Text = "ProcesarOrdenesDeSeleccion_form";
            Load += ProcesarOrdenesDeSeleccion_form_Load;
            ResumeLayout(false);
            PerformLayout();


            ListViewItem item = new ListViewItem("Pendiente"); // Valor de la primera columna (Estado)
            item.SubItems.Add("Alta"); // Valor de la columna Prioridad
            item.SubItems.Add("12345"); // ID Orden
            item.SubItems.Add("56789"); // ID Cliente
            item.SubItems.Add("Juan Pérez"); // Nombre Cliente
            item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy")); // Fecha Emision
            item.SubItems.Add("Mercadería Ejemplo"); // Descripción Mercadería
            item.SubItems.Add("10"); // Cantidad
            item.SubItems.Add("Depósito A"); // Depósito

            // Agregar el item al ListView
            listView1.Items.Add(item);



            ListViewItem item2 = new ListViewItem("Pendiente"); // Valor de la primera columna (Estado)
            item2.SubItems.Add("Alta"); // Valor de la columna Prioridad
            item2.SubItems.Add("12345"); // ID Orden
            item2.SubItems.Add("56789"); // ID Cliente
            item2.SubItems.Add("Juan Pérez"); // Nombre Cliente
            item2.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy")); // Fecha Emision
            item2.SubItems.Add("Mercadería Ejemplo"); // Descripción Mercadería
            item2.SubItems.Add("10"); // Cantidad
            item2.SubItems.Add("Depósito A"); // Depósito

            // Agregar el item al ListView
            listView1.Items.Add(item2);
        }



        #endregion

        private ListView listView1;
        private ColumnHeader Estado;
        private ColumnHeader Prioridad;
        private ColumnHeader ID_Orden;
        private ColumnHeader ID_Cliente;
        private ColumnHeader Nombre_Cliente;
        private ColumnHeader Fecha_Emision;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader Deposito;
        private Button Button_Crear_Orden;
        private Label label1;
        private TextBox textBox1;
        private TextBox prueba6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ColumnHeader Nombre;
    }
}