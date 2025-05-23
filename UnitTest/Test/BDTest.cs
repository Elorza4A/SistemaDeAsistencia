using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaNegocio.Negocios;

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
            try
            {
                using (var bd = new AsistenciaEntities())
                {
                    Assert.IsTrue(bd.Database.Exists(), "No existe la base de datos");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }

        /// <summary>
        /// Test para verificar si se registro un empleado en la base de datos
        /// </summary>
        [TestMethod]
        public void InsertarEmpleadoTest()
        {
            try
            {
                EmpleadoPersonal empleado = new EmpleadoPersonal();
                empleado.nombre = "Alexis";
                empleado.apellidoP = "Elorza";
                empleado.apellidoM = "Obregon";
                empleado.fechaNac = DateTime.Now;
                empleado.telefono = "8130718981";
                empleado.correo = "hola@uanl.com";
                empleado.direccion = "Monterrey";
                empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
                empleado.EmpleadoEmpresa.idEmpleado = empleado.idEmpleado;
                empleado.EmpleadoEmpresa.fechaIng = DateTime.Now;
                empleado.EmpleadoEmpresa.tipoPuesto = 1;
                empleado.EmpleadoEmpresa.tipoContrato = 4;
                empleado.EmpleadoEmpresa.horaEntrada = new TimeSpan(8, 0, 0);
                empleado.EmpleadoEmpresa.horaSalida = new TimeSpan(17, 0, 0);
                empleado.EmpleadoEmpresa.salario = 15000m;
                empleado.EmpleadoEmpresa.estatus = true;

                bool condicion = NegocioEmpleado.InsertarEmpleado(empleado);
                Assert.IsTrue(condicion, "No se registro el empleado");
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Verifica que un empleado sea dado de baja ante el sistema
        /// </summary>
        [TestMethod]
        public void BajaEmpleadoTest()
        {
            try
            {
                bool condicion = NegocioEmpleado.BajaEmpleado(16);
                Assert.IsTrue(condicion, "No se dio de baja el empleado");
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Verifica que un empleado sea reactivado ante el sistema
        /// </summary>
        [TestMethod]
        public void ReactivarEmpleadoTest()
        {
            try
            {
                bool condicion = NegocioEmpleado.ReactivarEmpleado(21);
                Assert.IsTrue(condicion, "No se reactivo el empleado");
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }
        }
    }
}
