using capa2_aplicacion;
using capa3_dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa1_presentacion
{
    public partial class FormDatosAlumno : Form
    {
        Alumno alumno;
        private const int ACCION_CREAR = 1;
        private const int ACCION_MODIFICAR = 2;
        private int tipoAccion;

        public FormDatosAlumno()
        {
            InitializeComponent();
            tipoAccion = ACCION_CREAR;
            this.alumno = new Alumno();
        }

        public FormDatosAlumno(Alumno alumno)
        {
            InitializeComponent();
            tipoAccion = ACCION_MODIFICAR;
            this.alumno = alumno;
            txtNombre.Text = alumno.nombre;
            txtDni.Text = alumno.dni;
            txtDireccion.Text = alumno.direccion;
            txtCorreo.Text = alumno.correoe;
        }

        private void botCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {
            int registros_afectados;
            // se recupera el valor de cada caja de texto con su propiedad Text
            // y se eliminan los espacios en blanco a la izquierda y derecha de cada caja de texto con su método Trim()
            alumno.nombre = txtNombre.Text.Trim(); 
            alumno.dni = txtDni.Text.Trim();
            alumno.direccion = txtDireccion.Text.Trim();
            alumno.correoe = txtCorreo.Text.Trim();

            // se compara la longitud de las cadenas que son obligatorias
            if (alumno.nombre.Length == 0 || alumno.dni.Length == 0)
            {
                MessageBox.Show(this, "Debe ingresar al menos el nombre y el dni", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }            
            try
            {
                GestionarAlumnosServicio gestionarAlumnoServicio = new GestionarAlumnosServicio();
                if (tipoAccion == ACCION_CREAR)
                {
                    registros_afectados = gestionarAlumnoServicio.nuevoAlumno(alumno);
                    if (registros_afectados == 1)
                        MessageBox.Show("El alumno fue creado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El alumno no pudo ser creado, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    registros_afectados = gestionarAlumnoServicio.modificarAlumno(alumno);
                    if (registros_afectados == 1)
                        MessageBox.Show("El alumno fue modificado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El alumno seleccionado no existe, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Close();  
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al gurdar el alumno. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSoft: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
