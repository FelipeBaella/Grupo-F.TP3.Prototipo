using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{


    partial class ProcesarOrdenesDeSeleccion_form
    {
        private OrdnesDePreparacionModel _ordenesModel = new OrdnesDePreparacionModel();

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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Pendiente", "Alta", "12345", "56789", "Juan Pérez", "06/10/2024", "Mercadería Ejemplo", "10", "Depósito A" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Pendiente", "Alta", "12345", "56789", "Juan Pérez", "06/10/2024", "Mercadería Ejemplo", "10", "Depósito B" }, -1);
            listView1 = new ListView();
            Estado = new ColumnHeader();
            Prioridad = new ColumnHeader();
            ID_Orden = new ColumnHeader();
            ID_Cliente = new ColumnHeader();
            Nombre_Cliente = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
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
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(12, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(810, 207);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 70;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
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