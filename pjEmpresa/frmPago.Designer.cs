namespace pjEmpresa
{
    partial class frmPago
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            txtNombre = new TextBox();
            cbCategoria = new ComboBox();
            txtMinutos = new TextBox();
            txtLLamadas = new TextBox();
            label5 = new Label();
            ListViewEmpleados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRES:";
            // 
            // button1
            // 
            button1.Location = new Point(231, 155);
            button1.Name = "button1";
            button1.Size = new Size(212, 29);
            button1.TabIndex = 1;
            button1.Text = "REGISTRAR EMPLEADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "CATEGORIA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 103);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 3;
            label3.Text = "MINUTOS DE TARDANZA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 103);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 4;
            label4.Text = "N° LLAMADAS DE ATENCION:";
            // 
            // button2
            // 
            button2.Location = new Point(495, 155);
            button2.Name = "button2";
            button2.Size = new Size(212, 29);
            button2.TabIndex = 6;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(732, 27);
            txtNombre.TabIndex = 7;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbCategoria.Location = new Point(140, 61);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(221, 28);
            cbCategoria.TabIndex = 8;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(231, 100);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(40, 27);
            txtMinutos.TabIndex = 9;
            // 
            // txtLLamadas
            // 
            txtLLamadas.Location = new Point(562, 100);
            txtLLamadas.Name = "txtLLamadas";
            txtLLamadas.Size = new Size(38, 27);
            txtLLamadas.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 466);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 11;
            label5.Text = "TOTAL DE EMPLEADOS:";
            // 
            // ListViewEmpleados
            // 
            ListViewEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            ListViewEmpleados.Location = new Point(45, 199);
            ListViewEmpleados.Name = "ListViewEmpleados";
            ListViewEmpleados.Size = new Size(819, 245);
            ListViewEmpleados.TabIndex = 12;
            ListViewEmpleados.UseCompatibleStateImageBehavior = false;
            ListViewEmpleados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Categoria";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Minutos Tardanza";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Llamadas Atencion";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pago";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(810, 466);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 13;
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 510);
            Controls.Add(lblTotal);
            Controls.Add(ListViewEmpleados);
            Controls.Add(label5);
            Controls.Add(txtLLamadas);
            Controls.Add(txtMinutos);
            Controls.Add(cbCategoria);
            Controls.Add(txtNombre);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmPago";
            Text = "frmPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox txtNombre;
        private ComboBox cbCategoria;
        private TextBox txtMinutos;
        private TextBox txtLLamadas;
        private Label label5;
        private ListView ListViewEmpleados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblTotal;
    }
}