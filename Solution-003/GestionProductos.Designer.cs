namespace Solution_003
{
    partial class GestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProductos));
            panel1 = new Panel();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numericStock = new NumericUpDown();
            label4 = new Label();
            numericGarantia = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            txtMarca = new TextBox();
            txtTipo = new TextBox();
            txtPrecio = new TextBox();
            btnAgregarElec = new Button();
            btnEditarElec = new Button();
            btnEliminarElec = new Button();
            listViewElectrodomesticos = new ListView();
            btnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGarantia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(listViewElectrodomesticos);
            panel1.Controls.Add(btnEliminarElec);
            panel1.Controls.Add(btnEditarElec);
            panel1.Controls.Add(btnAgregarElec);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtTipo);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numericGarantia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericStock);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(179, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 358);
            panel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 136);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo";
            // 
            // numericStock
            // 
            numericStock.Location = new Point(157, 222);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(120, 23);
            numericStock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 181);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio";
            // 
            // numericGarantia
            // 
            numericGarantia.Location = new Point(157, 258);
            numericGarantia.Name = "numericGarantia";
            numericGarantia.Size = new Size(120, 23);
            numericGarantia.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 224);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 266);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 8;
            label6.Text = "años Garantia";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(156, 105);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 9;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(157, 144);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(120, 23);
            txtTipo.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 187);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 11;
            // 
            // btnAgregarElec
            // 
            btnAgregarElec.Location = new Point(325, 194);
            btnAgregarElec.Name = "btnAgregarElec";
            btnAgregarElec.Size = new Size(156, 23);
            btnAgregarElec.TabIndex = 12;
            btnAgregarElec.Text = "Agregar Electrodomestico";
            btnAgregarElec.UseVisualStyleBackColor = true;
            // 
            // btnEditarElec
            // 
            btnEditarElec.Location = new Point(325, 240);
            btnEditarElec.Name = "btnEditarElec";
            btnEditarElec.Size = new Size(156, 23);
            btnEditarElec.TabIndex = 13;
            btnEditarElec.Text = "Editar Electrodomestico";
            btnEditarElec.UseVisualStyleBackColor = true;
            // 
            // btnEliminarElec
            // 
            btnEliminarElec.Location = new Point(325, 283);
            btnEliminarElec.Name = "btnEliminarElec";
            btnEliminarElec.Size = new Size(156, 23);
            btnEliminarElec.TabIndex = 14;
            btnEliminarElec.Text = "Eliminar Eletrodomestico";
            btnEliminarElec.UseVisualStyleBackColor = true;
            // 
            // listViewElectrodomesticos
            // 
            listViewElectrodomesticos.Location = new Point(309, 50);
            listViewElectrodomesticos.Name = "listViewElectrodomesticos";
            listViewElectrodomesticos.Size = new Size(396, 117);
            listViewElectrodomesticos.TabIndex = 15;
            listViewElectrodomesticos.UseCompatibleStateImageBehavior = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(656, 328);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 16;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // GestionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 521);
            Controls.Add(panel1);
            Name = "GestionProductos";
            Text = "GestionProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGarantia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private NumericUpDown numericGarantia;
        private Label label4;
        private NumericUpDown numericStock;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Button btnVolver;
        private ListView listViewElectrodomesticos;
        private Button btnEliminarElec;
        private Button btnEditarElec;
        private Button btnAgregarElec;
        private TextBox txtPrecio;
        private TextBox txtTipo;
        private TextBox txtMarca;
        private Label label6;
    }
}