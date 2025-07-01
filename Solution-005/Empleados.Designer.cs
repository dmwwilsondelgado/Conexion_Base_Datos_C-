namespace Solution_005
{
    partial class Empleados
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
            txtCorreo = new TextBox();
            listViewEmpleados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnRegistarEmpleado = new Button();
            label4 = new Label();
            label3 = new Label();
            txtRol = new TextBox();
            label2 = new Label();
            txtDocumento = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(876, 266);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(121, 23);
            txtCorreo.TabIndex = 34;
            // 
            // listViewEmpleados
            // 
            listViewEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewEmpleados.Location = new Point(24, 25);
            listViewEmpleados.Name = "listViewEmpleados";
            listViewEmpleados.Size = new Size(636, 336);
            listViewEmpleados.TabIndex = 33;
            listViewEmpleados.UseCompatibleStateImageBehavior = false;
            listViewEmpleados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Placa";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Color";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cliente";
            columnHeader4.Width = 160;
            // 
            // btnRegistarEmpleado
            // 
            btnRegistarEmpleado.Location = new Point(771, 358);
            btnRegistarEmpleado.Name = "btnRegistarEmpleado";
            btnRegistarEmpleado.Size = new Size(154, 63);
            btnRegistarEmpleado.TabIndex = 32;
            btnRegistarEmpleado.Text = "Registar Empleado";
            btnRegistarEmpleado.UseVisualStyleBackColor = true;
            btnRegistarEmpleado.Click += btnRegistarEmpleado_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 269);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 31;
            label4.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 202);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 30;
            label3.Text = "Rol Empleado";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(876, 202);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(121, 23);
            txtRol.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 129);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 28;
            label2.Text = "Documento Empleado";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(876, 121);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(121, 23);
            txtDocumento.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(718, 69);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 26;
            label1.Text = "Nombre Empleado";
            // 
            // txtName
            // 
            txtName.Location = new Point(876, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 25;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 474);
            Controls.Add(txtCorreo);
            Controls.Add(listViewEmpleados);
            Controls.Add(btnRegistarEmpleado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRol);
            Controls.Add(label2);
            Controls.Add(txtDocumento);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "Empleados";
            Text = "Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private ListView listViewEmpleados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnRegistarEmpleado;
        private Label label4;
        private Label label3;
        private TextBox txtRol;
        private Label label2;
        private TextBox txtDocumento;
        private Label label1;
        private TextBox txtName;
    }
}