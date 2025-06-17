namespace Solution_004
{
    partial class GestiondeProductos
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
            textBox2 = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            btnAregarProducto = new Button();
            btnEditarProducto = new Button();
            brnEliminarProducto = new Button();
            listView1 = new ListView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnVerProductos = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 62);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre Producto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Categoria";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(154, 164);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(154, 214);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(154, 260);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // btnAregarProducto
            // 
            btnAregarProducto.Location = new Point(39, 318);
            btnAregarProducto.Name = "btnAregarProducto";
            btnAregarProducto.Size = new Size(119, 23);
            btnAregarProducto.TabIndex = 7;
            btnAregarProducto.Text = "Agregar Producto";
            btnAregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(177, 318);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(118, 23);
            btnEditarProducto.TabIndex = 8;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // brnEliminarProducto
            // 
            brnEliminarProducto.Location = new Point(107, 365);
            brnEliminarProducto.Name = "brnEliminarProducto";
            brnEliminarProducto.Size = new Size(138, 23);
            brnEliminarProducto.TabIndex = 9;
            brnEliminarProducto.Text = "Eliminar Producto";
            brnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(342, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(369, 166);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 166);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 11;
            label3.Text = "Precio Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 216);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 12;
            label4.Text = "Stcok Producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 262);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 13;
            label5.Text = "Desuento Producto";
            // 
            // btnVerProductos
            // 
            btnVerProductos.Location = new Point(479, 260);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(109, 23);
            btnVerProductos.TabIndex = 14;
            btnVerProductos.Text = "Ver Productos";
            btnVerProductos.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(691, 418);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Close";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // GestiondeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerProductos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(brnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAregarProducto);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "GestiondeProductos";
            Text = "GestiondeProductos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button btnAregarProducto;
        private Button btnEditarProducto;
        private Button brnEliminarProducto;
        private ListView listView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVerProductos;
        private Button btnCerrar;
    }
}