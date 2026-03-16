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
    public partial class frmAlumno : Form
    {
        int noControl = 0;
        bool uptading = false;
        Datos dt = new Datos();
        public frmAlumno()
        {
            InitializeComponent();
        }

        public frmAlumno(int noControl, String nombre, String apPaterno, String apMaterno)
        {
            InitializeComponent();
            uptading = true; 
            this.noControl = noControl;
            txtNoControl.Text = noControl.ToString();
            txtNombre.Text = nombre;
            txtApPaterno.Text = apPaterno;
            txtApMaterno.Text = apMaterno;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numC = Convert.ToInt32(txtNoControl.Text);

            if (uptading == false)
            {
                bool resultado = dt.ejecutarComando($"Insert into Alumnos (NoControl,Nombre,ApPaterno,ApMaterno) " +
                    $"values ({numC},'{txtNombre.Text}','{txtApPaterno.Text}','{txtApMaterno.Text}')");


                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Alumno");
                }

            }
            else
            {
                bool resultado = dt.ejecutarComando($"Update Alumnos set NoControl={numC}, Nombre='{txtNombre.Text}', ApPaterno='{txtApPaterno.Text}', ApMaterno='{txtApMaterno.Text}' " +
                      $"where NoControl={noControl}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la información del alumno");
                }
            }


        }
    }
}
