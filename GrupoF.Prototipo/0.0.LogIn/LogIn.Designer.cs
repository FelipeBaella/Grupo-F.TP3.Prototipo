namespace GrupoF.Prototipo._0._0.LogIn_form
{
    partial class LogIn_form
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
            textBox_usuario = new TextBox();
            textBox_contrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Ingresar = new Button();
            SuspendLayout();
            // 
            // textBox_usuario
            // 
            textBox_usuario.Location = new Point(76, 122);
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(183, 23);
            textBox_usuario.TabIndex = 0;
            // 
            // textBox_contrasena
            // 
            textBox_contrasena.Location = new Point(76, 199);
            textBox_contrasena.Name = "textBox_contrasena";
            textBox_contrasena.Size = new Size(183, 23);
            textBox_contrasena.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 103);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 181);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // button_Ingresar
            // 
            button_Ingresar.Location = new Point(131, 245);
            button_Ingresar.Name = "button_Ingresar";
            button_Ingresar.Size = new Size(75, 23);
            button_Ingresar.TabIndex = 4;
            button_Ingresar.Text = "Ingresar";
            button_Ingresar.UseVisualStyleBackColor = true;
            button_Ingresar.Click += button_Ingresar_Click;
            // 
            // LogIn_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(button_Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_contrasena);
            Controls.Add(textBox_usuario);
            Name = "LogIn_form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_usuario;
        private TextBox textBox_contrasena;
        private Label label1;
        private Label label2;
        private Button button_Ingresar;
    }
}