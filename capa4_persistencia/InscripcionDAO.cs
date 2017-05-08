using capa3_dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa4_persistencia
{
    public class InscripcionDAO
    {
        private GestorDAOSQL gestorDAOSQL;

        public InscripcionDAO(GestorDAOSQL gestorDAOSQL)
        {
            this.gestorDAOSQL = gestorDAOSQL;
        }
        
        public int guardar(Inscripcion inscripcion)
        {
            int registros_afectados;
            String sentenciaSQL = "insert into inscripcion(fecha, estado, alumnoid, grupoid) values(@fecha,@estado,@alumnoid,@grupoid)";
            try
            {
                SqlCommand comando = gestorDAOSQL.obtenerComandoSQL(sentenciaSQL);
                comando.Parameters.AddWithValue("@fecha", inscripcion.fecha);
                comando.Parameters.AddWithValue("@estado", inscripcion.estado);
                comando.Parameters.AddWithValue("@alumnoid", inscripcion.alumno.alumnoid);
                comando.Parameters.AddWithValue("@grupoid", inscripcion.grupo.grupoid);
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
