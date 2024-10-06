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
            OrdenesDeSeleccionLabel = new Label();
            listView1 = new ListView();
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Estado_OS, ID_OS, ID_OP, Prioridad_OP, Fecha_Emision, Descripcion_Mercaderia, Cantidad, Coordenadas, Deposito });
            listView1.Location = new Point(12, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(714, 268);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            Descripcion_Mercaderia.DisplayIndex = 6;
            Descripcion_Mercaderia.Text = "Descripcion Mercaderia";
            Descripcion_Mercaderia.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.DisplayIndex = 7;
            Cantidad.Text = "Cantidad";
            // 
            // Coordenadas
            // 
            Coordenadas.DisplayIndex = 8;
            Coordenadas.Text = "Coordenadas";
            Coordenadas.Width = 90;
            // 
            // Deposito
            // 
            Deposito.DisplayIndex = 5;
            Deposito.Text = "Deposito";
            // 
            // CompletarOrdenDeSeleccion_boton
            // 
            CompletarOrdenDeSeleccion_boton.Location = new Point(256, 307);
            CompletarOrdenDeSeleccion_boton.Name = "CompletarOrdenDeSeleccion_boton";
            CompletarOrdenDeSeleccion_boton.Size = new Size(209, 23);
            CompletarOrdenDeSeleccion_boton.TabIndex = 2;
            CompletarOrdenDeSeleccion_boton.Text = "Orden de Seleccion Completada";
            CompletarOrdenDeSeleccion_boton.UseVisualStyleBackColor = true;
            // 
            // ProcesarOrdenDeSeleccion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(CompletarOrdenDeSeleccion_boton);
            Controls.Add(listView1);
            Controls.Add(OrdenesDeSeleccionLabel);
            Name = "ProcesarOrdenDeSeleccion_form";
            Text = "Procesar Orden de Seleccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrdenesDeSeleccionLabel;
        private ListView listView1;
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
    }
}