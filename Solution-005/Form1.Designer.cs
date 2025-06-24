namespace Solution_005
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            btnRegistarVehiculo = new Button();
            btnEditarVehiculo = new Button();
            btnEliminarVehiculo = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label5 = new Label();
            btnClientes = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(904, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 175);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Placa de Vehiculo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(904, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(756, 235);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Vehiculo";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(904, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 308);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Color de Vehiculo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(904, 372);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 375);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 7;
            label4.Text = "Selecione Cliente Frecuente";
            // 
            // btnRegistarVehiculo
            // 
            btnRegistarVehiculo.Location = new Point(199, 492);
            btnRegistarVehiculo.Name = "btnRegistarVehiculo";
            btnRegistarVehiculo.Size = new Size(154, 63);
            btnRegistarVehiculo.TabIndex = 8;
            btnRegistarVehiculo.Text = "Registar Vehiculo";
            btnRegistarVehiculo.UseVisualStyleBackColor = true;
            btnRegistarVehiculo.Click += btnRegistarVehiculo_Click;
            // 
            // btnEditarVehiculo
            // 
            btnEditarVehiculo.Location = new Point(538, 492);
            btnEditarVehiculo.Name = "btnEditarVehiculo";
            btnEditarVehiculo.Size = new Size(133, 63);
            btnEditarVehiculo.TabIndex = 9;
            btnEditarVehiculo.Text = "Editar Vehiculo";
            btnEditarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVehiculo
            // 
            btnEliminarVehiculo.Location = new Point(854, 492);
            btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            btnEliminarVehiculo.Size = new Size(115, 63);
            btnEliminarVehiculo.TabIndex = 10;
            btnEliminarVehiculo.Text = "Eliminar Vehiculo";
            btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(35, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(636, 336);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Placa";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Color";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cliente";
            columnHeader4.Width = 160;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 33F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 37);
            label5.Name = "label5";
            label5.Size = new Size(275, 53);
            label5.TabIndex = 12;
            label5.Text = "Intelli Park ";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(953, 45);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(109, 63);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "Ver Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 644);
            Controls.Add(btnClientes);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(btnEliminarVehiculo);
            Controls.Add(btnEditarVehiculo);
            Controls.Add(btnRegistarVehiculo);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button btnRegistarVehiculo;
        private Button btnEditarVehiculo;
        private Button btnEliminarVehiculo;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label5;
        private Button btnClientes;
    }
}
