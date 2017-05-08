using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa1_presentacion
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void botAlumnos_Click(object sender, EventArgs e)
        {
            abrirFormGestionarAlumnos();
        }

        private void abrirFormGestionarAlumnos()
        {
            FormGestionarAlumnos formGestionarAlumnos = new FormGestionarAlumnos();
            formGestionarAlumnos.ShowDialog();
        }

        private void menuGestionarAlumnos_Click(object sender, EventArgs e)
        {
            abrirFormGestionarAlumnos();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botInscripcion_Click(object sender, EventArgs e)
        {
            FormGestionarInscripcion formInscribirAlumno = new FormGestionarInscripcion();
            formInscribirAlumno.ShowDialog();
        }

        private void menuGestionarInscripcion_Click(object sender, EventArgs e)
        {
            FormGestionarInscripcion formInscribirAlumno = new FormGestionarInscripcion();
            formInscribirAlumno.ShowDialog();
        }

       
    }
}
