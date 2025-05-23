using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using CapaDatos.Modelos;
using CapaEntidades.Entidades;


namespace UnitTest.Test
{
    /// <summary>
    /// Pruebas unitarias para todo lo relacionado con la base de datos
    /// </summary>
    [TestClass]
    public class BDTest
    {
        /// <summary>
        /// Test para verificar la conexion a la base de datos
        /// </summary>
        [TestMethod]
        public void ConexionOKTest()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion = Conexion.CrearInstancia().CrearConexion();
                conexion.Open();
                Assert.AreEqual(ConnectionState.Open, conexion.State);
            }
            catch(Exception ex)
            {
                Assert.Fail("No se pudo crear la conexion" + ex.Message);
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        /// <summary>
        /// Test para verificar si se registro un empleado en la base de datos
        /// </summary>
        [TestMethod]
        public void InsertarEmpleadoTest()
        {
            byte[] datos = new byte[] { 0x01, 0x02, 0x03, 0xFF };
            Empleado empleado = new Empleado("Alexis", datos);

            Datos_Empleado datosEmpleado = new Datos_Empleado();

            try
            {
                datosEmpleado.InsertarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se pudo insertar el empleado: " + ex.Message);
            }            
            
        }
    }
}
