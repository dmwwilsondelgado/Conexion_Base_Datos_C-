namespace Solution_004
{
    partial class GestiondeCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregarCliente = new Button();
            btnEditarCliente = new Button();
            btnEliminarCliente = new Button();
            listViewClientes = new ListView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnVerClientes = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "ingrese Nombre Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 2;
            label2.Text = "ingrese Documento Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 176);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 3;
            label3.Text = "ingrese  Telefono Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 140);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 4;
            label4.Text = "ingrese Correo Cliente";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(55, 231);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(147, 23);
            btnAgregarCliente.TabIndex = 5;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(55, 269);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(147, 23);
            btnEditarCliente.TabIndex = 6;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(55, 307);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(147, 23);
            btnEliminarCliente.TabIndex = 7;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // listViewClientes
            // 
            listViewClientes.Location = new Point(318, 58);
            listViewClientes.Name = "listViewClientes";
            listViewClientes.Size = new Size(430, 172);
            listViewClientes.TabIndex = 8;
            listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new Point(477, 269);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(109, 23);
            btnVerClientes.TabIndex = 15;
            btnVerClientes.Text = "Ver Clientes";
            btnVerClientes.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(713, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 16;
            btnCerrar.Text = "Close";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // GestiondeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerClientes);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listViewClientes);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "GestiondeCliente";
            Text = "GestiondeCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregarCliente;
        private Button btnEditarCliente;
        private Button btnEliminarCliente;
        private ListView listViewClientes;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnVerClientes;
        private Button btnCerrar;
    }
}