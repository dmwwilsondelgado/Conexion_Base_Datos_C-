namespace Solution_006
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
            txtIdEmpleado = new TextBox();
            txtNombre = new TextBox();
            dtpFecha = new DateTimePicker();
            dtpHoraEntrada = new DateTimePicker();
            dtpHoraSalida = new DateTimePicker();
            cmbTipoRegistro = new ComboBox();
            btnRegistrar = new Button();
            btnJustificantes = new Button();
            btnCalcularDescuentos = new Button();
            dgvAsistencias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            SuspendLayout();
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(30, 30);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.PlaceholderText = "ID Empleado";
            txtIdEmpleado.Size = new Size(120, 23);
            txtIdEmpleado.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(30, 70);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.Location = new Point(30, 110);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Size = new Size(100, 23);
            dtpHoraEntrada.TabIndex = 3;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(140, 110);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(100, 23);
            dtpHoraSalida.TabIndex = 4;
            // 
            // cmbTipoRegistro
            // 
            cmbTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoRegistro.Items.AddRange(new object[] { "Entrada", "Salida" });
            cmbTipoRegistro.Location = new Point(250, 110);
            cmbTipoRegistro.Name = "cmbTipoRegistro";
            cmbTipoRegistro.Size = new Size(110, 23);
            cmbTipoRegistro.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(30, 150);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 30);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnJustificantes
            // 
            btnJustificantes.Location = new Point(140, 150);
            btnJustificantes.Name = "btnJustificantes";
            btnJustificantes.Size = new Size(120, 30);
            btnJustificantes.TabIndex = 7;
            btnJustificantes.Text = "Ver Justificantes";
            btnJustificantes.Click += btnJustificantes_Click;
            // 
            // btnCalcularDescuentos
            // 
            btnCalcularDescuentos.Location = new Point(270, 150);
            btnCalcularDescuentos.Name = "btnCalcularDescuentos";
            btnCalcularDescuentos.Size = new Size(130, 30);
            btnCalcularDescuentos.TabIndex = 8;
            btnCalcularDescuentos.Text = "Calcular Descuentos";
            btnCalcularDescuentos.Click += btnCalcularDescuentos_Click;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.Location = new Point(30, 200);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.Size = new Size(500, 200);
            dgvAsistencias.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 431);
            Controls.Add(txtIdEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(dtpFecha);
            Controls.Add(dtpHoraEntrada);
            Controls.Add(dtpHoraSalida);
            Controls.Add(cmbTipoRegistro);
            Controls.Add(btnRegistrar);
            Controls.Add(btnJustificantes);
            Controls.Add(btnCalcularDescuentos);
            Controls.Add(dgvAsistencias);
            Name = "Form1";
            Text = "Control de Asistencia";
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.ComboBox cmbTipoRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnJustificantes;
        private System.Windows.Forms.Button btnCalcularDescuentos;
        private System.Windows.Forms.DataGridView dgvAsistencias;
    }
}
