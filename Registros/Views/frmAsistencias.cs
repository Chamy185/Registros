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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.CurrentRow != null)
            {
                int noControl = Convert.ToInt32(dgvAsistencias.CurrentRow.Cells[0].Value);
                DateTime fecha1 = Convert.ToDateTime(dgvAsistencias.CurrentRow.Cells[1].Value);

                string fecha2 = fecha1.ToString("yyyy-MM-dd");

                if (MessageBox.Show("Deseas eliminar el registro del alumno con NoControl: "
                    + noControl + " en la fecha: " + fecha2,
                    "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    bool f = datos.ejecutarComando(
                        $"DELETE FROM Registro WHERE noControl={noControl} AND fecha='{fecha2}'");

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

        //Enter para registrar
        //Si seleccionas diferente grupo tiene que seleccionar el cursor al text box para que detectar el numero de control
        private void txtRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int numC = Convert.ToInt32(txtRegistro.Text);
                    string fecha = dtpAlumnos.Value.ToString("yyyy-MM-dd");
                    String grupo = "";
                    if (rdbGrupoA.Checked)
                    {
                        grupo = "Grupo A";
                    }
                    else if (rdbGrupoB.Checked)
                    {
                        grupo = "Grupo B";
                    }
                    else if (rdbGrupoC.Checked)
                    {
                        grupo = "Grupo C";
                    }


                    if (grupo == "")
                    {
                        MessageBox.Show("Selecciona el grupo del Alumno");
                        return;
                    }

                    if (uptading == false)
                    {
                        bool resultado = dt.ejecutarComando(
                            $"Insert into Registro (noControl,fecha,grupo) " +
                            $"values ({numC},'{fecha}','{grupo}')");

                        if (resultado)
                        {
                            ds = datos.ejecutar("Select * from Registro");
                            if (ds != null)
                            {
                                dgvAsistencias.DataSource = ds.Tables[0];
                            }
                        }
                        else
                        {
                            MessageBox.Show("No de control no registrado");
                        }
                    }
                    else
                    {
                        bool resultado = dt.ejecutarComando(
                            $"Update Registro set noControl={numC}, fecha='{dtpAlumnos.Value:yyyy-MM-dd}', grupo='{grupo}' " +
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
                catch (Exception)
                {
                    MessageBox.Show("Ingresa un número válido");
                }
                //Para que no moleste el sonido de Windows
                e.SuppressKeyPress = true;
            }
        }

        private void dtpAlumnos_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtpAlumnos.Value.ToString("yyyy-MM-dd");

                string grupo = "";

                if (rdbGrupoA.Checked)
                    grupo = "Grupo A";
                else if (rdbGrupoB.Checked)
                    grupo = "Grupo B";
                else if (rdbGrupoC.Checked)
                    grupo = "Grupo C";

                if (grupo == "")
                {
                    MessageBox.Show("Selecciona un grupo");
                    return;
                }


                ds = datos.ejecutar($"SELECT noControl, grupo, fecha FROM Registro WHERE fecha='{fecha}'  AND grupo='{grupo}'  ORDER BY grupo");

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

        //llamamos el metodo de cambiar la fecha para que se actualice el datagridview al cambiar de grupo
        private void rdbGrupoA_CheckedChanged(object sender, EventArgs e)
        {
            dtpAlumnos_ValueChanged(null, null);
        }

        private void rdbGrupoB_CheckedChanged(object sender, EventArgs e)
        {
            dtpAlumnos_ValueChanged(null, null);
        }

        private void rdbGrupoC_CheckedChanged(object sender, EventArgs e)
        {
            dtpAlumnos_ValueChanged(null, null);
        }
    }
}
