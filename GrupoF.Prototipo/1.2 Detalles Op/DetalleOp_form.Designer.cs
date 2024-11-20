namespace GrupoF.Prototipo._1._2_Detalles_Op
{
    partial class DetalleOp_form
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
            listaItemsOp = new ListView();
            Mercaderia = new ColumnHeader();
            Cantidad = new ColumnHeader();
            ID_OP = new ColumnHeader();
            Deposito = new ColumnHeader();
            SuspendLayout();
            // 
            // listaItemsOp
            // 
            listaItemsOp.Columns.AddRange(new ColumnHeader[] { ID_OP, Deposito, Mercaderia, Cantidad });
            listaItemsOp.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaItemsOp.Location = new Point(12, 12);
            listaItemsOp.Name = "listaItemsOp";
            listaItemsOp.Size = new Size(776, 430);
            listaItemsOp.TabIndex = 5;
            listaItemsOp.UseCompatibleStateImageBehavior = false;
            listaItemsOp.View = View.Details;
            // 
            // Mercaderia
            // 
            Mercaderia.Text = "Mercaderia";
            Mercaderia.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // ID_OP
            // 
            ID_OP.Text = "ID OP";
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 80;
            // 
            // DetalleOp_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listaItemsOp);
            Name = "DetalleOp_form";
            Text = "DetalleOp_form";
            ResumeLayout(false);
        }

        #endregion

        private ListView listaItemsOp;
        private ColumnHeader Mercaderia;
        private ColumnHeader Cantidad;
        private ColumnHeader ID_OP;
        private ColumnHeader Deposito;
    }
}