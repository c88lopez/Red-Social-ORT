using System;
using System.Data.SqlClient;
using System.Configuration;

namespace RedSocialDataSQLServer
{
    internal class ConexionDA
    {
        static SqlConnection conexion = null;

        private ConexionDA()
        {
        }

        public static SqlConnection ObtenerConexion()
        {
            if (ConexionDA.conexion == null)
            {
                ConexionDA.conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionRedSocial"].ConnectionString);
                conexion.Open();
            }
            
            return ConexionDA.conexion;
        }
    }
}
