namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    partial class Form1
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
            TextBox_Id_Cliente = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            ComboBox_Descripcion_Deposito = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            TextBox_Id_Cliente.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(43, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ComboBox_Descripcion_Deposito
            // 
            ComboBox_Descripcion_Deposito.FormattingEnabled = true;
            ComboBox_Descripcion_Deposito.Location = new Point(299, 55);
            ComboBox_Descripcion_Deposito.Name = "ComboBox_Descripcion_Deposito";
            ComboBox_Descripcion_Deposito.Size = new Size(121, 23);
            ComboBox_Descripcion_Deposito.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(326, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(424, 398);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Location = new Point(44, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Transportistas";
            groupBox1.Enter += groupBox1_Enter;
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
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Location = new Point(44, 130);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(445, 100);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Mercaderias";
            groupBox4.Enter += groupBox4_Enter;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 37);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Deposito";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 37);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 38);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 5;
            label6.Text = "Nombre y Apellido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 437);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox ComboBox_Descripcion_Deposito;
        private Button button1;
        private Button button2;
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