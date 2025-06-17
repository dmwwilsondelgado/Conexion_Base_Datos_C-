namespace Solution_004
{
    partial class GestiondeEmpleados
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
            btnCerrar = new Button();
            btnVerEmpleados = new Button();
            txtTelefonoEmpleado = new TextBox();
            txtCorreoEmpleado = new TextBox();
            txtDocumentoEmpleado = new TextBox();
            listViewEmpleados = new ListView();
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombreEmpleado = new TextBox();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(700, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 30;
            btnCerrar.Text = "Close";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnVerEmpleados
            // 
            btnVerEmpleados.Location = new Point(466, 246);
            btnVerEmpleados.Name = "btnVerEmpleados";
            btnVerEmpleados.Size = new Size(109, 23);
            btnVerEmpleados.TabIndex = 29;
            btnVerEmpleados.Text = "Ver Empleados";
            btnVerEmpleados.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Location = new Point(178, 153);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(100, 23);
            txtTelefonoEmpleado.TabIndex = 28;
            // 
            // txtCorreoEmpleado
            // 
            txtCorreoEmpleado.Location = new Point(178, 117);
            txtCorreoEmpleado.Name = "txtCorreoEmpleado";
            txtCorreoEmpleado.Size = new Size(100, 23);
            txtCorreoEmpleado.TabIndex = 27;
            // 
            // txtDocumentoEmpleado
            // 
            txtDocumentoEmpleado.Location = new Point(200, 74);
            txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            txtDocumentoEmpleado.Size = new Size(100, 23);
            txtDocumentoEmpleado.TabIndex = 26;
            // 
            // listViewEmpleados
            // 
            listViewEmpleados.Location = new Point(307, 35);
            listViewEmpleados.Name = "listViewEmpleados";
            listViewEmpleados.Size = new Size(430, 172);
            listViewEmpleados.TabIndex = 25;
            listViewEmpleados.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(44, 284);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(147, 23);
            btnEliminarEmpleado.TabIndex = 24;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Location = new Point(44, 246);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(147, 23);
            btnEditarEmpleado.TabIndex = 23;
            btnEditarEmpleado.Text = "Editar Empleado";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(44, 208);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(147, 23);
            btnAgregarEmpleado.TabIndex = 22;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 117);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 21;
            label4.Text = "ingrese Correo Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 153);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 20;
            label3.Text = "ingrese  Telefono Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 77);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 19;
            label2.Text = "ingrese Documento Empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 18;
            label1.Text = "ingrese Nombre Empleado";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(178, 35);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(100, 23);
            txtNombreEmpleado.TabIndex = 17;
            // 
            // GestiondeEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnVerEmpleados);
            Controls.Add(txtTelefonoEmpleado);
            Controls.Add(txtCorreoEmpleado);
            Controls.Add(txtDocumentoEmpleado);
            Controls.Add(listViewEmpleados);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreEmpleado);
            Name = "GestiondeEmpleados";
            Text = "GestiondeEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnVerEmpleados;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtCorreoEmpleado;
        private TextBox txtDocumentoEmpleado;
        private ListView listViewEmpleados;
        private Button btnEliminarEmpleado;
        private Button btnEditarEmpleado;
        private Button btnAgregarEmpleado;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombreEmpleado;
    }
}