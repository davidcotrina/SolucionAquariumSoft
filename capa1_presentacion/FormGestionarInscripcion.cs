using capa2_aplicacion;
using capa3_dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa1_presentacion
{
    public partial class FormGestionarInscripcion : Form
    {
        Alumno alumno = null;

        public FormGestionarInscripcion()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            int grupoid = identificadorDeGrupoSeleccionado();
            if (grupoid == 0)
                return;
            if (alumno == null) { 
                MessageBox.Show("No existe el Alumno", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                GestionarInscripcionServicio inscribirAlumnoManejador = new GestionarInscripcionServicio();
                int registros_afectados = inscribirAlumnoManejador.GuardarInscripcion(alumno, grupoid);
                if(registros_afectados == 1)
                    MessageBox.Show("El alumno fue registrado en el grupo", "AquariumSof: Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El alumno no pudo ser registrado en el grupo. \nVerifique si ya está registrado o \nsi el grupo ya llego al límite de inscritos.", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al intentar guardar la inscripción. \n\nIntente de nuevo o consulte al Administrador.", "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonVerDetalle_Click(object sender, EventArgs e)
        {
            int grupoid = identificadorDeGrupoSeleccionado();
            if (grupoid != 0)
            {
                GestionarInscripcionServicio gestionarInscripcionServicio = new GestionarInscripcionServicio();
                Grupo grupo = gestionarInscripcionServicio.buscarGrupo(grupoid);
                if (grupo != null)
                {
                    FormDetalleGrupo formDetalleGrupo = new FormDetalleGrupo(grupo);
                    formDetalleGrupo.ShowDialog();
                }
                else
                    MessageBox.Show("El grupo ya no existe, verifique.", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void FormInscribirAlumno_Shown(object sender, EventArgs e)
        {
             consultarGruposDisponibles("");
        }

        public void consultarGruposDisponibles(String nombre_curso)
        {            
            try
            {                
                GestionarInscripcionServicio gestionarInscripcionServicio = new GestionarInscripcionServicio();
                List<Grupo> listaGrupos = gestionarInscripcionServicio.buscarGruposDisponibles(nombre_curso);
                tablaGrupos.Rows.Clear(); // elimina todas las filas existentes
                foreach (Grupo grupo in listaGrupos)
                {
                    // primera forma de agregar filas a un DataGridView:
                    Object[] fila_grupo = { grupo.grupoid, grupo.curso.nombre, grupo.fechainicio, grupo.fechafin, grupo.docente.nombre };
                    tablaGrupos.Rows.Add(fila_grupo);

                    // segunda forma de agregar filas a un DataGridView:
                    //tablaGrupos.Rows.Add();
                    //DataGridViewRow fila = tablaGrupos.Rows[tablaGrupos.Rows.Count - 1];
                    //fila.Cells[0].Value = grupo.grupoid;
                    //fila.Cells[1].Value = grupo.curso.nombre;
                    //fila.Cells[2].Value = grupo.fechainicio;
                    //fila.Cells[3].Value = grupo.fechafin;
                    //fila.Cells[4].Value = grupo.docente.nombre;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al buscar los grupos disponibles. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonBuscarGrupos_Click(object sender, EventArgs e)
        {
            consultarGruposDisponibles(txtNombreCurso.Text.Trim());
        }

        private void botonBuscarAlumno_Click(object sender, EventArgs e)
        {
            String dni = txtDNI.Text.Trim();
            if (dni.Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del Alumno", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNombreAlumno.Text = "";
            try
            {
                GestionarInscripcionServicio gestionarInscripcionServicio = new GestionarInscripcionServicio();
                alumno = gestionarInscripcionServicio.buscarAlumno(dni);
                if (alumno != null)
                    txtNombreAlumno.Text = alumno.nombre;
                else
                    MessageBox.Show("No existe el Alumno", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al buscar el alumno. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int identificadorDeGrupoSeleccionado()
        {
            int grupoid = 0;
            if (tablaGrupos.SelectedRows.Count > 0 && tablaGrupos.CurrentRow != null) // se verifica si se obtine la fila que contiene la celda actual
            {
                DataGridViewRow fila = tablaGrupos.CurrentRow; // se obtine la fila que contiene la celda actual
                grupoid = int.Parse(fila.Cells[0].Value.ToString()); // se obtiene el valor de una celda de la fila seleccionda                                
            }
            else
            {
                MessageBox.Show("Seleccione un Grupo disponible", "AquariumSof: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return grupoid;
        }

        private void txtNombreCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // verifica si se ha pulsado la tecla enter para hacer la búsqueda
                consultarGruposDisponibles(txtNombreCurso.Text.Trim());
        }


    }
}
