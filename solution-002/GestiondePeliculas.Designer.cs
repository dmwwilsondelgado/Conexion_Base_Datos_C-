namespace solution_002
{
    partial class GestiondePeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiondePeliculas));
            panel1 = new Panel();
            btnSeguir = new Button();
            lab = new Label();
            txtIdPelicula = new TextBox();
            btnVolver = new Button();
            btnVer = new Button();
            listViewPeliculas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminarPelicula = new Button();
            btnEditarPelicula = new Button();
            btnAgregarPelicula = new Button();
            cmbxClasificacionPelicula = new ComboBox();
            numericDuracionPelicula = new NumericUpDown();
            txtGeneroPelicula = new TextBox();
            txtTituloPelicula = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDuracionPelicula).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSeguir);
            panel1.Controls.Add(lab);
            panel1.Controls.Add(txtIdPelicula);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnVer);
            panel1.Controls.Add(listViewPeliculas);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminarPelicula);
            panel1.Controls.Add(btnEditarPelicula);
            panel1.Controls.Add(btnAgregarPelicula);
            panel1.Controls.Add(cmbxClasificacionPelicula);
            panel1.Controls.Add(numericDuracionPelicula);
            panel1.Controls.Add(txtGeneroPelicula);
            panel1.Controls.Add(txtTituloPelicula);
            panel1.Location = new Point(417, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 449);
            panel1.TabIndex = 0;
            // 
            // btnSeguir
            // 
            btnSeguir.Location = new Point(548, 409);
            btnSeguir.Name = "btnSeguir";
            btnSeguir.Size = new Size(75, 23);
            btnSeguir.TabIndex = 16;
            btnSeguir.Text = "Siguiente";
            btnSeguir.UseVisualStyleBackColor = true;
            btnSeguir.Click += btnSeguir_Click;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(25, 240);
            lab.Name = "lab";
            lab.Size = new Size(116, 15);
            lab.TabIndex = 15;
            lab.Text = "Idetificacion Pelicula";
            // 
            // txtIdPelicula
            // 
            txtIdPelicula.Location = new Point(147, 237);
            txtIdPelicula.Name = "txtIdPelicula";
            txtIdPelicula.Size = new Size(35, 23);
            txtIdPelicula.TabIndex = 14;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(640, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(78, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(415, 254);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(185, 23);
            btnVer.TabIndex = 12;
            btnVer.Text = "Ver Peliculas Disponibles";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVerListadoPeliculas_Click;
            // 
            // listViewPeliculas
            // 
            listViewPeliculas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewPeliculas.Location = new Point(252, 21);
            listViewPeliculas.Name = "listViewPeliculas";
            listViewPeliculas.Size = new Size(466, 201);
            listViewPeliculas.TabIndex = 11;
            listViewPeliculas.UseCompatibleStateImageBehavior = false;
            listViewPeliculas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id_pelicula";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Titulo";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Genero";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Duracion";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Clasificacion";
            columnHeader5.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 202);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 10;
            label4.Text = "Clasificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Duracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 85);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 8;
            label2.Text = "Genero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Titulo";
            // 
            // btnEliminarPelicula
            // 
            btnEliminarPelicula.Location = new Point(81, 370);
            btnEliminarPelicula.Name = "btnEliminarPelicula";
            btnEliminarPelicula.Size = new Size(135, 23);
            btnEliminarPelicula.TabIndex = 6;
            btnEliminarPelicula.Text = "Eliminar Pelicula";
            btnEliminarPelicula.UseVisualStyleBackColor = true;
            btnEliminarPelicula.Click += btnEliminarPelicula_Click;
            // 
            // btnEditarPelicula
            // 
            btnEditarPelicula.Location = new Point(81, 325);
            btnEditarPelicula.Name = "btnEditarPelicula";
            btnEditarPelicula.Size = new Size(135, 23);
            btnEditarPelicula.TabIndex = 5;
            btnEditarPelicula.Text = "Editar Pelicula";
            btnEditarPelicula.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPelicula
            // 
            btnAgregarPelicula.Location = new Point(79, 281);
            btnAgregarPelicula.Name = "btnAgregarPelicula";
            btnAgregarPelicula.Size = new Size(137, 23);
            btnAgregarPelicula.TabIndex = 4;
            btnAgregarPelicula.Text = "Agregar Pelicula";
            btnAgregarPelicula.UseVisualStyleBackColor = true;
            btnAgregarPelicula.Click += btnAgregarPelicula_Click;
            // 
            // cmbxClasificacionPelicula
            // 
            cmbxClasificacionPelicula.FormattingEnabled = true;
            cmbxClasificacionPelicula.Location = new Point(109, 199);
            cmbxClasificacionPelicula.Name = "cmbxClasificacionPelicula";
            cmbxClasificacionPelicula.Size = new Size(121, 23);
            cmbxClasificacionPelicula.TabIndex = 3;
            // 
            // numericDuracionPelicula
            // 
            numericDuracionPelicula.Location = new Point(109, 141);
            numericDuracionPelicula.Name = "numericDuracionPelicula";
            numericDuracionPelicula.Size = new Size(120, 23);
            numericDuracionPelicula.TabIndex = 2;
            // 
            // txtGeneroPelicula
            // 
            txtGeneroPelicula.Location = new Point(109, 82);
            txtGeneroPelicula.Name = "txtGeneroPelicula";
            txtGeneroPelicula.Size = new Size(125, 23);
            txtGeneroPelicula.TabIndex = 1;
            // 
            // txtTituloPelicula
            // 
            txtTituloPelicula.Location = new Point(109, 31);
            txtTituloPelicula.Name = "txtTituloPelicula";
            txtTituloPelicula.Size = new Size(120, 23);
            txtTituloPelicula.TabIndex = 0;
            // 
            // GestiondePeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1172, 608);
            Controls.Add(panel1);
            Name = "GestiondePeliculas";
            Text = "GestiondeEntrada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDuracionPelicula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminarPelicula;
        private Button btnEditarPelicula;
        private Button btnAgregarPelicula;
        private ComboBox cmbxClasificacionPelicula;
        private NumericUpDown numericDuracionPelicula;
        private TextBox txtGeneroPelicula;
        private TextBox txtTituloPelicula;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVer;
        private ListView listViewPeliculas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnVolver;
        private Label lab;
        private TextBox txtIdPelicula;
        private Button btnSeguir;
    }
}