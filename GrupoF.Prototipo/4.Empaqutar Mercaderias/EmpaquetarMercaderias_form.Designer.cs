using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    partial class EmpaquetarMercaderias_form
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

                OrdenesDePreparacion_listView.Items.Add(listViewItem);
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
            CrearOrdenDeEntrega_label = new Label();
            OrdenesDePreparacion_listView = new ListView();
            Estado_OP = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_OP = new ColumnHeader();
            Fecha_Emision_OP = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            CrearOrdenDeEntrega_button = new Button();
            IdOrdenDePreparacion_label = new Label();
            IdOrdenDePreparacion_textbox = new TextBox();
            VolverAlMenu_button = new Button();
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
            OrdenesDePreparacion_listView.Columns.AddRange(new ColumnHeader[] { Estado_OP, ID_OP, Prioridad_OP, Fecha_Emision_OP, Descripcion_Mercaderia, Cantidad, Deposito });
            OrdenesDePreparacion_listView.Font = new Font("Segoe UI", 9F);
            OrdenesDePreparacion_listView.Location = new Point(12, 33);
            OrdenesDePreparacion_listView.Name = "OrdenesDePreparacion_listView";
            OrdenesDePreparacion_listView.Size = new Size(675, 255);
            OrdenesDePreparacion_listView.TabIndex = 1;
            OrdenesDePreparacion_listView.UseCompatibleStateImageBehavior = false;
            OrdenesDePreparacion_listView.View = View.Details;
            // 
            // Estado_OP
            // 
            Estado_OP.Text = "Estado OP";
            Estado_OP.Width = 90;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // Prioridad_OP
            // 
            Prioridad_OP.Text = "Prioridad OP";
            Prioridad_OP.Width = 100;
            // 
            // Fecha_Emision_OP
            // 
            Fecha_Emision_OP.Text = "Fecha Emision OP";
            Fecha_Emision_OP.Width = 120;
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
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // CrearOrdenDeEntrega_button
            // 
            CrearOrdenDeEntrega_button.Font = new Font("Segoe UI", 9F);
            CrearOrdenDeEntrega_button.Location = new Point(437, 318);
            CrearOrdenDeEntrega_button.Name = "CrearOrdenDeEntrega_button";
            CrearOrdenDeEntrega_button.Size = new Size(142, 36);
            CrearOrdenDeEntrega_button.TabIndex = 2;
            CrearOrdenDeEntrega_button.Text = "Crear Orden De Entrega";
            CrearOrdenDeEntrega_button.UseVisualStyleBackColor = true;
            CrearOrdenDeEntrega_button.Click += button_CrearOrdenDeEntrega_Click;
            // 
            // IdOrdenDePreparacion_label
            // 
            IdOrdenDePreparacion_label.AutoSize = true;
            IdOrdenDePreparacion_label.Font = new Font("Segoe UI", 9F);
            IdOrdenDePreparacion_label.Location = new Point(295, 307);
            IdOrdenDePreparacion_label.Name = "IdOrdenDePreparacion_label";
            IdOrdenDePreparacion_label.Size = new Size(136, 15);
            IdOrdenDePreparacion_label.TabIndex = 3;
            IdOrdenDePreparacion_label.Text = "Id Orden De Preparacion";
            // 
            // IdOrdenDePreparacion_textbox
            // 
            IdOrdenDePreparacion_textbox.Location = new Point(295, 325);
            IdOrdenDePreparacion_textbox.Name = "IdOrdenDePreparacion_textbox";
            IdOrdenDePreparacion_textbox.Size = new Size(136, 29);
            IdOrdenDePreparacion_textbox.TabIndex = 4;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Font = new Font("Segoe UI", 9F);
            VolverAlMenu_button.Location = new Point(585, 318);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(102, 36);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // CrearOrdenDeEntrega_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 378);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(IdOrdenDePreparacion_textbox);
            Controls.Add(IdOrdenDePreparacion_label);
            Controls.Add(CrearOrdenDeEntrega_button);
            Controls.Add(OrdenesDePreparacion_listView);
            Controls.Add(CrearOrdenDeEntrega_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CrearOrdenDeEntrega_Form";
            Text = "Crear Orden De Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CrearOrdenDeEntrega_label;
        private ListView OrdenesDePreparacion_listView;
        private Button CrearOrdenDeEntrega_button;
        private ColumnHeader Estado_OP;
        private ColumnHeader ID_OP;
        private ColumnHeader Prioridad_OP;
        private ColumnHeader Fecha_Emision_OP;
        private ColumnHeader Deposito;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private Label IdOrdenDePreparacion_label;
        private TextBox OrdenDePreparacion_textbox;
        private Button VolverAlMenu_button;
        private TextBox IdOrdenDePreparacion_textbox;
    }
}