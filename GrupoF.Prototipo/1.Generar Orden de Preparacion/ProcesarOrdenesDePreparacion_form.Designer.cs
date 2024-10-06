namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    partial class Generar_orden_preparacion
    {
        private OrdnesDePreparacionModel _ordenesModel = new OrdnesDePreparacionModel();

        private void CargarDepositos()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            ComboBox_Descripcion_Deposito.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var deposito in _ordenesModel.Depositos)
            {
                ComboBox_Descripcion_Deposito.Items.Add(deposito.Nombre_Deposito);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (ComboBox_Descripcion_Deposito.Items.Count > 0)
            {
                ComboBox_Descripcion_Deposito.SelectedIndex = 0;
            }
        }

        private void CargarMercaderias()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            ComboBox_Descripcion_Mercaderia.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var mercaderia in _ordenesModel.Mercaderias)
            {
                ComboBox_Descripcion_Mercaderia.Items.Add(mercaderia.Descripcion_Mercaderia);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (ComboBox_Descripcion_Mercaderia.Items.Count > 0)
            {
                ComboBox_Descripcion_Mercaderia.SelectedIndex = 0;
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
        /// 

        private void InitializeComponent()
        {
            TextBox_Id_Cliente = new TextBox();
            TextBox_Cantidad = new TextBox();
            TextBox_NombreApellido = new TextBox();
            TextBox_Dni = new TextBox();
            ComboBox_Descripcion_Mercaderia = new ComboBox();
            ComboBox_Descripcion_Deposito = new ComboBox();
            button_aceptar = new Button();
            button_salir = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox_Id_Cliente
            // 
            TextBox_Id_Cliente.Location = new Point(39, 55);
            TextBox_Id_Cliente.Name = "TextBox_Id_Cliente";
            TextBox_Id_Cliente.Size = new Size(100, 23);
            TextBox_Id_Cliente.TabIndex = 0;
            // 
            // TextBox_Cantidad
            // 
            TextBox_Cantidad.Location = new Point(303, 55);
            TextBox_Cantidad.Name = "TextBox_Cantidad";
            TextBox_Cantidad.Size = new Size(100, 23);
            TextBox_Cantidad.TabIndex = 1;
            // 
            // TextBox_NombreApellido
            // 
            TextBox_NombreApellido.Location = new Point(303, 56);
            TextBox_NombreApellido.Name = "TextBox_NombreApellido";
            TextBox_NombreApellido.Size = new Size(100, 23);
            TextBox_NombreApellido.TabIndex = 2;
            // 
            // TextBox_Dni
            // 
            TextBox_Dni.Location = new Point(43, 56);
            TextBox_Dni.Name = "TextBox_Dni";
            TextBox_Dni.Size = new Size(100, 23);
            TextBox_Dni.TabIndex = 3;
            // 
            // ComboBox_Descripcion_Mercaderia
            // 
            CargarMercaderias();
            ComboBox_Descripcion_Mercaderia.FormattingEnabled = true;
            ComboBox_Descripcion_Mercaderia.Location = new Point(43, 55);
            ComboBox_Descripcion_Mercaderia.Name = "ComboBox_Descripcion_Mercaderia";
            ComboBox_Descripcion_Mercaderia.Size = new Size(121, 23);
            ComboBox_Descripcion_Mercaderia.TabIndex = 4;
            // 
            // ComboBox_Descripcion_Deposito
            // 
            CargarDepositos();
            ComboBox_Descripcion_Deposito.FormattingEnabled = true;
            ComboBox_Descripcion_Deposito.Location = new Point(299, 55);
            ComboBox_Descripcion_Deposito.Name = "ComboBox_Descripcion_Deposito";
            ComboBox_Descripcion_Deposito.Size = new Size(121, 23);
            ComboBox_Descripcion_Deposito.TabIndex = 5;
            // 
            // button_aceptar
            // 
            button_aceptar.Location = new Point(326, 398);
            button_aceptar.Name = "button_aceptar";
            button_aceptar.Size = new Size(75, 23);
            button_aceptar.TabIndex = 6;
            button_aceptar.Text = "Aceptar";
            button_aceptar.UseVisualStyleBackColor = true;
            button_aceptar.Click += button_aceptar_click;
            // 
            // button_salir
            // 
            button_salir.Location = new Point(424, 398);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(75, 23);
            button_salir.TabIndex = 7;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TextBox_NombreApellido);
            groupBox1.Controls.Add(TextBox_Dni);
            groupBox1.Location = new Point(44, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Transportistas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 38);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Nombre y Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 38);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 85);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(ComboBox_Descripcion_Deposito);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(TextBox_Id_Cliente);
            groupBox3.Location = new Point(48, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 100);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Generales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 37);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Deposito";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 10;
            label1.Text = "Id Cliente";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(ComboBox_Descripcion_Mercaderia);
            groupBox4.Controls.Add(TextBox_Cantidad);
            groupBox4.Location = new Point(44, 130);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(445, 100);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Mercaderias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 37);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 37);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Descripcion";
            // 
            // Generar_orden_preparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 437);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button_salir);
            Controls.Add(button_aceptar);
            Name = "Generar_orden_preparacion";
            Text = "Generar Orden de Preparacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TextBox TextBox_Id_Cliente;
        private TextBox TextBox_Cantidad;
        private TextBox TextBox_NombreApellido;
        private TextBox TextBox_Dni;
        private ComboBox ComboBox_Descripcion_Mercaderia;
        private ComboBox ComboBox_Descripcion_Deposito;
        private Button button_aceptar;
        private Button button_salir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
    }
}