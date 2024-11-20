using System.Windows.Forms;

namespace GrupoF.Prototipo._1._1_Reportes_OP
{
    partial class ReporteOP_form
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
            textBox1 = new TextBox();
            estadosOp = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            listaOps = new ListView();
            ID = new ColumnHeader();
            Estado = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Cliente = new ColumnHeader();
            Deposito = new ColumnHeader();
            Fecha_Emision = new ColumnHeader();
            Fecha_Entrega = new ColumnHeader();
            Transportista = new ColumnHeader();
            Ver_Mercaderias = new ColumnHeader();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            prioridadLista = new ComboBox();
            label10 = new Label();
            detalle = new TextBox();
            VerItems = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // estadosOp
            // 
            estadosOp.DropDownStyle = ComboBoxStyle.DropDownList;
            estadosOp.FormattingEnabled = true;
            estadosOp.Location = new Point(165, 28);
            estadosOp.Name = "estadosOp";
            estadosOp.Size = new Size(121, 23);
            estadosOp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "ID Op";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Estado Op";
            // 
            // listaOps
            // 
            listaOps.Columns.AddRange(new ColumnHeader[] { ID, Estado, Prioridad, Cliente, Deposito, Fecha_Emision, Fecha_Entrega, Transportista, Ver_Mercaderias });
            listaOps.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaOps.Location = new Point(12, 135);
            listaOps.Name = "listaOps";
            listaOps.Size = new Size(1585, 443);
            listaOps.TabIndex = 4;
            listaOps.UseCompatibleStateImageBehavior = false;
            listaOps.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // Fecha_Emision
            // 
            Fecha_Emision.Text = "Fecha Emision";
            Fecha_Emision.Width = 120;
            // 
            // Fecha_Entrega
            // 
            Fecha_Entrega.Text = "Fecha Entrega";
            Fecha_Entrega.Width = 120;
            // 
            // Transportista
            // 
            Transportista.Text = "Transportista";
            Transportista.Width = 100;
            // 
            // Ver_Mercaderias
            // 
            Ver_Mercaderias.Text = "Ver Mercaderias";
            Ver_Mercaderias.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(1522, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(323, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(323, 81);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(232, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Desde Emision";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 63);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 9;
            label4.Text = "Hasta Emision";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(632, 63);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = "Hasta Entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(630, 5);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Desde Entrega";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(630, 81);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(232, 23);
            dateTimePicker3.TabIndex = 11;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(630, 28);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(233, 23);
            dateTimePicker4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1122, 12);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 17;
            label7.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(946, 11);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 16;
            label8.Text = "Prioridad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1122, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1295, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1295, 12);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 19;
            label9.Text = "DNI Transportista";
            // 
            // prioridadLista
            // 
            prioridadLista.AllowDrop = true;
            prioridadLista.DropDownStyle = ComboBoxStyle.DropDownList;
            prioridadLista.FormattingEnabled = true;
            prioridadLista.Items.AddRange(new object[] { "Prioritario", "No Prioritario" });
            prioridadLista.Location = new Point(946, 31);
            prioridadLista.Name = "prioridadLista";
            prioridadLista.Size = new Size(121, 23);
            prioridadLista.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1393, 590);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 22;
            label10.Text = "Detalles Op";
            // 
            // detalle
            // 
            detalle.Location = new Point(1393, 608);
            detalle.Name = "detalle";
            detalle.Size = new Size(100, 23);
            detalle.TabIndex = 24;
            // 
            // VerItems
            // 
            VerItems.Location = new Point(1522, 608);
            VerItems.Name = "VerItems";
            VerItems.Size = new Size(75, 23);
            VerItems.TabIndex = 23;
            VerItems.Text = "Ver";
            VerItems.UseVisualStyleBackColor = true;
            VerItems.Click += VerItems_Click;
            // 
            // ReporteOP_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 644);
            Controls.Add(detalle);
            Controls.Add(VerItems);
            Controls.Add(label10);
            Controls.Add(prioridadLista);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(listaOps);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(estadosOp);
            Controls.Add(textBox1);
            Name = "ReporteOP_form";
            Text = "ReporteOP_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox estadosOp;
        private Label label1;
        private Label label2;
        private ListView listaOps;
        private ColumnHeader ID;
        private ColumnHeader Estado;
        private ColumnHeader Prioridad;
        private ColumnHeader Cliente;
        private ColumnHeader Deposito;
        private ColumnHeader Fecha_Emision;
        private ColumnHeader Fecha_Entrega;
        private ColumnHeader Transportista;
        private ColumnHeader Ver_Mercaderias;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label9;
        private ComboBox prioridadLista;
        private Label label10;
        private TextBox textBox2;
        private Button VerItems;
        private TextBox detalle;
    }
}