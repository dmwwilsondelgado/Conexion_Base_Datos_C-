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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtPlaca.Font = new Font("Segoe UI", 10F);
            txtPlaca.Location = new Point(944, 195);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 25);
            txtPlaca.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(746, 198);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 1;
            label1.Text = "Placa de Vehiculo";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Font = new Font("Segoe UI", 10F);
            txtVehiculo.Location = new Point(944, 257);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(121, 25);
            txtVehiculo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(746, 261);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 3;
            label2.Text = "Tipo de Vehiculo";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10F);
            txtColor.Location = new Point(944, 349);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(121, 25);
            txtColor.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(748, 349);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 5;
            label3.Text = "Color de Vehiculo";
            // 
            // cmbxCliente
            // 
            cmbxCliente.Font = new Font("Segoe UI", 10F);
            cmbxCliente.FormattingEnabled = true;
            cmbxCliente.Location = new Point(944, 422);
            cmbxCliente.Name = "cmbxCliente";
            cmbxCliente.Size = new Size(121, 25);
            cmbxCliente.TabIndex = 6;
            cmbxCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(746, 425);
            label4.Name = "label4";
            label4.Size = new Size(175, 19);
            label4.TabIndex = 7;
            label4.Text = "Selecione Cliente Frecuente";
            // 
            // btnRegistarVehiculo
            // 
            btnRegistarVehiculo.Location = new Point(517, 487);
            btnRegistarVehiculo.Name = "btnRegistarVehiculo";
            btnRegistarVehiculo.Size = new Size(154, 71);
            btnRegistarVehiculo.TabIndex = 8;
            btnRegistarVehiculo.Text = "Registar Vehiculo";
            btnRegistarVehiculo.UseVisualStyleBackColor = true;
            btnRegistarVehiculo.Click += btnRegistarVehiculo_Click;
            // 
            // listViewVehiculos
            // 
            listViewVehiculos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewVehiculos.Location = new Point(35, 130);
            listViewVehiculos.Name = "listViewVehiculos";
            listViewVehiculos.Size = new Size(636, 165);
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
            label5.Location = new Point(233, 23);
            label5.Name = "label5";
            label5.Size = new Size(275, 53);
            label5.TabIndex = 12;
            label5.Text = "Intelli Park ";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(732, 53);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(109, 71);
            btnClientes.TabIndex = 13;
            btnClientes.Text = "Ver Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(296, 322);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(113, 71);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver Vehiculos";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnVerEmpleados
            // 
            btnVerEmpleados.Location = new Point(930, 53);
            btnVerEmpleados.Name = "btnVerEmpleados";
            btnVerEmpleados.Size = new Size(109, 71);
            btnVerEmpleados.TabIndex = 15;
            btnVerEmpleados.Text = "Ver Empleados";
            btnVerEmpleados.UseVisualStyleBackColor = true;
            btnVerEmpleados.Click += btnVerEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1132, 639);
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
            Font = new Font("Segoe UI", 10F);
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
