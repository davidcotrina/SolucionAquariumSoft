using capa3_dominio;
using capa4_persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa2_aplicacion
{
    public class GestionarInscripcionServicio
    {
        private GestorDAOSQL gestorDAOSQL;  
        private AlumnoDAO alumnoDAO;
        private GrupoDAO grupoDAO;
        private InscripcionDAO inscripcionDAO;

        public GestionarInscripcionServicio() 
        {
            gestorDAOSQL = new GestorDAOSQL();
            alumnoDAO = new AlumnoDAO(gestorDAOSQL);
            grupoDAO = new GrupoDAO(gestorDAOSQL);
            inscripcionDAO = new InscripcionDAO(gestorDAOSQL);
        }
        
        public List<Grupo> buscarGruposDisponibles(String nombre_curso)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                List<Grupo> listaGrupos = grupoDAO.buscarDisponibles(nombre_curso);
                gestorDAOSQL.cerrarConexion();
                return listaGrupos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Grupo buscarGrupo(Int32 grupoid)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                Grupo grupo = grupoDAO.buscar(grupoid);
                gestorDAOSQL.cerrarConexion();
                return grupo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Alumno buscarAlumno(String dni)
        {
            try
            {
                gestorDAOSQL.abrirConexion();
                Alumno alumno = alumnoDAO.buscarPorDNI(dni);
                gestorDAOSQL.cerrarConexion();
                return alumno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GuardarInscripcion(Alumno alumno, Int32 grupoid)
        {
            try
            {
                int registros_afectados = 0;
                gestorDAOSQL.abrirConexion();
                Grupo grupo = grupoDAO.buscar(grupoid);
                if (!grupo.yaExisteInscripcion(alumno) && !grupo.verificarLimiteDeInscritos())
                {
                    Inscripcion inscripcion = new Inscripcion();
                    inscripcion.alumno = alumno;
                    inscripcion.grupo = grupo;
                    registros_afectados = inscripcionDAO.guardar(inscripcion);
                    gestorDAOSQL.cerrarConexion();

                }
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
