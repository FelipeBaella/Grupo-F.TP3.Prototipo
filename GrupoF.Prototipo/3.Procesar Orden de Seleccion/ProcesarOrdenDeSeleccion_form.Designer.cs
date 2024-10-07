using GrupoF.Prototipo.Procesar_ordener_de_seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;

namespace GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion
{
    partial class ProcesarOrdenDeSeleccion_form
    {
        private CrearOrdenDeSeleccion_model CrearOrdenesDeSeleccionModel = new CrearOrdenDeSeleccion_model();
        private CrearOrdnesDePreparacionModel CrearOrdnesDePreparacionModel = new CrearOrdnesDePreparacionModel();
        private ProcesarOrdenDeSeleccion_model ProcesarOrdenDeSeleccionModel = new ProcesarOrdenDeSeleccion_model();

        private void CargarOrdenesDePreparacion()
        {
            foreach (var orden in ProcesarOrdenDeSeleccionModel.OrdenesDeSeleccion)
            {
                var cliente = CrearOrdnesDePreparacionModel.Clientes.Where(x => x.Id_Cliente == orden.Id_Cliente).FirstOrDefault();
                var mercaderia = CrearOrdnesDePreparacionModel.Mercaderias.Where(x => x.Id_Mercaderia == orden.Id_Mercaderia).FirstOrDefault();
                var depositos = CrearOrdnesDePreparacionModel.Depositos.Where(x => x.Id_Deposito == orden.Id_Deposito).FirstOrDefault();
                var OrdenDePreparacion = CrearOrdenesDeSeleccionModel.OrdenesDePreparacion.Where(x => x.Id_OrdenDePreparacion == orden.Id_Deposito).FirstOrDefault();
                var estado = CrearOrdenesDeSeleccionModel.OrdenesDePreparacion.Where(x => x.Id_Estado == orden.Id_Estado).FirstOrDefault();


                ListViewItem listViewItem = new ListViewItem(new string[] {

                    estado.Id_Estado.ToString(),
                    orden.Id_OrdenDeSeleccion.ToString(),
                    orden.Id_OrdenPreparacion.ToString(),
                    OrdenDePreparacion.Prioridad_OrdenDePreparacion.ToString(),
                    OrdenDePreparacion.Emision_OrdenDePreparacion.ToString(),
                    depositos.Nombre_Deposito,              
                    mercaderia.Descripcion_Mercaderia,
                    OrdenDePreparacion.Cantidad_OrdenDePreparacion.ToString(),
                    "Cordenadas".ToString(),
                 
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
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Coordenadas = new ColumnHeader();
            Deposito = new ColumnHeader();
            CompletarOrdenDeSeleccion_boton = new Button();
            VolverAlMenu_Button = new Button();
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
            CargarOrdenesDePreparacion();
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
            // Deposito
            // 
            Deposito.Text = "Deposito";
            // 
            // CompletarOrdenDeSeleccion_boton
            // 
            CompletarOrdenDeSeleccion_boton.Location = new Point(386, 307);
            CompletarOrdenDeSeleccion_boton.Name = "CompletarOrdenDeSeleccion_boton";
            CompletarOrdenDeSeleccion_boton.Size = new Size(197, 33);
            CompletarOrdenDeSeleccion_boton.TabIndex = 2;
            CompletarOrdenDeSeleccion_boton.Text = "Procesar Orden de Seleccion";
            CompletarOrdenDeSeleccion_boton.UseVisualStyleBackColor = true;
            // 
            // VolverAlMenu_Button
            // 
            VolverAlMenu_Button.Location = new Point(598, 307);
            VolverAlMenu_Button.Name = "VolverAlMenu_Button";
            VolverAlMenu_Button.Size = new Size(124, 33);
            VolverAlMenu_Button.TabIndex = 15;
            VolverAlMenu_Button.Text = "Volver Al Menu";
            VolverAlMenu_Button.UseVisualStyleBackColor = true;
            VolverAlMenu_Button.Click += VolverAlMenu_Button_Click;
            // 
            // ProcesarOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 361);
            Controls.Add(VolverAlMenu_Button);
            Controls.Add(CompletarOrdenDeSeleccion_boton);
            Controls.Add(ProcesarOrdenesDeSeleccion_listView);
            Controls.Add(OrdenesDeSeleccionLabel);
            Name = "ProcesarOrdenDeSeleccion_form";
            Text = "Procesar Orden de Seleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrdenesDeSeleccionLabel;
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
        private Button CompletarOrdenDeSeleccion_boton;
        private Button VolverAlMenu_Button;
    }
}