namespace Solution_001
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNombreProducto = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnGuardar = new Button();
            btnLimpiarProducto = new Button();
            btnValidar = new Button();
            label5 = new Label();
            numericStock = new NumericUpDown();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnGuardar2 = new Button();
            btnLimpiarAuditoria = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnValidarAuditoria = new Button();
            label8 = new Label();
            txtDescripcionAuditoria = new TextBox();
            label7 = new Label();
            txtAfectarAuditoria = new TextBox();
            label6 = new Label();
            txtOperacionDirigidaAuditoria = new TextBox();
            listViewGestor = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel4 = new Panel();
            btnGuardarInventarioMovimiento = new Button();
            label10 = new Label();
            txtCantidad = new TextBox();
            rdSalida = new RadioButton();
            rdEntrada = new RadioButton();
            label9 = new Label();
            btnMostrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(77, 31);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(133, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(431, 59);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Inventario";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnLimpiarProducto);
            panel1.Controls.Add(btnValidar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericStock);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Location = new Point(12, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 299);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(177, 269);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(3, 269);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(103, 23);
            btnLimpiarProducto.TabIndex = 7;
            btnLimpiarProducto.Text = "Limpiar Casillas";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(77, 219);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(137, 23);
            btnValidar.TabIndex = 6;
            btnValidar.Text = "Validar Producto";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 156);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 6;
            label5.Text = "Stock Actual ";
            // 
            // numericStock
            // 
            numericStock.Location = new Point(79, 174);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(131, 23);
            numericStock.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(77, 130);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(129, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 109);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio Producto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(77, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(129, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 13);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre del Producto";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(818, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 258);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnGuardar2);
            panel3.Controls.Add(btnLimpiarAuditoria);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(btnValidarAuditoria);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDescripcionAuditoria);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtAfectarAuditoria);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtOperacionDirigidaAuditoria);
            panel3.Location = new Point(339, 347);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 299);
            panel3.TabIndex = 4;
            // 
            // btnGuardar2
            // 
            btnGuardar2.Location = new Point(210, 269);
            btnGuardar2.Name = "btnGuardar2";
            btnGuardar2.Size = new Size(75, 23);
            btnGuardar2.TabIndex = 9;
            btnGuardar2.Text = "Guardar";
            btnGuardar2.UseVisualStyleBackColor = true;
            btnGuardar2.Click += btnGuardar2_Click;
            // 
            // btnLimpiarAuditoria
            // 
            btnLimpiarAuditoria.Location = new Point(3, 269);
            btnLimpiarAuditoria.Name = "btnLimpiarAuditoria";
            btnLimpiarAuditoria.Size = new Size(103, 23);
            btnLimpiarAuditoria.TabIndex = 7;
            btnLimpiarAuditoria.Text = "Limpiar Casillas";
            btnLimpiarAuditoria.UseVisualStyleBackColor = true;
            btnLimpiarAuditoria.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(54, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnValidarAuditoria
            // 
            btnValidarAuditoria.Location = new Point(96, 219);
            btnValidarAuditoria.Name = "btnValidarAuditoria";
            btnValidarAuditoria.Size = new Size(114, 23);
            btnValidarAuditoria.TabIndex = 6;
            btnValidarAuditoria.Text = "Validar Auditoria";
            btnValidarAuditoria.UseVisualStyleBackColor = true;
            btnValidarAuditoria.Click += btnValidarAuditoria_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 115);
            label8.Name = "label8";
            label8.Size = new Size(142, 15);
            label8.TabIndex = 5;
            label8.Text = "Descricion de la Auditoria";
            // 
            // txtDescripcionAuditoria
            // 
            txtDescripcionAuditoria.Location = new Point(88, 142);
            txtDescripcionAuditoria.Name = "txtDescripcionAuditoria";
            txtDescripcionAuditoria.Size = new Size(122, 23);
            txtDescripcionAuditoria.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 61);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 3;
            label7.Text = "Tabla a Afectar ";
            // 
            // txtAfectarAuditoria
            // 
            txtAfectarAuditoria.Location = new Point(88, 79);
            txtAfectarAuditoria.Name = "txtAfectarAuditoria";
            txtAfectarAuditoria.Size = new Size(122, 23);
            txtAfectarAuditoria.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 13);
            label6.Name = "label6";
            label6.Size = new Size(161, 15);
            label6.TabIndex = 1;
            label6.Text = "Operacion ala que va dirigida";
            // 
            // txtOperacionDirigidaAuditoria
            // 
            txtOperacionDirigidaAuditoria.Location = new Point(88, 31);
            txtOperacionDirigidaAuditoria.Name = "txtOperacionDirigidaAuditoria";
            txtOperacionDirigidaAuditoria.Size = new Size(122, 23);
            txtOperacionDirigidaAuditoria.TabIndex = 0;
            txtOperacionDirigidaAuditoria.TextChanged += textBox1_TextChanged;
            // 
            // listViewGestor
            // 
            listViewGestor.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewGestor.Location = new Point(17, 92);
            listViewGestor.Name = "listViewGestor";
            listViewGestor.Size = new Size(770, 212);
            listViewGestor.TabIndex = 5;
            listViewGestor.UseCompatibleStateImageBehavior = false;
            listViewGestor.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id_producto";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "descripcion";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "precio";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "stock";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "operacion";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tabla";
            columnHeader6.Width = 120;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(btnGuardarInventarioMovimiento);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtCantidad);
            panel4.Controls.Add(rdSalida);
            panel4.Controls.Add(rdEntrada);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(675, 400);
            panel4.Name = "panel4";
            panel4.Size = new Size(386, 246);
            panel4.TabIndex = 6;
            // 
            // btnGuardarInventarioMovimiento
            // 
            btnGuardarInventarioMovimiento.Location = new Point(141, 166);
            btnGuardarInventarioMovimiento.Name = "btnGuardarInventarioMovimiento";
            btnGuardarInventarioMovimiento.Size = new Size(127, 23);
            btnGuardarInventarioMovimiento.TabIndex = 6;
            btnGuardarInventarioMovimiento.Text = "Guardar Movimiento";
            btnGuardarInventarioMovimiento.UseVisualStyleBackColor = true;
            btnGuardarInventarioMovimiento.Click += btnGuardarInventarioMovimiento_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 101);
            label10.Name = "label10";
            label10.Size = new Size(144, 15);
            label10.TabIndex = 4;
            label10.Text = "Cantidad de Movimientos";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(199, 95);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 3;
            // 
            // rdSalida
            // 
            rdSalida.AutoSize = true;
            rdSalida.Location = new Point(55, 75);
            rdSalida.Name = "rdSalida";
            rdSalida.Size = new Size(55, 19);
            rdSalida.TabIndex = 2;
            rdSalida.TabStop = true;
            rdSalida.Text = "salida";
            rdSalida.UseVisualStyleBackColor = true;
            // 
            // rdEntrada
            // 
            rdEntrada.AutoSize = true;
            rdEntrada.Location = new Point(55, 50);
            rdEntrada.Name = "rdEntrada";
            rdEntrada.Size = new Size(65, 19);
            rdEntrada.TabIndex = 1;
            rdEntrada.TabStop = true;
            rdEntrada.Text = "entrada";
            rdEntrada.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 21);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 0;
            label9.Text = "Panel de Movimientos ";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(323, 310);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(124, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1101, 678);
            Controls.Add(btnMostrar);
            Controls.Add(panel4);
            Controls.Add(listViewGestor);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private ListView listViewGestor;
        private Label label5;
        private NumericUpDown numericStock;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private Button btnValidar;
        private Label label6;
        private TextBox txtOperacionDirigidaAuditoria;
        private Label label7;
        private TextBox txtAfectarAuditoria;
        private Button btnLimpiarProducto;
        private Button btnLimpiarAuditoria;
        private Button btnValidarAuditoria;
        private Label label8;
        private TextBox txtDescripcionAuditoria;
        private Panel panel4;
        private RadioButton rdSalida;
        private RadioButton rdEntrada;
        private Label label9;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnGuardarInventarioMovimiento;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private TextBox txtCantidad;
        private Button btnGuardar;
        private Button btnGuardar2;
        private Button btnMostrar;
    }
}
