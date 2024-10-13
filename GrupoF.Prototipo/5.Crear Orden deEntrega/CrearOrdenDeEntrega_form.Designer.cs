namespace GrupoF.Prototipo._5.Crear_Orden_deEntrega
{
    partial class CrearOrdenDeEntrega_form
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
            OPPreparadasgroupBox1 = new GroupBox();
            listView1 = new ListView();
            Estado_OP = new ColumnHeader();
            Deposito = new ColumnHeader();
            ID_OP = new ColumnHeader();
            EnviadoADespacho_button1 = new Button();
            Salir_button2 = new Button();
            OPPreparadasgroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OPPreparadasgroupBox1
            // 
            OPPreparadasgroupBox1.Controls.Add(Salir_button2);
            OPPreparadasgroupBox1.Controls.Add(EnviadoADespacho_button1);
            OPPreparadasgroupBox1.Controls.Add(listView1);
            OPPreparadasgroupBox1.Location = new Point(0, 0);
            OPPreparadasgroupBox1.Name = "OPPreparadasgroupBox1";
            OPPreparadasgroupBox1.Size = new Size(275, 410);
            OPPreparadasgroupBox1.TabIndex = 0;
            OPPreparadasgroupBox1.TabStop = false;
            OPPreparadasgroupBox1.Text = "Ordenes de Preparacion Preparadas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Estado_OP, Deposito, ID_OP });
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(257, 343);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Estado_OP
            // 
            Estado_OP.Text = "Estado OP";
            Estado_OP.Width = 80;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 80;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            ID_OP.Width = 70;
            // 
            // EnviadoADespacho_button1
            // 
            EnviadoADespacho_button1.Location = new Point(32, 371);
            EnviadoADespacho_button1.Name = "EnviadoADespacho_button1";
            EnviadoADespacho_button1.Size = new Size(131, 29);
            EnviadoADespacho_button1.TabIndex = 1;
            EnviadoADespacho_button1.Text = "Enviado a Despacho";
            EnviadoADespacho_button1.UseVisualStyleBackColor = true;
            EnviadoADespacho_button1.Click += EnviadoADespacho_button1_Click;
            // 
            // Salir_button2
            // 
            Salir_button2.Location = new Point(169, 371);
            Salir_button2.Name = "Salir_button2";
            Salir_button2.Size = new Size(94, 29);
            Salir_button2.TabIndex = 2;
            Salir_button2.Text = "Volver al Menu";
            Salir_button2.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenDeEntrega_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 423);
            Controls.Add(OPPreparadasgroupBox1);
            Name = "CrearOrdenDeEntrega_form";
            Text = "CrearOrdenDeEntrega_form";
            OPPreparadasgroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OPPreparadasgroupBox1;
        private ListView listView1;
        private Button Salir_button2;
        private Button EnviadoADespacho_button1;
        private ColumnHeader Estado_OP;
        private ColumnHeader Deposito;
        private ColumnHeader ID_OP;
    }
}