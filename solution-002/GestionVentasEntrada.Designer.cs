namespace solution_002
{
    partial class GestionVentasEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionVentasEntrada));
            panel1 = new Panel();
            listViewEntradas = new ListView();
            cbClientes = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            btnVender = new Button();
            label3 = new Label();
            label4 = new Label();
            btnEntradas = new Button();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnEntradas);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnVender);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbClientes);
            panel1.Controls.Add(listViewEntradas);
            panel1.Location = new Point(383, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 377);
            panel1.TabIndex = 0;
            // 
            // listViewEntradas
            // 
            listViewEntradas.Location = new Point(296, 50);
            listViewEntradas.Name = "listViewEntradas";
            listViewEntradas.Size = new Size(381, 211);
            listViewEntradas.TabIndex = 0;
            listViewEntradas.UseCompatibleStateImageBehavior = false;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(59, 82);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(121, 23);
            cbClientes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Lista de Clientes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(132, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 221);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Disponibles :";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(105, 309);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(75, 23);
            btnVender.TabIndex = 6;
            btnVender.Text = "Vender Entrada";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 113);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 7;
            label3.Text = "Selecione la Funcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 192);
            label4.Name = "label4";
            label4.Size = new Size(180, 15);
            label4.TabIndex = 8;
            label4.Text = "Selecione el Numero de Entradas";
            // 
            // btnEntradas
            // 
            btnEntradas.Location = new Point(434, 281);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(132, 23);
            btnEntradas.TabIndex = 9;
            btnEntradas.Text = "Ver Entradas";
            btnEntradas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(631, 346);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // GestionVentasEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1127, 593);
            Controls.Add(panel1);
            Name = "GestionVentasEntrada";
            Text = "GestionVentasEntrada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVender;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox cbClientes;
        private ListView listViewEntradas;
        private Label label4;
        private Label label3;
        private Button btnCerrar;
        private Button btnEntradas;
    }
}