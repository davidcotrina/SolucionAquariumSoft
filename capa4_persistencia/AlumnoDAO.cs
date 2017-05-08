using capa3_dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capa4_persistencia
{
    public class AlumnoDAO
    {
        private GestorDAOSQL gestorDAOSQL;

        public AlumnoDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }       

        public List<Alumno> buscar(string nombre)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            Alumno alumno;
            String sentenciaSQL = "select alumnoid, nombre, dni, direccion, correoe from alumno where nombre like '%" + nombre + "%' order by nombre";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                while (resultado.Read())
                {
                    alumno = crearObjetoAlumno(resultado);
                    listaAlumnos.Add(alumno);
                }
                resultado.Close();
                return listaAlumnos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private Alumno crearObjetoAlumno(SqlDataReader resultado)
        {
            Alumno alumno;
            alumno = new Alumno();
            alumno.alumnoid = resultado.GetInt32(0);
            alumno.nombre = resultado.GetString(1);
            alumno.dni = resultado.GetString(2);
            alumno.direccion = resultado.GetString(3);
            alumno.correoe = resultado.GetString(4);
            return alumno;
        }

        public Alumno buscarPorId(int alumnoid)
        {
            Alumno alumno = null;
            String sentenciaSQL = "select alumnoid, nombre, dni, direccion, correoe from alumno where alumnoid = " + alumnoid;
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                if(resultado.Read())
                {
                    alumno = crearObjetoAlumno(resultado);
                }
                resultado.Close();
                return alumno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Alumno buscarPorDNI(string dni)
        {
            Alumno alumno = null;
            String sentenciaSQL = "select alumnoid, nombre, dni, direccion, correoe from alumno where dni = '" + dni + "'";
            try
            {
                SqlDataReader resultado = gestorDAOSQL.ejecutarConsulta(sentenciaSQL);
                if (resultado.Read())
                {
                    alumno = crearObjetoAlumno(resultado);
                }
                resultado.Close();
                return alumno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int guardar(Alumno alumno)
        {
            int registros_afectados;
            String sentenciaSQL = "insert into alumno(nombre, dni, direccion, correoe) values(@nombre, @dni, @direccion, @correoe)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(alumno, comando);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void asignarParametros(Alumno alumno, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@nombre", alumno.nombre);
            comando.Parameters.AddWithValue("@dni", alumno.dni);
            comando.Parameters.AddWithValue("@direccion", alumno.direccion);
            comando.Parameters.AddWithValue("@correoe", alumno.correoe);
        }

        public int modificar(Alumno alumno)
        {
            int registros_afectados;
            String sentenciaSQL = "update alumno set nombre = @nombre, dni = @dni, direccion = @direccion, correoe = @correoe where alumnoid = @alumnoid";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                asignarParametros(alumno, comando);
                comando.Parameters.AddWithValue("@alumnoid", alumno.alumnoid);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int eliminar(Alumno alumno)
        {
            int registros_afectados;
            String sentenciaSQL = "delete from alumno where alumnoid = @alumnoid";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@alumnoid", alumno.alumnoid);
                registros_afectados = comando.ExecuteNonQuery();
                return registros_afectados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
