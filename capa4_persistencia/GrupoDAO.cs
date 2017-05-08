using capa3_dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capa4_persistencia
{
    public class GrupoDAO
    {
        private GestorDAOSQL gestorDAOSQL;

        public GrupoDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }

        public List<Grupo> buscarDisponibles(String nombre_curso)
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            Grupo grupo;
            Curso curso;
            Docente docente;
            String sentenciaSQL = "select grupoid, c.nombre, fechainicio, fechafin, d.nombre " +
                   "from grupo g inner join curso c on g.cursoid = c.cursoid inner join docente d on g.docenteid = d.docenteid " +
                   "where GETDATE() <= fechalimite and c.nombre like '%" + nombre_curso + "%' order by fechainicio";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    grupo = new Grupo();
                    curso = new Curso();
                    docente = new Docente();
                    grupo.grupoid = resultado.GetInt32(0);
                    grupo.fechainicio = resultado.GetDateTime(2);
                    grupo.fechafin = resultado.GetDateTime(3);
                    curso.nombre = resultado.GetString(1);
                    docente.nombre = resultado.GetString(4);
                    grupo.curso = curso;
                    grupo.docente = docente;
                    listaGrupos.Add(grupo);
                }
                resultado.Close();
                return listaGrupos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }        

        public Grupo buscar(int grupoid)
        {                                    
            String sentenciaSQL = "select grupoid, fechainicio, fechafin, fechalimite, limiteinscritos, c.nombre, d.nombre " +
                   "from grupo g inner join curso c on g.cursoid = c.cursoid inner join docente d on g.docenteid = d.docenteid " +
                   "where grupoid = " + grupoid;
            try
            {
                Grupo grupo = null;
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                if (resultado.Read())
                {
                    grupo = new Grupo();
                    Curso curso = new Curso();
                    Docente docente = new Docente();
                    grupo.grupoid = resultado.GetInt32(0);
                    grupo.fechainicio = resultado.GetDateTime(1);
                    grupo.fechafin = resultado.GetDateTime(2);
                    grupo.fechalimite = resultado.GetDateTime(3);
                    grupo.limiteinscritos = resultado.GetInt32(4);
                    curso.nombre = resultado.GetString(5);
                    docente.nombre = resultado.GetString(6);
                    grupo.curso = curso;
                    grupo.docente = docente;
                }
                resultado.Close();
                if (grupo != null)
                {
                    sentenciaSQL = "select dia, horainicio, horafin, salon from horario where grupoid = " + grupoid;
                    SqlDataReader resultadoHorarios = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                    while (resultadoHorarios.Read())
                    {
                        Horario horario = new Horario();
                        horario.dia = resultadoHorarios.GetString(0);
                        horario.horaInicio = resultadoHorarios.GetString(1);
                        horario.horaFin = resultadoHorarios.GetString(2);
                        horario.salon = resultadoHorarios.GetString(3);
                        grupo.agregarHorario(horario);
                    }
                    resultadoHorarios.Close();
                    sentenciaSQL = "select fecha, estado, alumnoid from inscripcion where grupoid = " + grupoid;
                    SqlDataReader resultadoInscritos = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                    while (resultadoInscritos.Read())
                    {
                        Inscripcion inscripcion = new Inscripcion();
                        inscripcion.fecha = resultadoInscritos.GetDateTime(0);
                        inscripcion.estado = resultadoInscritos.GetString(1);
                        Alumno alumno = new Alumno();
                        alumno.alumnoid = resultadoInscritos.GetInt32(2);
                        inscripcion.alumno = alumno;
                        grupo.agregarIncripcion(inscripcion);
                    }
                    resultadoInscritos.Close();
                }                
                return grupo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
