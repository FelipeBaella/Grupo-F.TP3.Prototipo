using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

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
            Salir_button2 = new Button();
            EnviadoADespacho_button = new Button();
            OrdenesDePreparacion_ListView = new ListView();
            ID_OP = new ColumnHeader();
            OPPreparadasgroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OPPreparadasgroupBox1
            // 
            OPPreparadasgroupBox1.Controls.Add(Salir_button2);
            OPPreparadasgroupBox1.Controls.Add(EnviadoADespacho_button);
            OPPreparadasgroupBox1.Controls.Add(OrdenesDePreparacion_ListView);
            OPPreparadasgroupBox1.Location = new Point(0, 0);
            OPPreparadasgroupBox1.Name = "OPPreparadasgroupBox1";
            OPPreparadasgroupBox1.Size = new Size(275, 410);
            OPPreparadasgroupBox1.TabIndex = 0;
            OPPreparadasgroupBox1.TabStop = false;
            OPPreparadasgroupBox1.Text = "Ordenes de Preparacion Preparadas";
            // 
            // Salir_button2
            // 
            Salir_button2.Location = new Point(169, 371);
            Salir_button2.Name = "Salir_button2";
            Salir_button2.Size = new Size(94, 29);
            Salir_button2.TabIndex = 2;
            Salir_button2.Text = "Volver al Menu";
            Salir_button2.UseVisualStyleBackColor = true;
            Salir_button2.Click += Salir_button2_Click;
            // 
            // EnviadoADespacho_button
            // 
            EnviadoADespacho_button.Location = new Point(32, 371);
            EnviadoADespacho_button.Name = "EnviadoADespacho_button";
            EnviadoADespacho_button.Size = new Size(131, 29);
            EnviadoADespacho_button.TabIndex = 1;
            EnviadoADespacho_button.Text = "Enviado a Despacho";
            EnviadoADespacho_button.UseVisualStyleBackColor = true;
            EnviadoADespacho_button.Click += EnviadoADespacho_button_Click;
            // 
            // OrdenesDePreparacion_ListView
            // 
            OrdenesDePreparacion_ListView.Columns.AddRange(new ColumnHeader[] { ID_OP });
            OrdenesDePreparacion_ListView.Location = new Point(6, 22);
            OrdenesDePreparacion_ListView.Name = "OrdenesDePreparacion_ListView";
            OrdenesDePreparacion_ListView.Size = new Size(257, 343);
            OrdenesDePreparacion_ListView.TabIndex = 0;
            OrdenesDePreparacion_ListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_ListView.View = View.Details;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            ID_OP.Width = 70;
            // 
            // CrearOrdenDeEntrega_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 423);
            Controls.Add(OPPreparadasgroupBox1);
            Name = "CrearOrdenDeEntrega_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Orden De Entrega";
            Load += CrearOrdenDeEntrega_form_Load;
            OPPreparadasgroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox OPPreparadasgroupBox1;
        private ListView listView1;
        private Button Salir_button2;
        private Button EnviadoADespacho_button;
        private ColumnHeader Estado_OP;
        private ColumnHeader Deposito;
        private ColumnHeader ID_OP;
        private ListView listView;
        private ListView OrdenesDePreparacion_listView;
        private ListView OrdenesDePreparacion_ListView;
    }
}