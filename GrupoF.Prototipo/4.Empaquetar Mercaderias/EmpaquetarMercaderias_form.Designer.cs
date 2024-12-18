﻿using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    partial class EmpaquetarMercaderias_form
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
            CrearOrdenDeEntrega_label = new Label();
            OrdenesDePreparacion_listView = new ListView();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Lista_button = new Button();
            VolverAlMenu_button = new Button();
            OPaEmpaquetar_groupBox1 = new GroupBox();
            OPaEmpaquetar_groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CrearOrdenDeEntrega_label
            // 
            CrearOrdenDeEntrega_label.AutoSize = true;
            CrearOrdenDeEntrega_label.Location = new Point(13, 9);
            CrearOrdenDeEntrega_label.Margin = new Padding(4, 0, 4, 0);
            CrearOrdenDeEntrega_label.Name = "CrearOrdenDeEntrega_label";
            CrearOrdenDeEntrega_label.Size = new Size(179, 21);
            CrearOrdenDeEntrega_label.TabIndex = 0;
            CrearOrdenDeEntrega_label.Text = "Ordenes De Preparacion";
            // 
            // OrdenesDePreparacion_listView
            // 
            OrdenesDePreparacion_listView.Columns.AddRange(new ColumnHeader[] { Descripcion_Mercaderia, Cantidad });
            OrdenesDePreparacion_listView.Font = new Font("Segoe UI", 9F);
            OrdenesDePreparacion_listView.Location = new Point(6, 28);
            OrdenesDePreparacion_listView.Name = "OrdenesDePreparacion_listView";
            OrdenesDePreparacion_listView.Size = new Size(564, 375);
            OrdenesDePreparacion_listView.TabIndex = 1;
            OrdenesDePreparacion_listView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_listView.View = View.Details;
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Lista_button
            // 
            Lista_button.Font = new Font("Segoe UI", 9F);
            Lista_button.Location = new Point(326, 409);
            Lista_button.Name = "Lista_button";
            Lista_button.Size = new Size(126, 36);
            Lista_button.TabIndex = 2;
            Lista_button.Text = "Lista";
            Lista_button.UseVisualStyleBackColor = true;
            Lista_button.Click += button_empaquetar_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Font = new Font("Segoe UI", 9F);
            VolverAlMenu_button.Location = new Point(458, 409);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(112, 36);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // OPaEmpaquetar_groupBox1
            // 
            OPaEmpaquetar_groupBox1.Controls.Add(OrdenesDePreparacion_listView);
            OPaEmpaquetar_groupBox1.Controls.Add(VolverAlMenu_button);
            OPaEmpaquetar_groupBox1.Controls.Add(Lista_button);
            OPaEmpaquetar_groupBox1.Location = new Point(0, 0);
            OPaEmpaquetar_groupBox1.Name = "OPaEmpaquetar_groupBox1";
            OPaEmpaquetar_groupBox1.Size = new Size(592, 454);
            OPaEmpaquetar_groupBox1.TabIndex = 6;
            OPaEmpaquetar_groupBox1.TabStop = false;
            OPaEmpaquetar_groupBox1.Text = "Ordenes de Preparacion a Empaquetar";
            // 
            // EmpaquetarMercaderias_form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 484);
            Controls.Add(OPaEmpaquetar_groupBox1);
            Controls.Add(CrearOrdenDeEntrega_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "EmpaquetarMercaderias_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empaquetar Mercaderias";
            OPaEmpaquetar_groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CrearOrdenDeEntrega_label;
        private ListView OrdenesDePreparacion_listView;
        private Button Lista_button;
        private ColumnHeader Estado_OP;
        private ColumnHeader ID_OP;
        private ColumnHeader ITEM_OP;
        private ColumnHeader DepositoEnt;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private TextBox OrdenDePreparacion_textbox;
        private Button VolverAlMenu_button;
        private GroupBox OPaEmpaquetar_groupBox1;
    }
}