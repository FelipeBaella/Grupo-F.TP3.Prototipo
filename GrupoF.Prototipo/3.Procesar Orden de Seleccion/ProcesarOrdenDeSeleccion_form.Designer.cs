using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    partial class ProcesarOrdenDeSeleccion_form
    {
        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in Datos_model.OrdenesDeSeleccion)
            {
                var OrdenDePreparacion = Datos_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();

                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == OrdenDePreparacion.Id_Cliente).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == OrdenDePreparacion.Id_Mercaderia).FirstOrDefault();
                var depositos = Datos_model.Depositos.Where(x => x.Id_Deposito == OrdenDePreparacion.Id_Deposito).FirstOrDefault();   
                
                var estado = Datos_model.OrdenesDePreparacion.Where(x => x.Id_Estado == orden.Id_Estado).FirstOrDefault();


                ListViewItem listViewItem = new ListViewItem(new string[] {

                    estado.Id_Estado.ToString(),
                    orden.Id_OrdenDeSeleccion.ToString(),
                    OrdenDePreparacion.Id_OrdenDePreparacion.ToString(),
                    OrdenDePreparacion.Prioridad_OrdenDePreparacion.ToString(),
                    OrdenDePreparacion.Emision_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,              
                    mercaderia.Descripcion_Mercaderia,
                    OrdenDePreparacion.Cantidad_OrdenDePreparacion.ToString(),
                    depositos.Coordenadas_Deposito.ToString(),
                 
                }, -1);

                ProcesarOrdenesDeSeleccion_listView.Items.Add(listViewItem);
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
            OrdenesDeSeleccionLabel = new Label();
            ProcesarOrdenesDeSeleccion_listView = new ListView();
            Estado_OS = new ColumnHeader();
            ID_OS = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_OP = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
            Deposito = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Coordenadas = new ColumnHeader();
            ProcesarOrdenDeSeleccion_button = new Button();
            VolverAlMenu_button = new Button();
            IdOrdenDeSeleccion_textbox = new TextBox();
            label_Id_OrdenDeSeleccion = new Label();
            SuspendLayout();
            // 
            // OrdenesDeSeleccionLabel
            // 
            OrdenesDeSeleccionLabel.AutoSize = true;
            OrdenesDeSeleccionLabel.Font = new Font("Segoe UI", 12F);
            OrdenesDeSeleccionLabel.Location = new Point(12, 9);
            OrdenesDeSeleccionLabel.Name = "OrdenesDeSeleccionLabel";
            OrdenesDeSeleccionLabel.Size = new Size(159, 21);
            OrdenesDeSeleccionLabel.TabIndex = 0;
            OrdenesDeSeleccionLabel.Text = "Ordenes de Seleccion";
            // 
            // ProcesarOrdenesDeSeleccion_listView
            // 
            ProcesarOrdenesDeSeleccion_listView.Columns.AddRange(new ColumnHeader[] { Estado_OS, ID_OS, ID_OP, Prioridad_OP, Fecha_Emision, Deposito, Descripcion_Mercaderia, Cantidad, Coordenadas });
            ProcesarOrdenesDeSeleccion_listView.Location = new Point(12, 33);
            ProcesarOrdenesDeSeleccion_listView.Name = "ProcesarOrdenesDeSeleccion_listView";
            ProcesarOrdenesDeSeleccion_listView.Size = new Size(714, 268);
            ProcesarOrdenesDeSeleccion_listView.TabIndex = 1;
            ProcesarOrdenesDeSeleccion_listView.UseCompatibleStateImageBehavior = false;
            ProcesarOrdenesDeSeleccion_listView.View = View.Details;
            // 
            // Estado_OS
            // 
            Estado_OS.Text = "Estado OS";
            Estado_OS.Width = 80;
            // 
            // ID_OS
            // 
            ID_OS.Text = "ID OS";
            ID_OS.Width = 50;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            ID_OP.Width = 50;
            // 
            // Prioridad_OP
            // 
            Prioridad_OP.Text = "Prioridad OP";
            Prioridad_OP.Width = 80;
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.Text = "Fecha Emision";
            Fecha_Emision.Width = 90;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // Coordenadas
            // 
            Coordenadas.Text = "Coordenadas";
            Coordenadas.Width = 90;
            // 
            // ProcesarOrdenDeSeleccion_button
            // 
            ProcesarOrdenDeSeleccion_button.Location = new Point(387, 312);
            ProcesarOrdenDeSeleccion_button.Name = "ProcesarOrdenDeSeleccion_button";
            ProcesarOrdenDeSeleccion_button.Size = new Size(197, 33);
            ProcesarOrdenDeSeleccion_button.TabIndex = 2;
            ProcesarOrdenDeSeleccion_button.Text = "Procesar Orden de Seleccion";
            ProcesarOrdenDeSeleccion_button.UseVisualStyleBackColor = true;
            ProcesarOrdenDeSeleccion_button.Click += button_ProcesarOrdenDeSeleccion_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(590, 312);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(124, 33);
            VolverAlMenu_button.TabIndex = 15;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // IdOrdenDeSeleccion_textbox
            // 
            IdOrdenDeSeleccion_textbox.Location = new Point(259, 321);
            IdOrdenDeSeleccion_textbox.Name = "IdOrdenDeSeleccion_textbox";
            IdOrdenDeSeleccion_textbox.Size = new Size(100, 23);
            IdOrdenDeSeleccion_textbox.TabIndex = 16;
            // 
            // label_Id_OrdenDeSeleccion
            // 
            label_Id_OrdenDeSeleccion.AutoSize = true;
            label_Id_OrdenDeSeleccion.Location = new Point(257, 303);
            label_Id_OrdenDeSeleccion.Name = "label_Id_OrdenDeSeleccion";
            label_Id_OrdenDeSeleccion.Size = new Size(122, 15);
            label_Id_OrdenDeSeleccion.TabIndex = 17;
            label_Id_OrdenDeSeleccion.Text = "Id Orden de Seleccion";
            // 
            // ProcesarOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 361);
            Controls.Add(label_Id_OrdenDeSeleccion);
            Controls.Add(IdOrdenDeSeleccion_textbox);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(ProcesarOrdenDeSeleccion_button);
            Controls.Add(ProcesarOrdenesDeSeleccion_listView);
            Controls.Add(OrdenesDeSeleccionLabel);
            Name = "ProcesarOrdenDeSeleccion_form";
            Text = "Procesar Orden de Seleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ProcesarOrdenesDeSeleccion_listView;
        private ColumnHeader Estado_OS;
        private ColumnHeader ID_OS;
        private ColumnHeader ID_OP;
        private ColumnHeader Prioridad_OP;
        private ColumnHeader Fecha_Emision;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader Coordenadas;
        private ColumnHeader Deposito;
        private Button ProcesarOrdenDeSeleccion_button;
        private Button VolverAlMenu_button;
        private TextBox IdOrdenDeSeleccion_textbox;
        private Label label_Id_OrdenDeSeleccion;
    }
}