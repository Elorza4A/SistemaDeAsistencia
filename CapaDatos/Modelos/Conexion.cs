using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos.Modelos
{
    public class Conexion
    {
        private String _base;
        private String _servidor;
        private bool _seguridad;
        public static Conexion conexion = null;

        private Conexion()
        {
            this._base = "PRUEBA1";
            this._servidor = "RWNC51428";
            this._seguridad = true;
        }

        public static Conexion CrearInstancia()
        {
            if (conexion == null)
                conexion = new Conexion();
            return conexion;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = "Server=" + this._servidor + " ; Database=" + this._base + " ; ";
                connection.ConnectionString += "Integrated Security=" + _seguridad;
            }
            catch (Exception ex)
            {
                connection = null;
                throw ex;
            }
            return connection;
        }
    }
}
