namespace GrupoF.Prototipo._0.Menu
{
    partial class Menu_form
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
            button_CrearOrdenDePreparacion = new Button();
            button_CrearOrdenDeSeleccion = new Button();
            button_ProcesarOrdenDeSeleccion = new Button();
            button_CrearOrdenDeEntrega = new Button();
            button_CrearRemito = new Button();
            button_ProcesarOrdenDeEntrega = new Button();
            button_Salir = new Button();
            SuspendLayout();
            // 
            // button_CrearOrdenDePreparacion
            // 
            button_CrearOrdenDePreparacion.Location = new Point(115, 10);
            button_CrearOrdenDePreparacion.Name = "button_CrearOrdenDePreparacion";
            button_CrearOrdenDePreparacion.Size = new Size(185, 50);
            button_CrearOrdenDePreparacion.TabIndex = 0;
            button_CrearOrdenDePreparacion.Text = "Crear Orden de Preparacion";
            button_CrearOrdenDePreparacion.UseVisualStyleBackColor = true;
            button_CrearOrdenDePreparacion.Click += button_CrearOrdenDePreparacion_Click;
            // 
            // button_CrearOrdenDeSeleccion
            // 
            button_CrearOrdenDeSeleccion.Location = new Point(115, 80);
            button_CrearOrdenDeSeleccion.Name = "button_CrearOrdenDeSeleccion";
            button_CrearOrdenDeSeleccion.Size = new Size(185, 50);
            button_CrearOrdenDeSeleccion.TabIndex = 1;
            button_CrearOrdenDeSeleccion.Text = "Crear Orden de Seleccion";
            button_CrearOrdenDeSeleccion.UseVisualStyleBackColor = true;
            button_CrearOrdenDeSeleccion.Click += button_CrearOrdenDeSeleccion_Click;
            // 
            // button_ProcesarOrdenDeSeleccion
            // 
            button_ProcesarOrdenDeSeleccion.Location = new Point(115, 150);
            button_ProcesarOrdenDeSeleccion.Name = "button_ProcesarOrdenDeSeleccion";
            button_ProcesarOrdenDeSeleccion.Size = new Size(185, 50);
            button_ProcesarOrdenDeSeleccion.TabIndex = 2;
            button_ProcesarOrdenDeSeleccion.Text = "Procesar Orden de Seleccion";
            button_ProcesarOrdenDeSeleccion.UseVisualStyleBackColor = true;
            button_ProcesarOrdenDeSeleccion.Click += button_ProcesarOrdenDeSeleccion_Click;
            // 
            // button_CrearOrdenDeEntrega
            // 
            button_CrearOrdenDeEntrega.Location = new Point(115, 220);
            button_CrearOrdenDeEntrega.Name = "button_CrearOrdenDeEntrega";
            button_CrearOrdenDeEntrega.Size = new Size(185, 50);
            button_CrearOrdenDeEntrega.TabIndex = 3;
            button_CrearOrdenDeEntrega.Text = "Crear Orden de Entrega";
            button_CrearOrdenDeEntrega.UseVisualStyleBackColor = true;
            button_CrearOrdenDeEntrega.Click += button_CrearOrdenDeEntrega_Click;
            // 
            // button_CrearRemito
            // 
            button_CrearRemito.Location = new Point(115, 290);
            button_CrearRemito.Name = "button_CrearRemito";
            button_CrearRemito.Size = new Size(185, 50);
            button_CrearRemito.TabIndex = 4;
            button_CrearRemito.Text = "Crear Remito";
            button_CrearRemito.UseVisualStyleBackColor = true;
            button_CrearRemito.Click += button_CrearRemito_Click;
            // 
            // button_ProcesarOrdenDeEntrega
            // 
            button_ProcesarOrdenDeEntrega.Location = new Point(115, 360);
            button_ProcesarOrdenDeEntrega.Name = "button_ProcesarOrdenDeEntrega";
            button_ProcesarOrdenDeEntrega.Size = new Size(185, 50);
            button_ProcesarOrdenDeEntrega.TabIndex = 5;
            button_ProcesarOrdenDeEntrega.Text = "Procesar Orden de Entrega";
            button_ProcesarOrdenDeEntrega.UseVisualStyleBackColor = true;
            button_ProcesarOrdenDeEntrega.Click += button_ProcesarOrdenDeEntrega_Click;
            // 
            // button_Salir
            // 
            button_Salir.Location = new Point(171, 416);
            button_Salir.Name = "button_Salir";
            button_Salir.Size = new Size(75, 23);
            button_Salir.TabIndex = 6;
            button_Salir.Text = "Salir";
            button_Salir.UseVisualStyleBackColor = true;
            button_Salir.Click += button_Salir_Click;
            // 
            // Menu_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(button_Salir);
            Controls.Add(button_ProcesarOrdenDeEntrega);
            Controls.Add(button_CrearRemito);
            Controls.Add(button_CrearOrdenDeEntrega);
            Controls.Add(button_ProcesarOrdenDeSeleccion);
            Controls.Add(button_CrearOrdenDeSeleccion);
            Controls.Add(button_CrearOrdenDePreparacion);
            Name = "Menu_form";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button_CrearOrdenDePreparacion;
        private Button button_CrearOrdenDeSeleccion;
        private Button button_ProcesarOrdenDeSeleccion;
        private Button button_CrearOrdenDeEntrega;
        private Button button_CrearRemito;
        private Button button_ProcesarOrdenDeEntrega;
        private Button button_Salir;
    }
}