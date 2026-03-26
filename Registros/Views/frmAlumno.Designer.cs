namespace Registros.Views
{
    partial class frmAlumno
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
            label1 = new Label();
            txtNoControl = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApPaterno = new TextBox();
            label3 = new Label();
            txtApMaterno = new TextBox();
            label4 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Numero Control";
            // 
            // txtNoControl
            // 
            txtNoControl.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoControl.Location = new Point(24, 59);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(205, 29);
            txtNoControl.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(24, 142);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 29);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 108);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtApPaterno
            // 
            txtApPaterno.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApPaterno.Location = new Point(24, 225);
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(205, 29);
            txtApPaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 191);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 4;
            label3.Text = "Apellido Paterno";
            // 
            // txtApMaterno
            // 
            txtApMaterno.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApMaterno.Location = new Point(24, 309);
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(205, 29);
            txtApMaterno.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 275);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(72, 378);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(84, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 427);
            Controls.Add(btnAceptar);
            Controls.Add(txtApMaterno);
            Controls.Add(label4);
            Controls.Add(txtApPaterno);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtNoControl);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "cd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNoControl;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApPaterno;
        private Label label3;
        private TextBox txtApMaterno;
        private Label label4;
        private Button btnAceptar;
    }
}