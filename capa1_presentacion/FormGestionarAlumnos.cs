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
    public partial class FormGestionarAlumnos : Form
    {
        public FormGestionarAlumnos()
        {
            InitializeComponent();
        }

        /**
         * permite actualizar las propiedades de las columnas del DataGridView 
         */
        private void configurarColumnasDataGridView()
        {
            DataGridViewColumn columna0, columna1, columna2, columna3, columna4; // objetos columna
            // modificar los encabezados de columnas de la tabla
            columna0 = tablaAlumnos.Columns[0]; // se recupera la columna Id
            columna0.Visible = false; // se oculta la columna
            columna1 = tablaAlumnos.Columns[1]; // se recupera la columna nombre
            columna1.HeaderText = "Nombre"; // se asigna el encabezado de columna
            columna1.Width = 200; // se asigna el ancho de la columna
            columna2 = tablaAlumnos.Columns[2]; 
            columna2.HeaderText = "DNI"; 
            columna2.Width = 80;
            columna3 = tablaAlumnos.Columns[3]; 
            columna3.HeaderText = "Dirección"; 
            columna3.Width = 200;
            columna4 = tablaAlumnos.Columns[4]; 
            columna4.HeaderText = "Correo-e"; 
            columna4.Width = 200;
        }

        private void botCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsulta(texNombre.Text.Trim());
        }

        private void texNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // verifica si se ha pulsado la tecla enter para hacer la búsqueda
                ejecutarConsulta(texNombre.Text.Trim());
        }   

        private void ejecutarConsulta(string nombre)
        {
            try
            {                
                GestionarAlumnosServicio gestionarAlumnosServicio = new GestionarAlumnosServicio();
                List<Alumno> listaAlumnos = gestionarAlumnosServicio.buscarAlumnos(nombre);
                if (listaAlumnos.Count > 0) // para verificar si existen filas
                {
                    tablaAlumnos.Columns.Clear(); // se eliminan todas las columnas existentes del DataGridView antes de mostrar el resultado de la consulta
                    BindingSource datosEnlazados = new BindingSource(); // objeto para vincular el resultado de la consulta al DataGridView
                    datosEnlazados.DataSource = listaAlumnos;
                    tablaAlumnos.DataSource = datosEnlazados; // se vincula el resultado de la consulta al DataGridView y se mostran los registros
                    configurarColumnasDataGridView();
                    tablaAlumnos.Rows[0].Selected = false; // permite que la primera fila del DataGridView no esté seleccionada
                }
                else
                {
                    tablaAlumnos.Rows.Clear(); // se eliminan todas las filas existentes del DataGridView
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema a ejecutar la consula de alumnos. \n\nIntente de nuevo o verifique con el Administrador.", "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botCrear_Click(object sender, EventArgs e)
        {
            FormDatosAlumno formDatosAlumno = new FormDatosAlumno();
            formDatosAlumno.ShowDialog();
            texNombre.Focus();
            texNombre.Text = "";
            ejecutarConsulta("");
        }

        private void botModificar_Click(object sender, EventArgs e)
        {
            int alumnoid;
            DataGridViewRow fila = tablaAlumnos.CurrentRow; // se obtine la fila que contiene la celda actual
            if (fila != null) // verifica que exista una fila selccionada            {                
            {
                alumnoid = int.Parse(fila.Cells[0].Value.ToString()); // se obtiene el valor de una celda de la fila seleccionda                                
                GestionarAlumnosServicio gestionarAlumnosServicio = new GestionarAlumnosServicio();
                Alumno alumno = gestionarAlumnosServicio.buscarAlumno(alumnoid);
                if (alumno != null)
                {
                    FormDatosAlumno formDatosAlumno = new FormDatosAlumno(alumno);
                    formDatosAlumno.ShowDialog();
                }
                else
                    MessageBox.Show("El alumno seleccionado ya no existe, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                iniciarConsulta();
            }
            else
            {
                MessageBox.Show("Seleccione un alumno.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
        }

        private void iniciarConsulta()
        {
            ejecutarConsulta("");
            texNombre.Text = "";
            texNombre.Focus();
        }            

        private void FormGestionarAlumnos_Shown(object sender, EventArgs e)
        {
            iniciarConsulta();
        }

        private void botEliminar_Click(object sender, EventArgs e)
        {
            int alumnoid, registros_afectados;
            string nombre;
            DataGridViewRow fila = tablaAlumnos.CurrentRow; // se obtine la fila que contiene la celda actual
            if (fila == null) // verifica que exista una fila selccionada            {                
            {
                MessageBox.Show("Seleccione un alumno.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                alumnoid = int.Parse(fila.Cells[0].Value.ToString()); // se obtiene el valor de una celda de la fila seleccionda                                
                nombre = fila.Cells[1].Value.ToString();
                DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al alumno " + nombre, "AquariumSoft: Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    Alumno alumno = new Alumno();
                    alumno.alumnoid = alumnoid;
                    GestionarAlumnosServicio gestionarAlumnosServicio = new GestionarAlumnosServicio();
                    registros_afectados = gestionarAlumnosServicio.eliminarAlumno(alumno);
                    if (registros_afectados == 1)
                        MessageBox.Show("El alumno seleccionado fue eliminado.", "AquariumSoft: Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El alumno seleccionado ya no existe, verifique.", "AquariumSoft: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    iniciarConsulta();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Ocurrio un problema al eliminar el alumno. \n\nAsegurese que no tenga inscripción en algún grupo o verifique con el Administrador.", "AquariumSof: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
