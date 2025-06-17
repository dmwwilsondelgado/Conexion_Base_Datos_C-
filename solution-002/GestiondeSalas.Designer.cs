namespace solution_002
{
    partial class GestiondeSalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestiondeSalas));
            panel1 = new Panel();
            txtNombreSala = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericCapacidaSala = new NumericUpDown();
            label3 = new Label();
            btnAgregar = new Button();
            btnEditarSala = new Button();
            btnEliminarSala = new Button();
            btnVerSalasa = new Button();
            btnVolver = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidaSala).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnVerSalasa);
            panel1.Controls.Add(btnEliminarSala);
            panel1.Controls.Add(btnEditarSala);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericCapacidaSala);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombreSala);
            panel1.Location = new Point(429, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 365);
            panel1.TabIndex = 0;
            // 
            // txtNombreSala
            // 
            txtNombreSala.Location = new Point(127, 62);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(120, 23);
            txtNombreSala.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Sala";
            // 
            // numericCapacidaSala
            // 
            numericCapacidaSala.Location = new Point(127, 121);
            numericCapacidaSala.Name = "numericCapacidaSala";
            numericCapacidaSala.Size = new Size(120, 23);
            numericCapacidaSala.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 123);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Capacidad";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(59, 187);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Sala";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditarSala
            // 
            btnEditarSala.Location = new Point(59, 230);
            btnEditarSala.Name = "btnEditarSala";
            btnEditarSala.Size = new Size(145, 23);
            btnEditarSala.TabIndex = 6;
            btnEditarSala.Text = "Editar Sala";
            btnEditarSala.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSala
            // 
            btnEliminarSala.Location = new Point(59, 277);
            btnEliminarSala.Name = "btnEliminarSala";
            btnEliminarSala.Size = new Size(145, 23);
            btnEliminarSala.TabIndex = 7;
            btnEliminarSala.Text = "Eliminar Sala";
            btnEliminarSala.UseVisualStyleBackColor = true;
            // 
            // btnVerSalasa
            // 
            btnVerSalasa.Location = new Point(404, 259);
            btnVerSalasa.Name = "btnVerSalasa";
            btnVerSalasa.Size = new Size(145, 23);
            btnVerSalasa.TabIndex = 8;
            btnVerSalasa.Text = "Ver Salas";
            btnVerSalasa.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(498, 325);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(163, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(287, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(348, 227);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id_sala";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Capacidad";
            columnHeader3.Width = 120;
            // 
            // GestiondeSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1167, 633);
            Controls.Add(panel1);
            Name = "GestiondeSalas";
            Text = "GestiondeSalas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCapacidaSala).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnVolver;
        private Button btnVerSalasa;
        private Button btnEliminarSala;
        private Button btnEditarSala;
        private Button btnAgregar;
        private Label label3;
        private NumericUpDown numericCapacidaSala;
        private Label label2;
        private Label label1;
        private TextBox txtNombreSala;
    }
}