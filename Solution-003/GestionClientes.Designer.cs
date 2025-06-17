namespace Solution_003
{
    partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnRegistrarCliente = new Button();
            button2 = new Button();
            button3 = new Button();
            btnCerrarSesision = new Button();
            btnVerRegistros = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(110, 218);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(126, 23);
            btnRegistrarCliente.TabIndex = 4;
            btnRegistrarCliente.Text = "Registra Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(110, 268);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 5;
            button2.Text = "Buscar  Por Nombre";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(110, 313);
            button3.Name = "button3";
            button3.Size = new Size(126, 23);
            button3.TabIndex = 6;
            button3.Text = "Buscar Por Id";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesision
            // 
            btnCerrarSesision.Location = new Point(519, 313);
            btnCerrarSesision.Name = "btnCerrarSesision";
            btnCerrarSesision.Size = new Size(75, 23);
            btnCerrarSesision.TabIndex = 7;
            btnCerrarSesision.Text = "Close";
            btnCerrarSesision.UseVisualStyleBackColor = true;
            // 
            // btnVerRegistros
            // 
            btnVerRegistros.Location = new Point(382, 257);
            btnVerRegistros.Name = "btnVerRegistros";
            btnVerRegistros.Size = new Size(128, 23);
            btnVerRegistros.TabIndex = 8;
            btnVerRegistros.Text = "Ver Registros";
            btnVerRegistros.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Identificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 112);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 162);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Correo";
            // 
            // listView1
            // 
            listView1.Location = new Point(260, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(391, 211);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnCerrarSesision);
            panel1.Controls.Add(btnVerRegistros);
            panel1.Controls.Add(btnRegistrarCliente);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(67, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 354);
            panel1.TabIndex = 14;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "GestionClientes";
            Text = "GestionClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnRegistrarCliente;
        private Button button2;
        private Button button3;
        private Button btnCerrarSesision;
        private Button btnVerRegistros;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private Panel panel1;
    }
}