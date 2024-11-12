

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    partial class CrearOrdenDePreparacion_form
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
        /// 

        private void InitializeComponent()
        {
            IdCliente_textbox = new TextBox();
            Cantidad_textbox = new TextBox();
            Dni_textbox = new TextBox();
            DescripcionMercaderia_ComboBox = new ComboBox();
            DescripcionDeposito_Combobox = new ComboBox();
            CrearOP_button = new Button();
            DatosTransportistas_groupbox = new GroupBox();
            dateTimePicker_fecha = new DateTimePicker();
            FechaEntrega_label = new Label();
            label5 = new Label();
            DatosGenerales_groupBox = new GroupBox();
            Deposito_label = new Label();
            IdCliente_label = new Label();
            DatosMercaderias_groupBox = new GroupBox();
            button_agregar = new Button();
            Cantidad_label = new Label();
            Descripcion_label = new Label();
            VolverAlMenu_button = new Button();
            listView_MercaderiasOrdenes = new ListView();
            MercaderiaEnt = new ColumnHeader();
            Cantidad = new ColumnHeader();
            groupBox1 = new GroupBox();
            button2 = new Button();
            Item = new ColumnHeader();
            DatosTransportistas_groupbox.SuspendLayout();
            DatosGenerales_groupBox.SuspendLayout();
            DatosMercaderias_groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // IdCliente_textbox
            // 
            IdCliente_textbox.Location = new Point(27, 65);
            IdCliente_textbox.Margin = new Padding(4, 5, 4, 5);
            IdCliente_textbox.Name = "IdCliente_textbox";
            IdCliente_textbox.Size = new Size(171, 31);
            IdCliente_textbox.TabIndex = 0;
            IdCliente_textbox.TextChanged += IdCliente_textbox_TextChanged;
            // 
            // Cantidad_textbox
            // 
            Cantidad_textbox.Enabled = false;
            Cantidad_textbox.Location = new Point(13, 188);
            Cantidad_textbox.Margin = new Padding(4, 5, 4, 5);
            Cantidad_textbox.Name = "Cantidad_textbox";
            Cantidad_textbox.Size = new Size(264, 31);
            Cantidad_textbox.TabIndex = 1;
            // 
            // Dni_textbox
            // 
            Dni_textbox.Location = new Point(9, 62);
            Dni_textbox.Margin = new Padding(4, 5, 4, 5);
            Dni_textbox.Name = "Dni_textbox";
            Dni_textbox.Size = new Size(338, 31);
            Dni_textbox.TabIndex = 3;
            Dni_textbox.TextChanged += Dni_textbox_TextChanged;
            // 
            // DescripcionMercaderia_ComboBox
            // 
            DescripcionMercaderia_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionMercaderia_ComboBox.FormattingEnabled = true;
            DescripcionMercaderia_ComboBox.Location = new Point(13, 92);
            DescripcionMercaderia_ComboBox.Margin = new Padding(4, 5, 4, 5);
            DescripcionMercaderia_ComboBox.Name = "DescripcionMercaderia_ComboBox";
            DescripcionMercaderia_ComboBox.Size = new Size(264, 33);
            DescripcionMercaderia_ComboBox.TabIndex = 4;
            // 
            // DescripcionDeposito_Combobox
            // 
            DescripcionDeposito_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionDeposito_Combobox.Enabled = false;
            DescripcionDeposito_Combobox.FormattingEnabled = true;
            DescripcionDeposito_Combobox.Location = new Point(27, 160);
            DescripcionDeposito_Combobox.Margin = new Padding(4, 5, 4, 5);
            DescripcionDeposito_Combobox.Name = "DescripcionDeposito_Combobox";
            DescripcionDeposito_Combobox.Size = new Size(171, 33);
            DescripcionDeposito_Combobox.TabIndex = 5;
            DescripcionDeposito_Combobox.SelectedIndexChanged += DescripcionDeposito_Combobox_SelectedIndexChanged;
            // 
            // CrearOP_button
            // 
            CrearOP_button.Location = new Point(791, 820);
            CrearOP_button.Margin = new Padding(4, 5, 4, 5);
            CrearOP_button.Name = "CrearOP_button";
            CrearOP_button.Size = new Size(107, 38);
            CrearOP_button.TabIndex = 6;
            CrearOP_button.Text = "Crear OP";
            CrearOP_button.UseVisualStyleBackColor = true;
            CrearOP_button.Click += button_aceptar_click;
            // 
            // DatosTransportistas_groupbox
            // 
            DatosTransportistas_groupbox.Controls.Add(dateTimePicker_fecha);
            DatosTransportistas_groupbox.Controls.Add(FechaEntrega_label);
            DatosTransportistas_groupbox.Controls.Add(label5);
            DatosTransportistas_groupbox.Controls.Add(Dni_textbox);
            DatosTransportistas_groupbox.Location = new Point(426, 38);
            DatosTransportistas_groupbox.Margin = new Padding(4, 5, 4, 5);
            DatosTransportistas_groupbox.Name = "DatosTransportistas_groupbox";
            DatosTransportistas_groupbox.Padding = new Padding(4, 5, 4, 5);
            DatosTransportistas_groupbox.Size = new Size(637, 253);
            DatosTransportistas_groupbox.TabIndex = 8;
            DatosTransportistas_groupbox.TabStop = false;
            DatosTransportistas_groupbox.Text = "Datos Transportistas";
            // 
            // dateTimePicker_fecha
            // 
            dateTimePicker_fecha.Location = new Point(9, 160);
            dateTimePicker_fecha.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            dateTimePicker_fecha.Size = new Size(408, 31);
            dateTimePicker_fecha.TabIndex = 6;
            // 
            // FechaEntrega_label
            // 
            FechaEntrega_label.AutoSize = true;
            FechaEntrega_label.Location = new Point(9, 130);
            FechaEntrega_label.Margin = new Padding(4, 0, 4, 0);
            FechaEntrega_label.Name = "FechaEntrega_label";
            FechaEntrega_label.Size = new Size(300, 25);
            FechaEntrega_label.TabIndex = 5;
            FechaEntrega_label.Text = "Fecha Entrega Orden de Preparacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 32);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 4;
            label5.Text = "DNI Transportista";
            // 
            // DatosGenerales_groupBox
            // 
            DatosGenerales_groupBox.Controls.Add(Deposito_label);
            DatosGenerales_groupBox.Controls.Add(IdCliente_label);
            DatosGenerales_groupBox.Controls.Add(DescripcionDeposito_Combobox);
            DatosGenerales_groupBox.Controls.Add(IdCliente_textbox);
            DatosGenerales_groupBox.Location = new Point(69, 38);
            DatosGenerales_groupBox.Margin = new Padding(4, 5, 4, 5);
            DatosGenerales_groupBox.Name = "DatosGenerales_groupBox";
            DatosGenerales_groupBox.Padding = new Padding(4, 5, 4, 5);
            DatosGenerales_groupBox.Size = new Size(323, 253);
            DatosGenerales_groupBox.TabIndex = 10;
            DatosGenerales_groupBox.TabStop = false;
            DatosGenerales_groupBox.Text = "Datos Generales";
            // 
            // Deposito_label
            // 
            Deposito_label.AutoSize = true;
            Deposito_label.Location = new Point(27, 130);
            Deposito_label.Margin = new Padding(4, 0, 4, 0);
            Deposito_label.Name = "Deposito_label";
            Deposito_label.Size = new Size(182, 25);
            Deposito_label.TabIndex = 11;
            Deposito_label.Text = "Descripción Depósito";
            // 
            // IdCliente_label
            // 
            IdCliente_label.AutoSize = true;
            IdCliente_label.Location = new Point(27, 32);
            IdCliente_label.Margin = new Padding(4, 0, 4, 0);
            IdCliente_label.Name = "IdCliente_label";
            IdCliente_label.Size = new Size(88, 25);
            IdCliente_label.TabIndex = 10;
            IdCliente_label.Text = "ID Cliente";
            // 
            // DatosMercaderias_groupBox
            // 
            DatosMercaderias_groupBox.Controls.Add(button_agregar);
            DatosMercaderias_groupBox.Controls.Add(Cantidad_label);
            DatosMercaderias_groupBox.Controls.Add(Descripcion_label);
            DatosMercaderias_groupBox.Controls.Add(DescripcionMercaderia_ComboBox);
            DatosMercaderias_groupBox.Controls.Add(Cantidad_textbox);
            DatosMercaderias_groupBox.Location = new Point(69, 327);
            DatosMercaderias_groupBox.Margin = new Padding(4, 5, 4, 5);
            DatosMercaderias_groupBox.Name = "DatosMercaderias_groupBox";
            DatosMercaderias_groupBox.Padding = new Padding(4, 5, 4, 5);
            DatosMercaderias_groupBox.Size = new Size(323, 483);
            DatosMercaderias_groupBox.TabIndex = 11;
            DatosMercaderias_groupBox.TabStop = false;
            DatosMercaderias_groupBox.Text = "Datos Mercaderias";
            // 
            // button_agregar
            // 
            button_agregar.Location = new Point(171, 253);
            button_agregar.Margin = new Padding(4, 5, 4, 5);
            button_agregar.Name = "button_agregar";
            button_agregar.Size = new Size(107, 38);
            button_agregar.TabIndex = 13;
            button_agregar.Text = "Agregar ";
            button_agregar.UseVisualStyleBackColor = true;
            button_agregar.Click += button_agregar_Click;
            // 
            // Cantidad_label
            // 
            Cantidad_label.AutoSize = true;
            Cantidad_label.Location = new Point(13, 158);
            Cantidad_label.Margin = new Padding(4, 0, 4, 0);
            Cantidad_label.Name = "Cantidad_label";
            Cantidad_label.Size = new Size(175, 25);
            Cantidad_label.TabIndex = 6;
            Cantidad_label.Text = "Cantidad Mercaderia";
            // 
            // Descripcion_label
            // 
            Descripcion_label.AutoSize = true;
            Descripcion_label.Location = new Point(13, 62);
            Descripcion_label.Margin = new Padding(4, 0, 4, 0);
            Descripcion_label.Name = "Descripcion_label";
            Descripcion_label.Size = new Size(196, 25);
            Descripcion_label.TabIndex = 5;
            Descripcion_label.Text = "Descripción Mercaderia";
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(917, 820);
            VolverAlMenu_button.Margin = new Padding(4, 5, 4, 5);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(146, 38);
            VolverAlMenu_button.TabIndex = 12;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // listView_MercaderiasOrdenes
            // 
            listView_MercaderiasOrdenes.CheckBoxes = true;
            listView_MercaderiasOrdenes.Columns.AddRange(new ColumnHeader[] { MercaderiaEnt, Cantidad });
            listView_MercaderiasOrdenes.Location = new Point(9, 37);
            listView_MercaderiasOrdenes.Margin = new Padding(4, 5, 4, 5);
            listView_MercaderiasOrdenes.Name = "listView_MercaderiasOrdenes";
            listView_MercaderiasOrdenes.Size = new Size(583, 417);
            listView_MercaderiasOrdenes.TabIndex = 13;
            listView_MercaderiasOrdenes.UseCompatibleStateImageBehavior = false;
            listView_MercaderiasOrdenes.View = View.Details;
            // 
            // MercaderiaEnt
            // 
            MercaderiaEnt.Text = "MercaderiaEnt";
            MercaderiaEnt.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView_MercaderiasOrdenes);
            groupBox1.Location = new Point(426, 328);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(637, 482);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items Orden de Preparacion";
            // 
            // button2
            // 
            button2.Location = new Point(650, 820);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 15;
            button2.Text = "Borrar Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_borrarItem_Click;
            // 
            // Item
            // 
            Item.Text = "Item";
            // 
            // CrearOrdenDePreparacion_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 902);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(DatosMercaderias_groupBox);
            Controls.Add(DatosGenerales_groupBox);
            Controls.Add(DatosTransportistas_groupbox);
            Controls.Add(CrearOP_button);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CrearOrdenDePreparacion_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar Orden de Preparacion";
            DatosTransportistas_groupbox.ResumeLayout(false);
            DatosTransportistas_groupbox.PerformLayout();
            DatosGenerales_groupBox.ResumeLayout(false);
            DatosGenerales_groupBox.PerformLayout();
            DatosMercaderias_groupBox.ResumeLayout(false);
            DatosMercaderias_groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private TextBox IdCliente_textbox;
        private TextBox Cantidad_textbox;
        private TextBox Dni_textbox;
        private ComboBox DescripcionMercaderia_ComboBox;
        private ComboBox DescripcionDeposito_Combobox;
        private Button CrearOP_button;
        private GroupBox DatosTransportistas_groupbox;
        private GroupBox DatosGenerales_groupBox;
        private GroupBox DatosMercaderias_groupBox;
        private Label FechaEntrega_label;
        private Label label5;
        private Label Deposito_label;
        private Label IdCliente_label;
        private Label Cantidad_label;
        private Label Descripcion_label;
        private Button VolverAlMenu_button;
        private Button button_agregar;
        private ListView listView_MercaderiasOrdenes;
        private GroupBox groupBox1;
        private ColumnHeader MercaderiaEnt;
        private ColumnHeader Cantidad;
        private Button button2;
        private ColumnHeader Item;
        private DateTimePicker dateTimePicker_fecha;
    }
}