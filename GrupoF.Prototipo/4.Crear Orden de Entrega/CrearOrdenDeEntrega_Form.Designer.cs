namespace GrupoF.Prototipo._4.Crear_Orden_de_Entrega
{
    partial class CrearOrdenDeEntrega_Form
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
            listView1 = new ListView();
            CrearOrdenDeEntrega_boton = new Button();
            Estado_OS = new ColumnHeader();
            ID_OS = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_OP = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
            Deposito = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Coordenadas = new ColumnHeader();
            SuspendLayout();
            // 
            // CrearOrdenDeEntrega_label
            // 
            CrearOrdenDeEntrega_label.AutoSize = true;
            CrearOrdenDeEntrega_label.Location = new Point(13, 9);
            CrearOrdenDeEntrega_label.Margin = new Padding(4, 0, 4, 0);
            CrearOrdenDeEntrega_label.Name = "CrearOrdenDeEntrega_label";
            CrearOrdenDeEntrega_label.Size = new Size(161, 21);
            CrearOrdenDeEntrega_label.TabIndex = 0;
            CrearOrdenDeEntrega_label.Text = "Ordenes De Seleccion";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Estado_OS, ID_OS, ID_OP, Prioridad_OP, Fecha_Emision, Deposito, Descripcion_Mercaderia, Cantidad, Coordenadas });
            listView1.Font = new Font("Segoe UI", 9F);
            listView1.Location = new Point(12, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 255);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CrearOrdenDeEntrega_boton
            // 
            CrearOrdenDeEntrega_boton.Location = new Point(275, 294);
            CrearOrdenDeEntrega_boton.Name = "CrearOrdenDeEntrega_boton";
            CrearOrdenDeEntrega_boton.Size = new Size(225, 45);
            CrearOrdenDeEntrega_boton.TabIndex = 2;
            CrearOrdenDeEntrega_boton.Text = "Crear Orden De Entrega";
            CrearOrdenDeEntrega_boton.UseVisualStyleBackColor = true;
            // 
            // Estado_OS
            // 
            Estado_OS.Text = "Estado OS";
            Estado_OS.Width = 90;
            // 
            // ID_OS
            // 
            ID_OS.Text = "ID OS";
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
            // Fecha_Emision
            // 
            Fecha_Emision.Text = "Fecha Emision";
            Fecha_Emision.Width = 100;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
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
            // Coordenadas
            // 
            Coordenadas.Text = "Coordenadas";
            Coordenadas.Width = 90;
            // 
            // CrearOrdenDeEntrega_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 378);
            Controls.Add(CrearOrdenDeEntrega_boton);
            Controls.Add(listView1);
            Controls.Add(CrearOrdenDeEntrega_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CrearOrdenDeEntrega_Form";
            Text = "Crear Orden De Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CrearOrdenDeEntrega_label;
        private ListView listView1;
        private Button CrearOrdenDeEntrega_boton;
        private ColumnHeader Estado_OS;
        private ColumnHeader ID_OS;
        private ColumnHeader ID_OP;
        private ColumnHeader Prioridad_OP;
        private ColumnHeader Fecha_Emision;
        private ColumnHeader Deposito;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader Coordenadas;
    }
}