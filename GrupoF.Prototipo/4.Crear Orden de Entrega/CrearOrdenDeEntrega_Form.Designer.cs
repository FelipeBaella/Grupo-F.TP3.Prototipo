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
            Estado_OP = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Prioridad_OP = new ColumnHeader();
            Fecha_Emision_OP = new ColumnHeader();
            Descripcion_Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Deposito = new ColumnHeader();
            CrearOrdenDeEntrega_boton = new Button();
            IdOrdenDePreparacion_label = new Label();
            OrdenDePreparacion_textbox = new TextBox();
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Estado_OP, ID_OP, Prioridad_OP, Fecha_Emision_OP, Descripcion_Mercaderia, Cantidad, Deposito });
            listView1.Font = new Font("Segoe UI", 9F);
            listView1.Location = new Point(12, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 255);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // CrearOrdenDeEntrega_boton
            // 
            CrearOrdenDeEntrega_boton.Font = new Font("Segoe UI", 9F);
            CrearOrdenDeEntrega_boton.Location = new Point(534, 309);
            CrearOrdenDeEntrega_boton.Name = "CrearOrdenDeEntrega_boton";
            CrearOrdenDeEntrega_boton.Size = new Size(142, 36);
            CrearOrdenDeEntrega_boton.TabIndex = 2;
            CrearOrdenDeEntrega_boton.Text = "Crear Orden De Entrega";
            CrearOrdenDeEntrega_boton.UseVisualStyleBackColor = true;
            // 
            // IdOrdenDePreparacion_label
            // 
            IdOrdenDePreparacion_label.AutoSize = true;
            IdOrdenDePreparacion_label.Font = new Font("Segoe UI", 9F);
            IdOrdenDePreparacion_label.Location = new Point(392, 291);
            IdOrdenDePreparacion_label.Name = "IdOrdenDePreparacion_label";
            IdOrdenDePreparacion_label.Size = new Size(136, 15);
            IdOrdenDePreparacion_label.TabIndex = 3;
            IdOrdenDePreparacion_label.Text = "Id Orden De Preparacion";
            // 
            // OrdenDePreparacion_textbox
            // 
            OrdenDePreparacion_textbox.Location = new Point(392, 312);
            OrdenDePreparacion_textbox.Name = "OrdenDePreparacion_textbox";
            OrdenDePreparacion_textbox.Size = new Size(136, 29);
            OrdenDePreparacion_textbox.TabIndex = 4;
            // 
            // CrearOrdenDeEntrega_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 378);
            Controls.Add(OrdenDePreparacion_textbox);
            Controls.Add(IdOrdenDePreparacion_label);
            Controls.Add(CrearOrdenDeEntrega_boton);
            Controls.Add(listView1);
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
        private ListView listView1;
        private Button CrearOrdenDeEntrega_boton;
        private ColumnHeader Estado_OP;
        private ColumnHeader ID_OP;
        private ColumnHeader Prioridad_OP;
        private ColumnHeader Fecha_Emision_OP;
        private ColumnHeader Deposito;
        private ColumnHeader Descripcion_Mercaderia;
        private ColumnHeader Cantidad;
        private Label IdOrdenDePreparacion_label;
        private TextBox OrdenDePreparacion_textbox;
    }
}