using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    partial class DespacharMercaderias_form
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
            listView_OrdenesDeEntrega = new ListView();
            ID_OP = new ColumnHeader();
            IdOrdenDeEntrega_label = new Label();
            DniTransportista_textBox = new TextBox();
            BuscarDNI_button = new Button();
            VolverAlMenu_button = new Button();
            Datos_TrasnportistagroupBox1 = new GroupBox();
            OPaDespachar_groupBox2 = new GroupBox();
            EmitirRemito_button = new Button();
            Datos_TrasnportistagroupBox1.SuspendLayout();
            OPaDespachar_groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listView_OrdenesDeEntrega
            // 
            listView_OrdenesDeEntrega.Columns.AddRange(new ColumnHeader[] { ID_OP });
            listView_OrdenesDeEntrega.Location = new Point(6, 22);
            listView_OrdenesDeEntrega.Name = "listView_OrdenesDeEntrega";
            listView_OrdenesDeEntrega.Size = new Size(537, 391);
            listView_OrdenesDeEntrega.TabIndex = 0;
            listView_OrdenesDeEntrega.UseCompatibleStateImageBehavior = false;
            listView_OrdenesDeEntrega.View = View.Details;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // IdOrdenDeEntrega_label
            // 
            IdOrdenDeEntrega_label.AutoSize = true;
            IdOrdenDeEntrega_label.Location = new Point(9, 28);
            IdOrdenDeEntrega_label.Name = "IdOrdenDeEntrega_label";
            IdOrdenDeEntrega_label.Size = new Size(97, 15);
            IdOrdenDeEntrega_label.TabIndex = 2;
            IdOrdenDeEntrega_label.Text = "DNI Transportista";
            // 
            // DniTransportista_textBox
            // 
            DniTransportista_textBox.Location = new Point(9, 46);
            DniTransportista_textBox.Name = "DniTransportista_textBox";
            DniTransportista_textBox.Size = new Size(231, 23);
            DniTransportista_textBox.TabIndex = 3;
            // 
            // BuscarDNI_button
            // 
            BuscarDNI_button.DialogResult = DialogResult.Retry;
            BuscarDNI_button.Font = new Font("Segoe UI", 9F);
            BuscarDNI_button.Location = new Point(65, 75);
            BuscarDNI_button.Name = "BuscarDNI_button";
            BuscarDNI_button.Size = new Size(75, 23);
            BuscarDNI_button.TabIndex = 4;
            BuscarDNI_button.Text = "Buscar";
            BuscarDNI_button.UseVisualStyleBackColor = true;
            BuscarDNI_button.Click += ProcesarOrdenDeEntrega_button_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(139, 75);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(101, 23);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // Datos_TrasnportistagroupBox1
            // 
            Datos_TrasnportistagroupBox1.Controls.Add(VolverAlMenu_button);
            Datos_TrasnportistagroupBox1.Controls.Add(BuscarDNI_button);
            Datos_TrasnportistagroupBox1.Controls.Add(DniTransportista_textBox);
            Datos_TrasnportistagroupBox1.Controls.Add(IdOrdenDeEntrega_label);
            Datos_TrasnportistagroupBox1.Location = new Point(22, 33);
            Datos_TrasnportistagroupBox1.Name = "Datos_TrasnportistagroupBox1";
            Datos_TrasnportistagroupBox1.Size = new Size(261, 115);
            Datos_TrasnportistagroupBox1.TabIndex = 6;
            Datos_TrasnportistagroupBox1.TabStop = false;
            Datos_TrasnportistagroupBox1.Text = "Datos Transportista";
            // 
            // OPaDespachar_groupBox2
            // 
            OPaDespachar_groupBox2.Controls.Add(EmitirRemito_button);
            OPaDespachar_groupBox2.Controls.Add(listView_OrdenesDeEntrega);
            OPaDespachar_groupBox2.Location = new Point(318, 33);
            OPaDespachar_groupBox2.Name = "OPaDespachar_groupBox2";
            OPaDespachar_groupBox2.Size = new Size(552, 448);
            OPaDespachar_groupBox2.TabIndex = 0;
            OPaDespachar_groupBox2.TabStop = false;
            OPaDespachar_groupBox2.Text = "Ordenes de Preparacion a Despachar";
            // 
            // EmitirRemito_button
            // 
            EmitirRemito_button.Location = new Point(398, 419);
            EmitirRemito_button.Name = "EmitirRemito_button";
            EmitirRemito_button.Size = new Size(145, 23);
            EmitirRemito_button.TabIndex = 1;
            EmitirRemito_button.Text = "Emitir Remito";
            EmitirRemito_button.UseVisualStyleBackColor = true;
            EmitirRemito_button.Click += EmitirRemito_button_Click;
            // 
            // DespacharMercaderias_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 493);
            Controls.Add(OPaDespachar_groupBox2);
            Controls.Add(Datos_TrasnportistagroupBox1);
            Name = "DespacharMercaderias_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Despachar Mercaderias";
            Datos_TrasnportistagroupBox1.ResumeLayout(false);
            Datos_TrasnportistagroupBox1.PerformLayout();
            OPaDespachar_groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView_OrdenesDeEntrega;
        private Label OrdenesDeEntrega_label;
        private ColumnHeader Estado_OP;
        private ColumnHeader Fecha_Entrega_OP;
        private ColumnHeader ID_OP;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader DNI_Transportista;
        private Label IdOrdenDeEntrega_label;
        private TextBox DniTransportista_textBox;
        private Button BuscarDNI_button;
        private Button VolverAlMenu_button;
        private GroupBox Datos_TrasnportistagroupBox1;
        private GroupBox OPaDespachar_groupBox2;
        private Button EmitirRemito_button;
    }
}