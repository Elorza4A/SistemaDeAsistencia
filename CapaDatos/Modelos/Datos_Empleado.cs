using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Entidades;

namespace CapaDatos.Modelos
{
    public class Datos_Empleado
    {
        /// <summary>
        /// Inserta un empleado a la base de datos
        /// </summary>
        /// <param name="empleado">Empleado a insertar en la base de datos</param>
        /// <returns>Si regresa 0 no inserto empleados, si insertar más de 0 es que si</returns>
        /// <exception cref="ArgumentException">Mensaje de error en el insert</exception>
        public int InsertarEmpleado(Empleado empleado)
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.CrearInstancia().CrearConexion();

                SqlCommand spInsertar = new SqlCommand("InsertarEmpleado", conexion);
                spInsertar.CommandType = CommandType.StoredProcedure;

                spInsertar.Parameters.Add("@nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                spInsertar.Parameters.Add("@huella", SqlDbType.Binary).Value = empleado.ObtenerHuella();

                conexion.Open();
                return spInsertar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}
