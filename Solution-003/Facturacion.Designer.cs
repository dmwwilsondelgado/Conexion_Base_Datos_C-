namespace Solution_003
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            panel1 = new Panel();
            cbCliente = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            listViewProductosSelecionados = new ListView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button1 = new Button();
            lblTotalFactura = new Label();
            btnFinalizarVenta = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnFinalizarVenta);
            panel1.Controls.Add(lblTotalFactura);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(listViewProductosSelecionados);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbCliente);
            panel1.Location = new Point(158, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 437);
            panel1.TabIndex = 0;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(161, 59);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 62);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Selecionar Cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(642, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // listViewProductosSelecionados
            // 
            listViewProductosSelecionados.Location = new Point(318, 37);
            listViewProductosSelecionados.Name = "listViewProductosSelecionados";
            listViewProductosSelecionados.Size = new Size(312, 97);
            listViewProductosSelecionados.TabIndex = 3;
            listViewProductosSelecionados.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 109);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Selecionar Prducto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(173, 159);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 162);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Cantidad Producto";
            // 
            // button1
            // 
            button1.Location = new Point(292, 339);
            button1.Name = "button1";
            button1.Size = new Size(275, 23);
            button1.TabIndex = 8;
            button1.Text = "Agregar Producto ala Factura";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(236, 384);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(427, 15);
            lblTotalFactura.TabIndex = 9;
            lblTotalFactura.Text = "............................................................................................................................................";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(364, 160);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(75, 23);
            btnFinalizarVenta.TabIndex = 10;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 556);
            Controls.Add(panel1);
            Name = "Facturacion";
            Text = "Facturacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView listViewProductosSelecionados;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox cbCliente;
        private Button btnFinalizarVenta;
        private Label lblTotalFactura;
        private Button button1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private ComboBox comboBox1;
    }
}