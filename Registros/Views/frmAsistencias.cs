using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMySQL.Clases;

namespace Registros.Views
{
    public partial class frmAsistencias : Form
    {
        Datos datos = new Datos();
        DataSet ds;
        bool uptading = false;
        Datos dt = new Datos();

        public frmAsistencias()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void frmAsistencias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Registro");
                if (ds != null)
                {
                    dgvAsistencias.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            int numC = Convert.ToInt32(txtRegistro.Text);
            if (uptading == false)
            {
                bool resultado = dt.ejecutarComando(
                    $"Insert into Registro (noControl,fecha) " +
                    $"values ({numC},'{dtpAlumnos.Value:yyyy-MM-dd}')");

                if (resultado)
                {
                    MessageBox.Show("Registro agregado correctamente");

                }
                else
                {
                    MessageBox.Show("No de control no registrado");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando(
                    $"Update Registro set noControl={numC}, fecha='{dtpAlumnos.Value:yyyy-MM-dd}' " +
                    $"where noControl={numC}");

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al actualizar la información del registro");
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.CurrentRow != null)
            {
                int noControl = Convert.ToInt32(dgvAsistencias.CurrentRow.Cells[0].Value);
                DateTime fecha = Convert.ToDateTime(dgvAsistencias.CurrentRow.Cells[1].Value);

                string fechaNormal = fecha.ToString("yyyy-MM-dd");

                if (MessageBox.Show("Deseas eliminar el registro del alumno con NoControl: "
                    + noControl + " en la fecha: " + fechaNormal,
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    bool f = datos.ejecutarComando(
                        $"DELETE FROM Registro WHERE noControl={noControl} AND fecha='{fechaNormal}'");

                    if (f)
                    {
                        MessageBox.Show("Registro eliminado", "Sistema");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema");
                    }
                }
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtpAlumnos.Value.ToString("yyyy-MM-dd");

                // Usamos el método ejecutar para obtener un DataSet
                ds = datos.ejecutar($"SELECT noControl, fecha FROM Registro WHERE fecha='{fecha}'");

                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvAsistencias.DataSource = ds.Tables[0];
                }
                else
                {
                    dgvAsistencias.DataSource = null;
                    MessageBox.Show("No hay registros para esta fecha.", "Sistema");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Sistema");
            }
        }
    }
}
