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
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            listView1 = new ListView();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            numericStock = new NumericUpDown();
            label5 = new Label();
            btnGuardar = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(76, 25);
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericStock);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Location = new Point(34, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 299);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 7);
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
            panel2.Location = new Point(830, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 273);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(362, 347);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 299);
            panel3.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Location = new Point(171, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(765, 212);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 51);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(76, 77);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(129, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 103);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(85, 124);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // numericStock
            // 
            numericStock.Location = new Point(85, 168);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(120, 23);
            numericStock.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 150);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 6;
            label5.Text = "Stock Actual ";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(76, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar Producto";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // textBox2
            // 
            textBox2.Location = new Point(88, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 2;
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
            // textBox3
            // 
            textBox3.Location = new Point(88, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 4;
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
            // button1
            // 
            button1.Location = new Point(110, 263);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Limpiar Casillas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(112, 216);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Guardar Auditoria";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(125, 251);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Limpiar Casillas";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1177, 678);
            Controls.Add(listView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
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
        private ListView listView1;
        private Label label5;
        private NumericUpDown numericStock;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private Button btnGuardar;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label8;
        private TextBox textBox3;
    }
}
