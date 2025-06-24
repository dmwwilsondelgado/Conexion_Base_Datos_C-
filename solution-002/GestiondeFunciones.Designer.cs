namespace solution_002
{
    partial class GestiondeFunciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiondeFunciones));
            panel1 = new Panel();
            btnSeguir = new Button();
            btnVolver = new Button();
            btnVerFunciones = new Button();
            listViewFunciones = new ListView();
            btnEliminarFuncion = new Button();
            btnEditarFuncion = new Button();
            btnAgregarFuncion = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbSalas = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cbPeliculas = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSeguir);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnVerFunciones);
            panel1.Controls.Add(listViewFunciones);
            panel1.Controls.Add(btnEliminarFuncion);
            panel1.Controls.Add(btnEditarFuncion);
            panel1.Controls.Add(btnAgregarFuncion);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbSalas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbPeliculas);
            panel1.Location = new Point(415, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 399);
            panel1.TabIndex = 0;
            // 
            // btnSeguir
            // 
            btnSeguir.Location = new Point(470, 369);
            btnSeguir.Name = "btnSeguir";
            btnSeguir.Size = new Size(75, 23);
            btnSeguir.TabIndex = 11;
            btnSeguir.Text = "Siguiente";
            btnSeguir.UseVisualStyleBackColor = true;
            btnSeguir.Click += btnSeguir_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(551, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVerFunciones
            // 
            btnVerFunciones.Location = new Point(343, 293);
            btnVerFunciones.Name = "btnVerFunciones";
            btnVerFunciones.Size = new Size(187, 23);
            btnVerFunciones.TabIndex = 9;
            btnVerFunciones.Text = "Ver Funciones Disponibles";
            btnVerFunciones.UseVisualStyleBackColor = true;
            // 
            // listViewFunciones
            // 
            listViewFunciones.Location = new Point(230, 59);
            listViewFunciones.Name = "listViewFunciones";
            listViewFunciones.Size = new Size(384, 218);
            listViewFunciones.TabIndex = 8;
            listViewFunciones.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarFuncion
            // 
            btnEliminarFuncion.Location = new Point(20, 319);
            btnEliminarFuncion.Name = "btnEliminarFuncion";
            btnEliminarFuncion.Size = new Size(186, 23);
            btnEliminarFuncion.TabIndex = 7;
            btnEliminarFuncion.Text = "Eliminar Funcion";
            btnEliminarFuncion.UseVisualStyleBackColor = true;
            // 
            // btnEditarFuncion
            // 
            btnEditarFuncion.Location = new Point(20, 276);
            btnEditarFuncion.Name = "btnEditarFuncion";
            btnEditarFuncion.Size = new Size(189, 23);
            btnEditarFuncion.TabIndex = 6;
            btnEditarFuncion.Text = "Editar Funcion ";
            btnEditarFuncion.UseVisualStyleBackColor = true;
            btnEditarFuncion.Click += btnEditarFuncion_Click;
            // 
            // btnAgregarFuncion
            // 
            btnAgregarFuncion.Location = new Point(17, 229);
            btnAgregarFuncion.Name = "btnAgregarFuncion";
            btnAgregarFuncion.Size = new Size(192, 23);
            btnAgregarFuncion.TabIndex = 5;
            btnAgregarFuncion.Text = "Agregar Funcion ";
            btnAgregarFuncion.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(404, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // cbSalas
            // 
            cbSalas.FormattingEnabled = true;
            cbSalas.Location = new Point(72, 156);
            cbSalas.Name = "cbSalas";
            cbSalas.Size = new Size(121, 23);
            cbSalas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 124);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Selecione Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 43);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecione Pelicula";
            // 
            // cbPeliculas
            // 
            cbPeliculas.FormattingEnabled = true;
            cbPeliculas.Location = new Point(71, 79);
            cbPeliculas.Name = "cbPeliculas";
            cbPeliculas.Size = new Size(121, 23);
            cbPeliculas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 22);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Funciones";
            // 
            // GestiondeFunciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1090, 594);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "GestiondeFunciones";
            Text = "GestiondeFunciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListView listViewFunciones;
        private Button btnEliminarFuncion;
        private Button btnEditarFuncion;
        private Button btnAgregarFuncion;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbSalas;
        private Label label3;
        private Label label2;
        private ComboBox cbPeliculas;
        private Label label1;
        private Button btnVolver;
        private Button btnVerFunciones;
        private Button btnSeguir;
    }
}