namespace solution_002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            txtCorreo = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(59, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 216);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(7, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 190);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            button1.Location = new Point(113, 120);
            button1.Name = "button1";
            button1.Size = new Size(157, 46);
            button1.TabIndex = 4;
            button1.Text = "Registrate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(127, 59);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(198, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            label3.Location = new Point(22, 59);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 1;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(197, 43);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "Cine Bomm";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(529, 568);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtCorreo;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
