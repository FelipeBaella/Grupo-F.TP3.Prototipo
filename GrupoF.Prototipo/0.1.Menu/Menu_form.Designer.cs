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
            CrearOrdenDePreparacion_button = new Button();
            CrearOrdenDeSeleccion_button = new Button();
            ProcesarOrdenDeSeleccion_button = new Button();
            EmpaqutarMercaderias_button = new Button();
            CrearRemito_button = new Button();
            ProcesarOrdenDeEntrega_button = new Button();
            Salir_button = new Button();
            SuspendLayout();
            // 
            // CrearOrdenDePreparacion_button
            // 
            CrearOrdenDePreparacion_button.Location = new Point(115, 10);
            CrearOrdenDePreparacion_button.Name = "CrearOrdenDePreparacion_button";
            CrearOrdenDePreparacion_button.Size = new Size(185, 50);
            CrearOrdenDePreparacion_button.TabIndex = 0;
            CrearOrdenDePreparacion_button.Text = "Crear Orden de Preparacion";
            CrearOrdenDePreparacion_button.UseVisualStyleBackColor = true;
            CrearOrdenDePreparacion_button.Click += button_CrearOrdenDePreparacion_Click;
            // 
            // CrearOrdenDeSeleccion_button
            // 
            CrearOrdenDeSeleccion_button.Location = new Point(115, 80);
            CrearOrdenDeSeleccion_button.Name = "CrearOrdenDeSeleccion_button";
            CrearOrdenDeSeleccion_button.Size = new Size(185, 50);
            CrearOrdenDeSeleccion_button.TabIndex = 1;
            CrearOrdenDeSeleccion_button.Text = "Crear Orden de Seleccion";
            CrearOrdenDeSeleccion_button.UseVisualStyleBackColor = true;
            CrearOrdenDeSeleccion_button.Click += button_CrearOrdenDeSeleccion_Click;
            // 
            // ProcesarOrdenDeSeleccion_button
            // 
            ProcesarOrdenDeSeleccion_button.Location = new Point(115, 150);
            ProcesarOrdenDeSeleccion_button.Name = "ProcesarOrdenDeSeleccion_button";
            ProcesarOrdenDeSeleccion_button.Size = new Size(185, 50);
            ProcesarOrdenDeSeleccion_button.TabIndex = 2;
            ProcesarOrdenDeSeleccion_button.Text = "Procesar Orden de Seleccion";
            ProcesarOrdenDeSeleccion_button.UseVisualStyleBackColor = true;
            ProcesarOrdenDeSeleccion_button.Click += button_ProcesarOrdenDeSeleccion_Click;
            // 
            // EmpaqutarMercaderias_button
            // 
            EmpaqutarMercaderias_button.Location = new Point(115, 220);
            EmpaqutarMercaderias_button.Name = "EmpaqutarMercaderias_button";
            EmpaqutarMercaderias_button.Size = new Size(185, 50);
            EmpaqutarMercaderias_button.TabIndex = 3;
            EmpaqutarMercaderias_button.Text = "Empaquetar Mercaderias";
            EmpaqutarMercaderias_button.UseVisualStyleBackColor = true;
            EmpaqutarMercaderias_button.Click += button_CrearOrdenDeEntrega_Click;
            // 
            // CrearRemito_button
            // 
            CrearRemito_button.Location = new Point(115, 290);
            CrearRemito_button.Name = "CrearRemito_button";
            CrearRemito_button.Size = new Size(185, 50);
            CrearRemito_button.TabIndex = 4;
            CrearRemito_button.Text = "Crear Remito";
            CrearRemito_button.UseVisualStyleBackColor = true;
            CrearRemito_button.Click += button_CrearRemito_Click;
            // 
            // ProcesarOrdenDeEntrega_button
            // 
            ProcesarOrdenDeEntrega_button.Location = new Point(115, 360);
            ProcesarOrdenDeEntrega_button.Name = "ProcesarOrdenDeEntrega_button";
            ProcesarOrdenDeEntrega_button.Size = new Size(185, 50);
            ProcesarOrdenDeEntrega_button.TabIndex = 5;
            ProcesarOrdenDeEntrega_button.Text = "Procesar Orden de Entrega";
            ProcesarOrdenDeEntrega_button.UseVisualStyleBackColor = true;
            ProcesarOrdenDeEntrega_button.Click += button_ProcesarOrdenDeEntrega_Click;
            // 
            // Salir_button
            // 
            Salir_button.Location = new Point(171, 416);
            Salir_button.Name = "Salir_button";
            Salir_button.Size = new Size(75, 23);
            Salir_button.TabIndex = 6;
            Salir_button.Text = "Salir";
            Salir_button.UseVisualStyleBackColor = true;
            Salir_button.Click += button_Salir_Click;
            // 
            // Menu_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(Salir_button);
            Controls.Add(ProcesarOrdenDeEntrega_button);
            Controls.Add(CrearRemito_button);
            Controls.Add(EmpaqutarMercaderias_button);
            Controls.Add(ProcesarOrdenDeSeleccion_button);
            Controls.Add(CrearOrdenDeSeleccion_button);
            Controls.Add(CrearOrdenDePreparacion_button);
            Name = "Menu_form";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button CrearOrdenDePreparacion_button;
        private Button CrearOrdenDeSeleccion_button;
        private Button ProcesarOrdenDeSeleccion_button;
        private Button EmpaqutarMercaderias_button;
        private Button CrearRemito_button;
        private Button ProcesarOrdenDeEntrega_button;
        private Button Salir_button;
    }
}