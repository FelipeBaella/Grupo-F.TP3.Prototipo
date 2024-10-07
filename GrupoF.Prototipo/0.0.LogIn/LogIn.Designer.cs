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
            Usuario_textBox = new TextBox();
            Contrasena_textbox = new TextBox();
            Usuario_label = new Label();
            Contraseña_label = new Label();
            Ingresar_button = new Button();
            SuspendLayout();
            // 
            // Usuario_textBox
            // 
            Usuario_textBox.Location = new Point(76, 122);
            Usuario_textBox.Name = "Usuario_textBox";
            Usuario_textBox.Size = new Size(183, 23);
            Usuario_textBox.TabIndex = 0;
            // 
            // Contrasena_textbox
            // 
            Contrasena_textbox.Location = new Point(76, 199);
            Contrasena_textbox.Name = "Contrasena_textbox";
            Contrasena_textbox.Size = new Size(183, 23);
            Contrasena_textbox.TabIndex = 1;
            // 
            // Usuario_label
            // 
            Usuario_label.AutoSize = true;
            Usuario_label.Location = new Point(77, 103);
            Usuario_label.Name = "Usuario_label";
            Usuario_label.Size = new Size(47, 15);
            Usuario_label.TabIndex = 2;
            Usuario_label.Text = "Usuario";
            // 
            // Contraseña_label
            // 
            Contraseña_label.AutoSize = true;
            Contraseña_label.Location = new Point(77, 181);
            Contraseña_label.Name = "Contraseña_label";
            Contraseña_label.Size = new Size(67, 15);
            Contraseña_label.TabIndex = 3;
            Contraseña_label.Text = "Contraseña";
            // 
            // Ingresar_button
            // 
            Ingresar_button.Location = new Point(131, 245);
            Ingresar_button.Name = "Ingresar_button";
            Ingresar_button.Size = new Size(75, 23);
            Ingresar_button.TabIndex = 4;
            Ingresar_button.Text = "Ingresar";
            Ingresar_button.UseVisualStyleBackColor = true;
            Ingresar_button.Click += button_Ingresar_Click;
            // 
            // LogIn_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(Ingresar_button);
            Controls.Add(Contraseña_label);
            Controls.Add(Usuario_label);
            Controls.Add(Contrasena_textbox);
            Controls.Add(Usuario_textBox);
            Name = "LogIn_form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuario_textBox;
        private TextBox Contrasena_textbox;
        private Label Usuario_label;
        private Label Contraseña_label;
        private Button Ingresar_button;
    }
}