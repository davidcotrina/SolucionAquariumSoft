using capa3_dominio;
using capa4_persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa2_aplicacion
{
    public class GestionarAlumnosServicio
    {
        private GestorDAOSQL gestorDAOSQL;  
        private AlumnoDAO alumnoDAO;

        public GestionarAlumnosServicio() 
        {
            gestorDAOSQL = new GestorDAOSQL();
            alumnoDAO = new AlumnoDAO(gestorDAOSQL);
        }

        public List<Alumno> buscarAlumnos(string nombre) 
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                List<Alumno> listaAlumnos = alumnoDAO.buscar(nombre);
                gestorDAOSQL.cerrarConexion();
                return listaAlumnos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Alumno buscarAlumno(int alumnoid)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                Alumno Alumno = alumnoDAO.buscarPorId(alumnoid);
                gestorDAOSQL.cerrarConexion();
                return Alumno;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public int nuevoAlumno(Alumno Alumno)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                int registros_afectados = alumnoDAO.guardar(Alumno);
                gestorDAOSQL.cerrarConexion();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public int modificarAlumno(Alumno Alumno)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                int registros_afectados = alumnoDAO.modificar(Alumno);
                gestorDAOSQL.cerrarConexion();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        public int eliminarAlumno(Alumno Alumno)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                int registros_afectados = alumnoDAO.eliminar(Alumno);
                gestorDAOSQL.cerrarConexion();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }             
        }
    }
}
