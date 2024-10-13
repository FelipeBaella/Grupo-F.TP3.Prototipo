using GrupoF.Prototipo.Base_de_Datos;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    partial class CrearOrdenDePreparacion_form
    {
        private void CargarDepositos()
        {
            // Limpiamos el ComboBox por si ya tiene elementos cargados
            DescripcionDeposito_Combobox.Items.Clear();

            // Iteramos sobre la lista de depósitos y agregamos los nombres al ComboBox
            foreach (var deposito in Datos_model.Depositos)
            {
                DescripcionDeposito_Combobox.Items.Add(deposito.Nombre_Deposito);
            }

            // Si lo deseas, puedes seleccionar el primer elemento como predeterminado
            if (DescripcionDeposito_Combobox.Items.Count > 0)
            {
                DescripcionDeposito_Combobox.SelectedIndex = 0;
            }
        }

        private void CargarMercaderias()
        {
            var deposito = Datos_model.Depositos.Where(x => x.Nombre_Deposito == DescripcionDeposito_Combobox.SelectedItem).FirstOrDefault();

            var cliente = 0;

            if (IdCliente_textbox.Text != "")
            {
                cliente = int.Parse(IdCliente_textbox.Text);
            }     

            var depositoMercaderias = Datos_model.DepositoMercaderias
                .Where(x => x.Id_Deposito == deposito.Id_Deposito)
                .Where(x => x.Id_Cliente == cliente)
                .Select(x => x.Id_Mercaderia) 
                .Distinct()
                .ToList();

            var mercaderias = new List<string>();

            foreach (var item in depositoMercaderias)
            {
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == item).FirstOrDefault();

                mercaderias.Add(mercaderia.Descripcion_Mercaderia);
            }

            DescripcionMercaderia_ComboBox.Items.Clear();

            foreach (var mercaderia in mercaderias)
            {
                DescripcionMercaderia_ComboBox.Items.Add(mercaderia);
            }

            if (DescripcionMercaderia_ComboBox.Items.Count > 0)
            {
                DescripcionMercaderia_ComboBox.SelectedIndex = 0;
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
            Mercaderia = new ColumnHeader();
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
            IdCliente_textbox.Location = new Point(19, 39);
            IdCliente_textbox.Name = "IdCliente_textbox";
            IdCliente_textbox.Size = new Size(121, 23);
            IdCliente_textbox.TabIndex = 0;
            IdCliente_textbox.TextChanged += IdCliente_textbox_TextChanged;
            // 
            // Cantidad_textbox
            // 
            Cantidad_textbox.Location = new Point(9, 113);
            Cantidad_textbox.Name = "Cantidad_textbox";
            Cantidad_textbox.Size = new Size(186, 23);
            Cantidad_textbox.TabIndex = 1;
            // 
            // Dni_textbox
            // 
            Dni_textbox.Location = new Point(6, 37);
            Dni_textbox.Name = "Dni_textbox";
            Dni_textbox.Size = new Size(238, 23);
            Dni_textbox.TabIndex = 3;
            Dni_textbox.TextChanged += Dni_textbox_TextChanged;
            // 
            // DescripcionMercaderia_ComboBox
            // 
            DescripcionMercaderia_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionMercaderia_ComboBox.FormattingEnabled = true;
            DescripcionMercaderia_ComboBox.Location = new Point(9, 55);
            DescripcionMercaderia_ComboBox.Name = "DescripcionMercaderia_ComboBox";
            DescripcionMercaderia_ComboBox.Size = new Size(186, 23);
            DescripcionMercaderia_ComboBox.TabIndex = 4;
            // 
            // DescripcionDeposito_Combobox
            // 
            DescripcionDeposito_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            DescripcionDeposito_Combobox.Enabled = false;
            DescripcionDeposito_Combobox.FormattingEnabled = true;
            DescripcionDeposito_Combobox.Location = new Point(19, 107);
            DescripcionDeposito_Combobox.Name = "DescripcionDeposito_Combobox";
            DescripcionDeposito_Combobox.Size = new Size(121, 23);
            DescripcionDeposito_Combobox.TabIndex = 5;
            DescripcionDeposito_Combobox.SelectedIndexChanged += DescripcionDeposito_Combobox_SelectedIndexChanged;
            // 
            // CrearOP_button
            // 
            CrearOP_button.Location = new Point(554, 492);
            CrearOP_button.Name = "CrearOP_button";
            CrearOP_button.Size = new Size(75, 23);
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
            DatosTransportistas_groupbox.Location = new Point(298, 23);
            DatosTransportistas_groupbox.Name = "DatosTransportistas_groupbox";
            DatosTransportistas_groupbox.Size = new Size(446, 152);
            DatosTransportistas_groupbox.TabIndex = 8;
            DatosTransportistas_groupbox.TabStop = false;
            DatosTransportistas_groupbox.Text = "Datos Transportistas";
            // 
            // dateTimePicker_fecha
            // 
            dateTimePicker_fecha.Location = new Point(6, 96);
            dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            dateTimePicker_fecha.Size = new Size(287, 23);
            dateTimePicker_fecha.TabIndex = 6;
            // 
            // FechaEntrega_label
            // 
            FechaEntrega_label.AutoSize = true;
            FechaEntrega_label.Location = new Point(6, 78);
            FechaEntrega_label.Name = "FechaEntrega_label";
            FechaEntrega_label.Size = new Size(199, 15);
            FechaEntrega_label.TabIndex = 5;
            FechaEntrega_label.Text = "Fecha Entrega Orden de Preparacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI Transportista";
            // 
            // DatosGenerales_groupBox
            // 
            DatosGenerales_groupBox.Controls.Add(Deposito_label);
            DatosGenerales_groupBox.Controls.Add(IdCliente_label);
            DatosGenerales_groupBox.Controls.Add(DescripcionDeposito_Combobox);
            DatosGenerales_groupBox.Controls.Add(IdCliente_textbox);
            DatosGenerales_groupBox.Location = new Point(48, 23);
            DatosGenerales_groupBox.Name = "DatosGenerales_groupBox";
            DatosGenerales_groupBox.Size = new Size(226, 152);
            DatosGenerales_groupBox.TabIndex = 10;
            DatosGenerales_groupBox.TabStop = false;
            DatosGenerales_groupBox.Text = "Datos Generales";
            // 
            // Deposito_label
            // 
            Deposito_label.AutoSize = true;
            Deposito_label.Location = new Point(19, 78);
            Deposito_label.Name = "Deposito_label";
            Deposito_label.Size = new Size(119, 15);
            Deposito_label.TabIndex = 11;
            Deposito_label.Text = "Descripcion Deposito";
            // 
            // IdCliente_label
            // 
            IdCliente_label.AutoSize = true;
            IdCliente_label.Location = new Point(19, 19);
            IdCliente_label.Name = "IdCliente_label";
            IdCliente_label.Size = new Size(58, 15);
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
            DatosMercaderias_groupBox.Location = new Point(48, 196);
            DatosMercaderias_groupBox.Name = "DatosMercaderias_groupBox";
            DatosMercaderias_groupBox.Size = new Size(226, 290);
            DatosMercaderias_groupBox.TabIndex = 11;
            DatosMercaderias_groupBox.TabStop = false;
            DatosMercaderias_groupBox.Text = "Datos Mercaderias";
            // 
            // button_agregar
            // 
            button_agregar.Location = new Point(120, 152);
            button_agregar.Name = "button_agregar";
            button_agregar.Size = new Size(75, 23);
            button_agregar.TabIndex = 13;
            button_agregar.Text = "Agregar ";
            button_agregar.UseVisualStyleBackColor = true;
            button_agregar.Click += button_agregar_Click;
            // 
            // Cantidad_label
            // 
            Cantidad_label.AutoSize = true;
            Cantidad_label.Location = new Point(9, 95);
            Cantidad_label.Name = "Cantidad_label";
            Cantidad_label.Size = new Size(117, 15);
            Cantidad_label.TabIndex = 6;
            Cantidad_label.Text = "Cantidad Mercaderia";
            // 
            // Descripcion_label
            // 
            Descripcion_label.AutoSize = true;
            Descripcion_label.Location = new Point(9, 37);
            Descripcion_label.Name = "Descripcion_label";
            Descripcion_label.Size = new Size(131, 15);
            Descripcion_label.TabIndex = 5;
            Descripcion_label.Text = "Descripcion Mercaderia";
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(642, 492);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(102, 23);
            VolverAlMenu_button.TabIndex = 12;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // listView_MercaderiasOrdenes
            // 
            listView_MercaderiasOrdenes.CheckBoxes = true;
            listView_MercaderiasOrdenes.Columns.AddRange(new ColumnHeader[] { Mercaderia, Cantidad });
            listView_MercaderiasOrdenes.Location = new Point(6, 22);
            listView_MercaderiasOrdenes.Name = "listView_MercaderiasOrdenes";
            listView_MercaderiasOrdenes.Size = new Size(409, 252);
            listView_MercaderiasOrdenes.TabIndex = 13;
            listView_MercaderiasOrdenes.UseCompatibleStateImageBehavior = false;
            listView_MercaderiasOrdenes.View = View.Details;
            // 
            // Mercaderia
            // 
            Mercaderia.Text = "Mercaderia";
            Mercaderia.Width = 100;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView_MercaderiasOrdenes);
            groupBox1.Location = new Point(298, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 289);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items Orden de Preparacion";
            // 
            // button2
            // 
            button2.Location = new Point(455, 492);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 541);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(DatosMercaderias_groupBox);
            Controls.Add(DatosGenerales_groupBox);
            Controls.Add(DatosTransportistas_groupbox);
            Controls.Add(CrearOP_button);
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
        private ColumnHeader Mercaderia;
        private ColumnHeader Cantidad;
        private Button button2;
        private ColumnHeader Item;
        private DateTimePicker dateTimePicker_fecha;
    }
}