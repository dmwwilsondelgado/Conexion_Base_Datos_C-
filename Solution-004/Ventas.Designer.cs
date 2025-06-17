namespace Solution_004
{
    partial class Ventas
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
            cbCliente = new ComboBox();
            cbEmpleado = new ComboBox();
            cbProducto = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnFinalizarVenta = new Button();
            listViewDetalleVenta = new ListView();
            lblTotalVenta = new Label();
            btnAgregarProductoVenta = new Button();
            listViewHistorialVentas = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(152, 51);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 0;
            // 
            // cbEmpleado
            // 
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(152, 106);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(121, 23);
            cbEmpleado.TabIndex = 1;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(152, 164);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(121, 23);
            cbProducto.TabIndex = 2;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(155, 245);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 3;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(309, 382);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(121, 32);
            btnFinalizarVenta.TabIndex = 4;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // listViewDetalleVenta
            // 
            listViewDetalleVenta.Location = new Point(333, 51);
            listViewDetalleVenta.Name = "listViewDetalleVenta";
            listViewDetalleVenta.Size = new Size(389, 97);
            listViewDetalleVenta.TabIndex = 5;
            listViewDetalleVenta.UseCompatibleStateImageBehavior = false;
            listViewDetalleVenta.View = View.Details;
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Location = new Point(384, 354);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(55, 15);
            lblTotalVenta.TabIndex = 6;
            lblTotalVenta.Text = "................";
            // 
            // btnAgregarProductoVenta
            // 
            btnAgregarProductoVenta.Location = new Point(152, 193);
            btnAgregarProductoVenta.Name = "btnAgregarProductoVenta";
            btnAgregarProductoVenta.Size = new Size(123, 23);
            btnAgregarProductoVenta.TabIndex = 7;
            btnAgregarProductoVenta.Text = "Agregar Producto Venta";
            btnAgregarProductoVenta.UseVisualStyleBackColor = true;
            // 
            // listViewHistorialVentas
            // 
            listViewHistorialVentas.Location = new Point(333, 193);
            listViewHistorialVentas.Name = "listViewHistorialVentas";
            listViewHistorialVentas.Size = new Size(389, 97);
            listViewHistorialVentas.TabIndex = 8;
            listViewHistorialVentas.UseCompatibleStateImageBehavior = false;
            listViewHistorialVentas.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 54);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Selecione Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 10;
            label2.Text = "Selecionar Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 167);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 11;
            label3.Text = "Selecionar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 247);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 12;
            label4.Text = "Seleciona la Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 354);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = "Total de Venta";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewHistorialVentas);
            Controls.Add(btnAgregarProductoVenta);
            Controls.Add(lblTotalVenta);
            Controls.Add(listViewDetalleVenta);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(nudCantidad);
            Controls.Add(cbProducto);
            Controls.Add(cbEmpleado);
            Controls.Add(cbCliente);
            Name = "Ventas";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCliente;
        private ComboBox cbEmpleado;
        private ComboBox cbProducto;
        private NumericUpDown nudCantidad;
        private Button btnFinalizarVenta;
        private ListView listViewDetalleVenta;
        private Label lblTotalVenta;
        private Button btnAgregarProductoVenta;
        private ListView listViewHistorialVentas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}