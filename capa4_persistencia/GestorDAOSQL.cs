using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capa4_persistencia
{
    public class GestorDAOSQL
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        public void abrirConexion()
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=(local);Initial Catalog=BaseAquariumSoft;Integrated Security=true";
                conexion.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void iniciarTransaccion()
        {
            try
            {
                abrirConexion();
                transaccion = conexion.BeginTransaction();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void terminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                conexion.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlDataReader ejecutarConsulta(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = conexion.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                SqlDataReader resultado = comando.ExecuteReader();
                return resultado;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSQL(String sentenciaSQL)
        {
            try
            {
                SqlCommand comando = conexion.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = sentenciaSQL;
                comando.CommandType = CommandType.Text;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlCommand obtenerComandoSP(String procedimiento_almacenado)
        {
            try
            {
                SqlCommand comando = conexion.CreateCommand();
                if (transaccion != null)
                    comando.Transaction = transaccion;
                comando.CommandText = procedimiento_almacenado;
                comando.CommandType = CommandType.StoredProcedure;
                return comando;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
