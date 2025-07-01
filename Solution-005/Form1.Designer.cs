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
            txtPlaca = new TextBox();
            label1 = new Label();
            txtVehiculo = new TextBox();
            label2 = new Label();
            txtColor = new TextBox();
            label3 = new Label();
            cmbxCliente = new ComboBox();
            label4 = new Label();
            btnRegistarVehiculo = new Button();
            listViewVehiculos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label5 = new Label();
            btnClientes = new Button();
            btnVer = new Button();
            btnVerEmpleados = new Button();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(904, 172);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 23);
            txtPlaca.TabIndex = 0;
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
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(904, 227);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(121, 23);
            txtVehiculo.TabIndex = 2;
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
            // txtColor
            // 
            txtColor.Location = new Point(904, 308);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(121, 23);
            txtColor.TabIndex = 4;
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
            // cmbxCliente
            // 
            cmbxCliente.FormattingEnabled = true;
            cmbxCliente.Location = new Point(904, 372);
            cmbxCliente.Name = "cmbxCliente";
            cmbxCliente.Size = new Size(121, 23);
            cmbxCliente.TabIndex = 6;
            cmbxCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            btnRegistarVehiculo.Location = new Point(838, 492);
            btnRegistarVehiculo.Name = "btnRegistarVehiculo";
            btnRegistarVehiculo.Size = new Size(154, 63);
            btnRegistarVehiculo.TabIndex = 8;
            btnRegistarVehiculo.Text = "Registar Vehiculo";
            btnRegistarVehiculo.UseVisualStyleBackColor = true;
            btnRegistarVehiculo.Click += btnRegistarVehiculo_Click;
            // 
            // listViewVehiculos
            // 
            listViewVehiculos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewVehiculos.Location = new Point(35, 115);
            listViewVehiculos.Name = "listViewVehiculos";
            listViewVehiculos.Size = new Size(636, 336);
            listViewVehiculos.TabIndex = 11;
            listViewVehiculos.UseCompatibleStateImageBehavior = false;
            listViewVehiculos.View = View.Details;
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
            btnClientes.Location = new Point(756, 45);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(109, 63);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "Ver Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(293, 492);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(113, 63);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver Vehiculos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnVerEmpleados
            // 
            btnVerEmpleados.Location = new Point(916, 45);
            btnVerEmpleados.Name = "btnVerEmpleados";
            btnVerEmpleados.Size = new Size(109, 63);
            btnVerEmpleados.TabIndex = 15;
            btnVerEmpleados.Text = "Ver Empleados";
            btnVerEmpleados.UseVisualStyleBackColor = true;
            btnVerEmpleados.Click += btnVerEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 644);
            Controls.Add(btnVerEmpleados);
            Controls.Add(btnVer);
            Controls.Add(btnClientes);
            Controls.Add(label5);
            Controls.Add(listViewVehiculos);
            Controls.Add(btnRegistarVehiculo);
            Controls.Add(label4);
            Controls.Add(cmbxCliente);
            Controls.Add(label3);
            Controls.Add(txtColor);
            Controls.Add(label2);
            Controls.Add(txtVehiculo);
            Controls.Add(label1);
            Controls.Add(txtPlaca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaca;
        private Label label1;
        private TextBox txtVehiculo;
        private Label label2;
        private TextBox txtColor;
        private Label label3;
        private ComboBox cmbxCliente;
        private Label label4;
        private Button btnRegistarVehiculo;
        private ListView listViewVehiculos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label5;
        private Button btnClientes;
        private Button btnVer;
        private Button btnVerEmpleados;
    }
}
