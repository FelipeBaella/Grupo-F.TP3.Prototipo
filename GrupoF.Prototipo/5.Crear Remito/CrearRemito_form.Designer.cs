using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._5.Crear_Remito
{
    partial class CrearRemito_form
    {
        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in Datos_model.OrdenesDePreparacion)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == orden.Id_Mercaderia).FirstOrDefault();
                var depositos = Datos_model.Depositos.Where(x => x.Id_Deposito == orden.Id_Deposito).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    orden.Id_Estado.ToString(),
                    orden.Id_OrdenDePreparacion.ToString(),
                    orden.Prioridad_OrdenDePreparacion.ToString(),
                    orden.Emision_OrdenDePreparacion.ToString(),

                    mercaderia.Descripcion_Mercaderia,
                    orden.Cantidad_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,

                }, -1);

                //OrdenesDePreparacion_listView.Items.Add(listViewItem);
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
        private void InitializeComponent()
        {
            NombreApellido_textBox = new TextBox();
            IngresarIDOP_textBox = new TextBox();
            DNI_textBox = new TextBox();
            OrdenDePreparacion_groupBox = new GroupBox();
            Ingresar_button = new Button();
            ID_OP_label = new Label();
            groupBox2 = new GroupBox();
            Nombre_Apellido_label = new Label();
            DNI_label = new Label();
            NombreCliente_textBox = new TextBox();
            DescripcionMercaderia_textBox = new TextBox();
            groupBox3 = new GroupBox();
            Domicilio_label = new Label();
            CondicionFrenteAlIva_label = new Label();
            Domicilio_textBox = new TextBox();
            CondicionFrenteAlIva_textbox = new TextBox();
            Cantidad_textBox = new TextBox();
            Cantidad_label = new Label();
            CUIT_textBox = new TextBox();
            CUIT_label = new Label();
            DescripcionMercaderia_label = new Label();
            NombreCliente_label = new Label();
            Emitir_button = new Button();
            VolverAlMenu_button = new Button();
            Remito_groupBox = new GroupBox();
            OrdenDePreparacion_groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            Remito_groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NombreApellido_textBox
            // 
            NombreApellido_textBox.Location = new Point(227, 42);
            NombreApellido_textBox.Name = "NombreApellido_textBox";
            NombreApellido_textBox.ReadOnly = true;
            NombreApellido_textBox.Size = new Size(94, 23);
            NombreApellido_textBox.TabIndex = 0;
            // 
            // IngresarIDOP_textBox
            // 
            IngresarIDOP_textBox.Location = new Point(7, 42);
            IngresarIDOP_textBox.Name = "IngresarIDOP_textBox";
            IngresarIDOP_textBox.Size = new Size(110, 23);
            IngresarIDOP_textBox.TabIndex = 1;
            // 
            // DNI_textBox
            // 
            DNI_textBox.Location = new Point(19, 42);
            DNI_textBox.Name = "DNI_textBox";
            DNI_textBox.ReadOnly = true;
            DNI_textBox.Size = new Size(169, 23);
            DNI_textBox.TabIndex = 2;
            // 
            // OrdenDePreparacion_groupBox
            // 
            OrdenDePreparacion_groupBox.Controls.Add(Ingresar_button);
            OrdenDePreparacion_groupBox.Controls.Add(ID_OP_label);
            OrdenDePreparacion_groupBox.Controls.Add(IngresarIDOP_textBox);
            OrdenDePreparacion_groupBox.Location = new Point(27, 29);
            OrdenDePreparacion_groupBox.Name = "OrdenDePreparacion_groupBox";
            OrdenDePreparacion_groupBox.Size = new Size(460, 100);
            OrdenDePreparacion_groupBox.TabIndex = 4;
            OrdenDePreparacion_groupBox.TabStop = false;
            OrdenDePreparacion_groupBox.Text = "Orden De Preparacion";
            // 
            // Ingresar_button
            // 
            Ingresar_button.Location = new Point(7, 71);
            Ingresar_button.Name = "Ingresar_button";
            Ingresar_button.Size = new Size(85, 23);
            Ingresar_button.TabIndex = 5;
            Ingresar_button.Text = "Ingresar";
            Ingresar_button.UseVisualStyleBackColor = true;
            Ingresar_button.Click += Ingresar_button_Click;
            // 
            // ID_OP_label
            // 
            ID_OP_label.AutoSize = true;
            ID_OP_label.Location = new Point(7, 24);
            ID_OP_label.Name = "ID_OP_label";
            ID_OP_label.Size = new Size(37, 15);
            ID_OP_label.TabIndex = 4;
            ID_OP_label.Text = "ID OP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Nombre_Apellido_label);
            groupBox2.Controls.Add(DNI_label);
            groupBox2.Controls.Add(DNI_textBox);
            groupBox2.Controls.Add(NombreApellido_textBox);
            groupBox2.Location = new Point(27, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de Transportista";
            // 
            // Nombre_Apellido_label
            // 
            Nombre_Apellido_label.AutoSize = true;
            Nombre_Apellido_label.Location = new Point(227, 24);
            Nombre_Apellido_label.Name = "Nombre_Apellido_label";
            Nombre_Apellido_label.Size = new Size(98, 15);
            Nombre_Apellido_label.TabIndex = 4;
            Nombre_Apellido_label.Text = "Nombre Apellido";
            // 
            // DNI_label
            // 
            DNI_label.AutoSize = true;
            DNI_label.Location = new Point(19, 24);
            DNI_label.Name = "DNI_label";
            DNI_label.Size = new Size(27, 15);
            DNI_label.TabIndex = 3;
            DNI_label.Text = "DNI";
            // 
            // NombreCliente_textBox
            // 
            NombreCliente_textBox.Location = new Point(6, 38);
            NombreCliente_textBox.Name = "NombreCliente_textBox";
            NombreCliente_textBox.ReadOnly = true;
            NombreCliente_textBox.Size = new Size(111, 23);
            NombreCliente_textBox.TabIndex = 5;
            // 
            // DescripcionMercaderia_textBox
            // 
            DescripcionMercaderia_textBox.Location = new Point(138, 38);
            DescripcionMercaderia_textBox.Name = "DescripcionMercaderia_textBox";
            DescripcionMercaderia_textBox.ReadOnly = true;
            DescripcionMercaderia_textBox.Size = new Size(164, 23);
            DescripcionMercaderia_textBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Domicilio_label);
            groupBox3.Controls.Add(CondicionFrenteAlIva_label);
            groupBox3.Controls.Add(Domicilio_textBox);
            groupBox3.Controls.Add(CondicionFrenteAlIva_textbox);
            groupBox3.Controls.Add(Cantidad_textBox);
            groupBox3.Controls.Add(Cantidad_label);
            groupBox3.Controls.Add(CUIT_textBox);
            groupBox3.Controls.Add(CUIT_label);
            groupBox3.Controls.Add(DescripcionMercaderia_label);
            groupBox3.Controls.Add(NombreCliente_label);
            groupBox3.Controls.Add(NombreCliente_textBox);
            groupBox3.Controls.Add(DescripcionMercaderia_textBox);
            groupBox3.Location = new Point(27, 148);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 137);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Cliente";
            // 
            // Domicilio_label
            // 
            Domicilio_label.AutoSize = true;
            Domicilio_label.Location = new Point(327, 82);
            Domicilio_label.Name = "Domicilio_label";
            Domicilio_label.Size = new Size(58, 15);
            Domicilio_label.TabIndex = 16;
            Domicilio_label.Text = "Domicilio";
            // 
            // CondicionFrenteAlIva_label
            // 
            CondicionFrenteAlIva_label.AutoSize = true;
            CondicionFrenteAlIva_label.Location = new Point(323, 19);
            CondicionFrenteAlIva_label.Name = "CondicionFrenteAlIva_label";
            CondicionFrenteAlIva_label.Size = new Size(132, 15);
            CondicionFrenteAlIva_label.TabIndex = 15;
            CondicionFrenteAlIva_label.Text = "Condicion Frente Al IVA";
            // 
            // Domicilio_textBox
            // 
            Domicilio_textBox.Location = new Point(327, 100);
            Domicilio_textBox.Name = "Domicilio_textBox";
            Domicilio_textBox.ReadOnly = true;
            Domicilio_textBox.Size = new Size(127, 23);
            Domicilio_textBox.TabIndex = 14;
            // 
            // CondicionFrenteAlIva_textbox
            // 
            CondicionFrenteAlIva_textbox.Location = new Point(327, 38);
            CondicionFrenteAlIva_textbox.Name = "CondicionFrenteAlIva_textbox";
            CondicionFrenteAlIva_textbox.ReadOnly = true;
            CondicionFrenteAlIva_textbox.Size = new Size(127, 23);
            CondicionFrenteAlIva_textbox.TabIndex = 13;
            // 
            // Cantidad_textBox
            // 
            Cantidad_textBox.Location = new Point(138, 100);
            Cantidad_textBox.Name = "Cantidad_textBox";
            Cantidad_textBox.ReadOnly = true;
            Cantidad_textBox.Size = new Size(164, 23);
            Cantidad_textBox.TabIndex = 12;
            // 
            // Cantidad_label
            // 
            Cantidad_label.AutoSize = true;
            Cantidad_label.Location = new Point(138, 82);
            Cantidad_label.Name = "Cantidad_label";
            Cantidad_label.Size = new Size(55, 15);
            Cantidad_label.TabIndex = 11;
            Cantidad_label.Text = "Cantidad";
            // 
            // CUIT_textBox
            // 
            CUIT_textBox.Location = new Point(7, 100);
            CUIT_textBox.Name = "CUIT_textBox";
            CUIT_textBox.ReadOnly = true;
            CUIT_textBox.Size = new Size(111, 23);
            CUIT_textBox.TabIndex = 10;
            // 
            // CUIT_label
            // 
            CUIT_label.AutoSize = true;
            CUIT_label.Location = new Point(7, 82);
            CUIT_label.Name = "CUIT_label";
            CUIT_label.Size = new Size(32, 15);
            CUIT_label.TabIndex = 9;
            CUIT_label.Text = "CUIT";
            // 
            // DescripcionMercaderia_label
            // 
            DescripcionMercaderia_label.AutoSize = true;
            DescripcionMercaderia_label.Location = new Point(138, 19);
            DescripcionMercaderia_label.Name = "DescripcionMercaderia_label";
            DescripcionMercaderia_label.Size = new Size(131, 15);
            DescripcionMercaderia_label.TabIndex = 8;
            DescripcionMercaderia_label.Text = "Descripcion Mercaderia";
            // 
            // NombreCliente_label
            // 
            NombreCliente_label.AutoSize = true;
            NombreCliente_label.Location = new Point(7, 19);
            NombreCliente_label.Name = "NombreCliente_label";
            NombreCliente_label.Size = new Size(91, 15);
            NombreCliente_label.TabIndex = 7;
            NombreCliente_label.Text = "Nombre Cliente";
            // 
            // Emitir_button
            // 
            Emitir_button.Location = new Point(7, 22);
            Emitir_button.Name = "Emitir_button";
            Emitir_button.Size = new Size(97, 23);
            Emitir_button.TabIndex = 8;
            Emitir_button.Text = "Emitir";
            Emitir_button.UseVisualStyleBackColor = true;
            Emitir_button.Click += button_Emitir_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(165, 439);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(114, 23);
            VolverAlMenu_button.TabIndex = 14;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // Remito_groupBox
            // 
            Remito_groupBox.Controls.Add(Emitir_button);
            Remito_groupBox.Location = new Point(27, 417);
            Remito_groupBox.Name = "Remito_groupBox";
            Remito_groupBox.Size = new Size(117, 56);
            Remito_groupBox.TabIndex = 5;
            Remito_groupBox.TabStop = false;
            Remito_groupBox.Text = "Remito";
            // 
            // CrearRemito_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 555);
            Controls.Add(Remito_groupBox);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(OrdenDePreparacion_groupBox);
            Name = "CrearRemito_form";
            Text = "Crear Remito";
            OrdenDePreparacion_groupBox.ResumeLayout(false);
            OrdenDePreparacion_groupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            Remito_groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox NombreApellido_textBox;
        private TextBox IngresarIDOP_textBox;
        private TextBox DNI_textBox;
        private GroupBox OrdenDePreparacion_groupBox;
        private GroupBox groupBox2;
        private Button Ingresar_button;
        private Label ID_OP_label;
        private Label Nombre_Apellido_label;
        private Label DNI_label;
        private TextBox NombreCliente_textBox;
        private TextBox DescripcionMercaderia_textBox;
        private GroupBox groupBox3;
        private Label DescripcionMercaderia_label;
        private Label NombreCliente_label;
        private Button Emitir_button;
        private Button VolverAlMenu_button;
        private TextBox Cantidad_textBox;
        private Label Cantidad_label;
        private TextBox CUIT_textBox;
        private Label CUIT_label;
        private Label Domicilio_label;
        private Label CondicionFrenteAlIva_label;
        private TextBox Domicilio_textBox;
        private TextBox CondicionFrenteAlIva_textbox;
        private GroupBox Remito_groupBox;
    }
}