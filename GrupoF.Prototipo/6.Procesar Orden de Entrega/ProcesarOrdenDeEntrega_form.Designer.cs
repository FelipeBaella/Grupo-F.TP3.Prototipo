using GrupoF.Prototipo.Base_de_Datos;
using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._6.Procesar_Orden_de_Entrega
{
    partial class ProcesarOrdenDeEntrega_form
    {
        private void CargarOrdenesDeEntrega()
        {
            foreach (var orden in Datos_model.OrdenesDeEntrega)
            {
                var OrdnesDePreparacion = Datos_model.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == orden.Id_OrdenDePreparacion).FirstOrDefault();

                var cliente = Datos_model.Clientes.Where(x => x.Id_Cliente == OrdnesDePreparacion.Id_Cliente).FirstOrDefault();
                var mercaderia = Datos_model.Mercaderias.Where(x => x.Id_Mercaderia == OrdnesDePreparacion.Id_Mercaderia).FirstOrDefault();
                var depositos = Datos_model.Depositos.Where(x => x.Id_Deposito == OrdnesDePreparacion.Id_Deposito).FirstOrDefault();

                ListViewItem listViewItem = new ListViewItem(new string[] {

                    orden.Id_Estado.ToString(),
                    orden.Id_OrdenDeEntrega.ToString(),
                    orden.Emision_OrdenDeEntrega.ToString(),
                    orden.Id_OrdenDePreparacion.ToString(),

                    OrdnesDePreparacion.Prioridad_OrdenDePreparacion.ToString(),
               
                    mercaderia.Descripcion_Mercaderia,
                    OrdnesDePreparacion.Cantidad_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,
                    OrdnesDePreparacion.Dni_Transportista.ToString(),

                }, -1);

                listView_OrdenesDeEntrega.Items.Add(listViewItem);
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
            listView_OrdenesDeEntrega = new ListView();
            Estado_OE = new ColumnHeader();
            ID_OE = new ColumnHeader();
            Fecha_Emision_OE = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_OP = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad_Mercaderia = new ColumnHeader();
            Deposito = new ColumnHeader();
            DNI_Transportista = new ColumnHeader();
            OrdenesDeEntrega_label = new Label();
            IdOrdenDeEntrega_label = new Label();
            IdOrdenDeEntrega_textBox = new TextBox();
            ProcesarOrdenDeEntrega_button = new Button();
            VolverAlMenu_button = new Button();
            SuspendLayout();
            // 
            // listView_OrdenesDeEntrega
            // 
            listView_OrdenesDeEntrega.Columns.AddRange(new ColumnHeader[] { Estado_OE, ID_OE, Fecha_Emision_OE, ID_OP, Prioridad_OP, Descripcion_Mercaderia, Cantidad_Mercaderia, Deposito, DNI_Transportista });
            listView_OrdenesDeEntrega.Location = new Point(12, 33);
            listView_OrdenesDeEntrega.Name = "listView_OrdenesDeEntrega";
            listView_OrdenesDeEntrega.Size = new Size(776, 171);
            listView_OrdenesDeEntrega.TabIndex = 0;
            listView_OrdenesDeEntrega.UseCompatibleStateImageBehavior = false;
            listView_OrdenesDeEntrega.View = View.Details;
            // 
            // Estado_OE
            // 
            Estado_OE.Text = "Estado OE";
            Estado_OE.Width = 80;
            // 
            // ID_OE
            // 
            ID_OE.Text = "ID OE";
            // 
            // Fecha_Emision_OE
            // 
            Fecha_Emision_OE.Text = "Fecha Emision OE";
            Fecha_Emision_OE.Width = 110;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // Prioridad_OP
            // 
            Prioridad_OP.Text = "Prioridad OP";
            Prioridad_OP.Width = 80;
            // 
            // Descripcion_Mercaderia
            // 
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 140;
            // 
            // Cantidad_Mercaderia
            // 
            Cantidad_Mercaderia.Text = "Cantidad";
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            // 
            // DNI_Transportista
            // 
            DNI_Transportista.Text = "DNI Transportista";
            DNI_Transportista.Width = 130;
            // 
            // OrdenesDeEntrega_label
            // 
            OrdenesDeEntrega_label.AutoSize = true;
            OrdenesDeEntrega_label.Font = new Font("Segoe UI", 12F);
            OrdenesDeEntrega_label.Location = new Point(12, 9);
            OrdenesDeEntrega_label.Name = "OrdenesDeEntrega_label";
            OrdenesDeEntrega_label.Size = new Size(147, 21);
            OrdenesDeEntrega_label.TabIndex = 1;
            OrdenesDeEntrega_label.Text = "Ordenes de Entrega";
            // 
            // IdOrdenDeEntrega_label
            // 
            IdOrdenDeEntrega_label.AutoSize = true;
            IdOrdenDeEntrega_label.Location = new Point(490, 207);
            IdOrdenDeEntrega_label.Name = "IdOrdenDeEntrega_label";
            IdOrdenDeEntrega_label.Size = new Size(113, 15);
            IdOrdenDeEntrega_label.TabIndex = 2;
            IdOrdenDeEntrega_label.Text = "Id Orden De Entrega";
            // 
            // IdOrdenDeEntrega_textBox
            // 
            IdOrdenDeEntrega_textBox.Location = new Point(490, 226);
            IdOrdenDeEntrega_textBox.Name = "IdOrdenDeEntrega_textBox";
            IdOrdenDeEntrega_textBox.Size = new Size(100, 23);
            IdOrdenDeEntrega_textBox.TabIndex = 3;
            // 
            // ProcesarOrdenDeEntrega_button
            // 
            ProcesarOrdenDeEntrega_button.Font = new Font("Segoe UI", 9F);
            ProcesarOrdenDeEntrega_button.Location = new Point(596, 226);
            ProcesarOrdenDeEntrega_button.Name = "ProcesarOrdenDeEntrega_button";
            ProcesarOrdenDeEntrega_button.Size = new Size(75, 23);
            ProcesarOrdenDeEntrega_button.TabIndex = 4;
            ProcesarOrdenDeEntrega_button.Text = "Procesar";
            ProcesarOrdenDeEntrega_button.UseVisualStyleBackColor = true;
            ProcesarOrdenDeEntrega_button.Click += ProcesarOrdenDeEntrega_button_Click;
            // 
            // VolverAlMenu_button
            // 
            VolverAlMenu_button.Location = new Point(677, 226);
            VolverAlMenu_button.Name = "VolverAlMenu_button";
            VolverAlMenu_button.Size = new Size(101, 23);
            VolverAlMenu_button.TabIndex = 5;
            VolverAlMenu_button.Text = "Volver Al Menu";
            VolverAlMenu_button.UseVisualStyleBackColor = true;
            VolverAlMenu_button.Click += VolverAlMenu_button_Click;
            // 
            // ProcesarOrdenDeEntrega_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 267);
            Controls.Add(VolverAlMenu_button);
            Controls.Add(ProcesarOrdenDeEntrega_button);
            Controls.Add(IdOrdenDeEntrega_textBox);
            Controls.Add(IdOrdenDeEntrega_label);
            Controls.Add(OrdenesDeEntrega_label);
            Controls.Add(listView_OrdenesDeEntrega);
            Name = "ProcesarOrdenDeEntrega_form";
            Text = "Procesar Orden De Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_OrdenesDeEntrega;
        private Label OrdenesDeEntrega_label;
        private ColumnHeader Estado_OE;
        private ColumnHeader ID_OE;
        private ColumnHeader Fecha_Emision_OE;
        private ColumnHeader ID_OP;
        private ColumnHeader Prioridad_OP;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad_Mercaderia;
        private ColumnHeader Deposito;
        private ColumnHeader DNI_Transportista;
        private Label IdOrdenDeEntrega_label;
        private TextBox IdOrdenDeEntrega_textBox;
        private Button ProcesarOrdenDeEntrega_button;
        private Button VolverAlMenu_button;
    }
}