namespace Registros.Views
{
    partial class frmAsistencias
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
            spcAsistencias = new SplitContainer();
            gpbGrupos = new GroupBox();
            rdbGrupoA = new RadioButton();
            rdbGrupoC = new RadioButton();
            rdbGrupoB = new RadioButton();
            txtRegistro = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtpAlumnos = new DateTimePicker();
            dgvAsistencias = new DataGridView();
            cmsData = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)spcAsistencias).BeginInit();
            spcAsistencias.Panel1.SuspendLayout();
            spcAsistencias.Panel2.SuspendLayout();
            spcAsistencias.SuspendLayout();
            gpbGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            cmsData.SuspendLayout();
            SuspendLayout();
            // 
            // spcAsistencias
            // 
            spcAsistencias.Dock = DockStyle.Fill;
            spcAsistencias.Location = new Point(0, 0);
            spcAsistencias.Name = "spcAsistencias";
            spcAsistencias.Orientation = Orientation.Horizontal;
            // 
            // spcAsistencias.Panel1
            // 
            spcAsistencias.Panel1.Controls.Add(gpbGrupos);
            spcAsistencias.Panel1.Controls.Add(txtRegistro);
            spcAsistencias.Panel1.Controls.Add(label2);
            spcAsistencias.Panel1.Controls.Add(label1);
            spcAsistencias.Panel1.Controls.Add(dtpAlumnos);
            // 
            // spcAsistencias.Panel2
            // 
            spcAsistencias.Panel2.Controls.Add(dgvAsistencias);
            spcAsistencias.Size = new Size(800, 450);
            spcAsistencias.SplitterDistance = 189;
            spcAsistencias.TabIndex = 1;
            spcAsistencias.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // gpbGrupos
            // 
            gpbGrupos.Controls.Add(rdbGrupoA);
            gpbGrupos.Controls.Add(rdbGrupoC);
            gpbGrupos.Controls.Add(rdbGrupoB);
            gpbGrupos.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbGrupos.Location = new Point(359, 32);
            gpbGrupos.Name = "gpbGrupos";
            gpbGrupos.Size = new Size(200, 129);
            gpbGrupos.TabIndex = 11;
            gpbGrupos.TabStop = false;
            gpbGrupos.Text = "Seccion del Alumno";
            // 
            // rdbGrupoA
            // 
            rdbGrupoA.AutoSize = true;
            rdbGrupoA.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbGrupoA.Location = new Point(21, 28);
            rdbGrupoA.Name = "rdbGrupoA";
            rdbGrupoA.Size = new Size(94, 25);
            rdbGrupoA.TabIndex = 8;
            rdbGrupoA.TabStop = true;
            rdbGrupoA.Text = "Grupo A";
            rdbGrupoA.UseVisualStyleBackColor = true;
            rdbGrupoA.CheckedChanged += rdbGrupoA_CheckedChanged;
            // 
            // rdbGrupoC
            // 
            rdbGrupoC.AutoSize = true;
            rdbGrupoC.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbGrupoC.Location = new Point(21, 98);
            rdbGrupoC.Name = "rdbGrupoC";
            rdbGrupoC.Size = new Size(95, 25);
            rdbGrupoC.TabIndex = 10;
            rdbGrupoC.TabStop = true;
            rdbGrupoC.Text = "Grupo C";
            rdbGrupoC.UseVisualStyleBackColor = true;
            rdbGrupoC.CheckedChanged += rdbGrupoC_CheckedChanged;
            // 
            // rdbGrupoB
            // 
            rdbGrupoB.AutoSize = true;
            rdbGrupoB.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbGrupoB.Location = new Point(21, 62);
            rdbGrupoB.Name = "rdbGrupoB";
            rdbGrupoB.Size = new Size(94, 25);
            rdbGrupoB.TabIndex = 9;
            rdbGrupoB.TabStop = true;
            rdbGrupoB.Text = "Grupo B";
            rdbGrupoB.UseVisualStyleBackColor = true;
            rdbGrupoB.CheckedChanged += rdbGrupoB_CheckedChanged;
            // 
            // txtRegistro
            // 
            txtRegistro.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegistro.Location = new Point(14, 132);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(292, 29);
            txtRegistro.TabIndex = 4;
            txtRegistro.KeyDown += txtRegistro_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Registro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 2;
            label1.Text = "Fecha";
            // 
            // dtpAlumnos
            // 
            dtpAlumnos.CalendarFont = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAlumnos.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAlumnos.Location = new Point(12, 42);
            dtpAlumnos.Name = "dtpAlumnos";
            dtpAlumnos.Size = new Size(294, 29);
            dtpAlumnos.TabIndex = 1;
            dtpAlumnos.ValueChanged += dtpAlumnos_ValueChanged;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.AllowUserToDeleteRows = false;
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.ContextMenuStrip = cmsData;
            dgvAsistencias.Dock = DockStyle.Fill;
            dgvAsistencias.Location = new Point(0, 0);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.Size = new Size(800, 257);
            dgvAsistencias.TabIndex = 0;
            // 
            // cmsData
            // 
            cmsData.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            cmsData.Name = "cmsData";
            cmsData.Size = new Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // frmAsistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spcAsistencias);
            Name = "frmAsistencias";
            Text = "Asistencias";
            Activated += frmAsistencias_Activated;
            spcAsistencias.Panel1.ResumeLayout(false);
            spcAsistencias.Panel1.PerformLayout();
            spcAsistencias.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcAsistencias).EndInit();
            spcAsistencias.ResumeLayout(false);
            gpbGrupos.ResumeLayout(false);
            gpbGrupos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            cmsData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcAsistencias;
        private Label label1;
        private DateTimePicker dtpAlumnos;
        private TextBox txtRegistro;
        private Label label2;
        private DataGridView dgvAsistencias;
        private ContextMenuStrip cmsData;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private RadioButton rdbGrupoC;
        private RadioButton rdbGrupoB;
        private RadioButton rdbGrupoA;
        private GroupBox gpbGrupos;
    }
}