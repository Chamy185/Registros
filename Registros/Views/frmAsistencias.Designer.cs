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
            btnRegistros = new Button();
            btnAsistencia = new Button();
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
            spcAsistencias.Panel1.Controls.Add(btnRegistros);
            spcAsistencias.Panel1.Controls.Add(btnAsistencia);
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
            // btnRegistros
            // 
            btnRegistros.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistros.Location = new Point(351, 42);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(99, 29);
            btnRegistros.TabIndex = 6;
            btnRegistros.Text = "Registros";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // btnAsistencia
            // 
            btnAsistencia.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsistencia.Location = new Point(351, 132);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(99, 29);
            btnAsistencia.TabIndex = 5;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.UseVisualStyleBackColor = true;
            btnAsistencia.Click += btnAsistencia_Click;
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
            Text = "cdcd";
            Activated += frmAsistencias_Activated;
            spcAsistencias.Panel1.ResumeLayout(false);
            spcAsistencias.Panel1.PerformLayout();
            spcAsistencias.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcAsistencias).EndInit();
            spcAsistencias.ResumeLayout(false);
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
        private Button btnAsistencia;
        private ContextMenuStrip cmsData;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnRegistros;
    }
}