namespace Solution_005
{
    partial class ClientesFrecuentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesFrecuentes));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnRegistarCliente = new Button();
            label4 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtDocumento = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            txtCorreo = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(95, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(636, 203);
            listView1.TabIndex = 23;
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
            // btnRegistarCliente
            // 
            btnRegistarCliente.Location = new Point(542, 451);
            btnRegistarCliente.Name = "btnRegistarCliente";
            btnRegistarCliente.Size = new Size(154, 63);
            btnRegistarCliente.TabIndex = 20;
            btnRegistarCliente.Text = "Registar Cliente ";
            btnRegistarCliente.UseVisualStyleBackColor = true;
            btnRegistarCliente.Click += btnRegistarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(801, 294);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(801, 227);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(957, 227);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(121, 23);
            txtTelefono.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(801, 154);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 15;
            label2.Text = "Documento Cliente";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(957, 146);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(121, 23);
            txtDocumento.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(799, 94);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre Cliente";
            // 
            // txtName
            // 
            txtName.Location = new Point(957, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(957, 291);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(121, 23);
            txtCorreo.TabIndex = 24;
            // 
            // ClientesFrecuentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1172, 599);
            Controls.Add(txtCorreo);
            Controls.Add(listView1);
            Controls.Add(btnRegistarCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtDocumento);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "ClientesFrecuentes";
            Text = "ClientesFrecuentes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnRegistarCliente;
        private Label label4;
        private Label label3;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtDocumento;
        private Label label1;
        private TextBox txtName;
        private TextBox txtCorreo;
    }
}