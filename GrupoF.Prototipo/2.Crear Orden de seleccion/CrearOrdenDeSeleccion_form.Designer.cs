using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo.Procesar_ordener_de_seleccion
{


    partial class CrearOrdenDeSeleccion_form
    {    
        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in Datos_model.OrdenesDePreparacion)
            {
                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == orden.Id_Mercaderia).FirstOrDefault();
                var depositos = Datos_model.Depositos.Where(x => x.Id_Deposito == orden.Id_Deposito).FirstOrDefault();


                ListViewItem listViewItem = new ListViewItem(new string[] {

                    orden.Emision_OrdenDePreparacion.ToString(),
                    orden.Prioridad_OrdenDePreparacion.ToString(),
                    orden.Id_OrdenDePreparacion.ToString(),
                    orden.Id_Cliente.ToString(),
                    cliente.NombreApellido,
                    orden.Emision_OrdenDePreparacion.ToString(),
                    mercaderia.Descripcion_Mercaderia,
                    orden.Cantidad_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,
                }, -1);

                OrdenesDePreparacion_ListView.Items.Add(listViewItem);
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
            OrdenesDePreparacion_ListView = new ListView();
            Estado_OP = new ColumnHeader();
            Prioridad = new ColumnHeader();
            ID_OP = new ColumnHeader();
            ID_Cliente = new ColumnHeader();
            Nombre_Cliente = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            CrearOrden_button = new Button();
            OrdenesDePreparacion_label = new Label();
            IdOrden_textBox = new TextBox();
            label2 = new Label();
            VolverAlMenu_button = new Button();
            SuspendLayout();
            // 
            // OrdenesDePreparacion_ListView
            // 
            OrdenesDePreparacion_ListView.Columns.AddRange(new ColumnHeader[] { Estado_OP, Prioridad, ID_OP, ID_Cliente, Nombre_Cliente, Fecha_Emision, Descripcion_Mercaderia, Cantidad, Deposito });
            OrdenesDePreparacion_ListView.Location = new Point(12, 42);
            OrdenesDePreparacion_ListView.Name = "OrdenesDePreparacion_ListView";
            OrdenesDePreparacion_ListView.Size = new Size(810, 207);
            OrdenesDePreparacion_ListView.TabIndex = 0;
            OrdenesDePreparacion_ListView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_ListView.View = View.Details;
            // 
            // Estado_OP
            // 
            Estado_OP.Text = "Estado OP";
            Estado_OP.Width = 70;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // ID_Cliente
            // 
            ID_Cliente.Text = "ID Cliente";
            ID_Cliente.Width = 70;
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.Text = "Nombre Cliente";
            Nombre_Cliente.Width = 140;
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.Text = "Fecha Emision";
            Fecha_Emision.Width = 90;
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 170;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // CrearOrden_button
            // 
            CrearOrden_button.Location = new Point(568, 314);
            CrearOrden_button.Name = "CrearOrden_button";
            CrearOrden_button.Size = new Size(158, 23);
            CrearOrden_button.TabIndex = 1;
            CrearOrden_button.Text = "Crear orden de seleccion";
            CrearOrden_button.UseVisualStyleBackColor = true;
            CrearOrden_button.Click += button_Crear_Orden_Click;
            // 
            // OrdenesDePreparacion_label
            // 
            OrdenesDePreparacion_label.AutoSize = true;
            OrdenesDePreparacion_label.Font = new Font("Segoe UI", 11F);
            OrdenesDePreparacion_label.Location = new Point(12, 19);
            OrdenesDePreparacion_label.Name = "OrdenesDePreparacion_label";
            OrdenesDePreparacion_label.Size = new Size(169, 20);
            OrdenesDePreparacion_label.TabIndex = 2;
            OrdenesDePreparacion_label.Text = "Ordenes de preparacion";
            // 
            // IdOrden_textBox
            // 
            IdOrden_textBox.Location = new Point(462, 314);
            IdOrden_textBox.Name = "IdOrden_textBox";
            IdOrden_textBox.Size = new Size(100, 23);
            IdOrden_textBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 290);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 4;
            label2.Text = "Id Orden de Preparacion";
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(732, 313);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(101, 23);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // CrearOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 375);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(label2);
            Controls.Add(IdOrden_textBox);
            Controls.Add(OrdenesDePreparacion_label);
            Controls.Add(CrearOrden_button);
            Controls.Add(OrdenesDePreparacion_ListView);
            Name = "CrearOrdenDeSeleccion_form";
            Text = "Crear Orden de seleccion";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListView OrdenesDePreparacion_ListView;
        private ColumnHeader Estado_OP;
        private ColumnHeader Prioridad;
        private ColumnHeader ID_OP;
        private ColumnHeader ID_Cliente;
        private ColumnHeader Nombre_Cliente;
        private ColumnHeader Fecha_Emision;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader Deposito;
        private Button CrearOrden_button;
        private Label OrdenesDePreparacion_label;
        private TextBox textBox1;
        private TextBox prueba6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ColumnHeader Nombre;
        private TextBox IdOrden_textBox;
        private Label label2;
        private Button VolverAlMenu_button;
    }
}