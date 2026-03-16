namespace Registros.Views
{
    partial class frmAlumnos
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
            components = new System.ComponentModel.Container();
            spcAlumnos = new SplitContainer();
            label1 = new Label();
            btnAgregar = new Button();
            dgvAlumnos = new DataGridView();
            cmsData = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)spcAlumnos).BeginInit();
            spcAlumnos.Panel1.SuspendLayout();
            spcAlumnos.Panel2.SuspendLayout();
            spcAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            cmsData.SuspendLayout();
            SuspendLayout();
            // 
            // spcAlumnos
            // 
            spcAlumnos.Dock = DockStyle.Fill;
            spcAlumnos.Location = new Point(0, 0);
            spcAlumnos.Name = "spcAlumnos";
            spcAlumnos.Orientation = Orientation.Horizontal;
            // 
            // spcAlumnos.Panel1
            // 
            spcAlumnos.Panel1.Controls.Add(label1);
            spcAlumnos.Panel1.Controls.Add(btnAgregar);
            // 
            // spcAlumnos.Panel2
            // 
            spcAlumnos.Panel2.Controls.Add(dgvAlumnos);
            spcAlumnos.Size = new Size(785, 445);
            spcAlumnos.SplitterDistance = 66;
            spcAlumnos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(248, 23);
            label1.TabIndex = 1;
            label1.Text = "Alumnos En la base de datos";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(635, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.ContextMenuStrip = cmsData;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.Size = new Size(785, 375);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentDoubleClick += dgvAlumnos_CellContentDoubleClick;
            // 
            // cmsData
            // 
            cmsData.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsData.Name = "cmsData";
            cmsData.Size = new Size(181, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 445);
            Controls.Add(spcAlumnos);
            Name = "frmAlumnos";
            Text = "Alumnos";
            Activated += frmAlumnos_Activated;
            spcAlumnos.Panel1.ResumeLayout(false);
            spcAlumnos.Panel1.PerformLayout();
            spcAlumnos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcAlumnos).EndInit();
            spcAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            cmsData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcAlumnos;
        private Button btnAgregar;
        private DataGridView dgvAlumnos;
        private Label label1;
        private ContextMenuStrip cmsData;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}