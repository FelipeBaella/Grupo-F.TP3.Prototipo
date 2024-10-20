using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    partial class ProcesarOrdenDeSeleccion_form
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
            ProcesarOrdenesDeSeleccion_listView = new ListView();
            Coordenadas_Item_OP = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            ProcesarOrdenDeSeleccion_button = new Button();
            VolverAlMenu_button = new Button();
            OS_groupBox1 = new GroupBox();
            label1 = new Label();
            OS_Pendientes_comboBox = new ComboBox();
            OS_groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ProcesarOrdenesDeSeleccion_listView
            // 
            ProcesarOrdenesDeSeleccion_listView.Columns.AddRange(new ColumnHeader[] { Coordenadas_Item_OP, Descripcion_Mercaderia, Cantidad });
            ProcesarOrdenesDeSeleccion_listView.Location = new Point(0, 24);
            ProcesarOrdenesDeSeleccion_listView.Name = "ProcesarOrdenesDeSeleccion_listView";
            ProcesarOrdenesDeSeleccion_listView.Size = new Size(697, 362);
            ProcesarOrdenesDeSeleccion_listView.TabIndex = 1;
            ProcesarOrdenesDeSeleccion_listView.UseCompatibleStateImageBehavior = false;
            ProcesarOrdenesDeSeleccion_listView.View = View.Details;
            // 
            // Coordenadas_Item_OP
            // 
            Coordenadas_Item_OP.Text = "Coordenadas Item OP";
            Coordenadas_Item_OP.Width = 120;
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 160;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 70;
            // 
            // ProcesarOrdenDeSeleccion_button
            // 
            ProcesarOrdenDeSeleccion_button.Location = new Point(366, 426);
            ProcesarOrdenDeSeleccion_button.Name = "ProcesarOrdenDeSeleccion_button";
            ProcesarOrdenDeSeleccion_button.Size = new Size(197, 33);
            ProcesarOrdenDeSeleccion_button.TabIndex = 2;
            ProcesarOrdenDeSeleccion_button.Text = "Procesar Orden de Seleccion";
            ProcesarOrdenDeSeleccion_button.UseVisualStyleBackColor = true;
            ProcesarOrdenDeSeleccion_button.Click += button_ProcesarOrdenDeSeleccion_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(573, 426);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(124, 33);
            VolverAlMenu_button.TabIndex = 15;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // OS_groupBox1
            // 
            OS_groupBox1.Controls.Add(label1);
            OS_groupBox1.Controls.Add(OS_Pendientes_comboBox);
            OS_groupBox1.Controls.Add(ProcesarOrdenesDeSeleccion_listView);
            OS_groupBox1.Controls.Add(VolverAlMenu_button);
            OS_groupBox1.Controls.Add(ProcesarOrdenDeSeleccion_button);
            OS_groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OS_groupBox1.Location = new Point(12, 21);
            OS_groupBox1.Name = "OS_groupBox1";
            OS_groupBox1.Size = new Size(707, 465);
            OS_groupBox1.TabIndex = 18;
            OS_groupBox1.TabStop = false;
            OS_groupBox1.Text = "Ordenes de Seleccion a Procesar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 400);
            label1.Name = "label1";
            label1.Size = new Size(202, 17);
            label1.TabIndex = 19;
            label1.Text = "Ordenes de Seleccion Pendientes";
            // 
            // OS_Pendientes_comboBox
            // 
            OS_Pendientes_comboBox.FormattingEnabled = true;
            OS_Pendientes_comboBox.Location = new Point(6, 431);
            OS_Pendientes_comboBox.Name = "OS_Pendientes_comboBox";
            OS_Pendientes_comboBox.Size = new Size(337, 25);
            OS_Pendientes_comboBox.TabIndex = 19;
            OS_Pendientes_comboBox.SelectedIndexChanged += OS_Pendientes_comboBox1_SelectedIndexChanged;
            // 
            // ProcesarOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 513);
            Controls.Add(OS_groupBox1);
            Name = "ProcesarOrdenDeSeleccion_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesar Orden de Seleccion";
            OS_groupBox1.ResumeLayout(false);
            OS_groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView ProcesarOrdenesDeSeleccion_listView;
        private ColumnHeader Estado_OS;
        private ColumnHeader ID_OS;
        private ColumnHeader ID_OP;
        private ColumnHeader Item_OP;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader Coordenadas_Item_OP;
        private ColumnHeader Deposito;
        private Button ProcesarOrdenDeSeleccion_button;
        private Button VolverAlMenu_button;
        private GroupBox OS_groupBox1;
        private Label label1;
        private ComboBox OS_Pendientes_comboBox;
    }
}