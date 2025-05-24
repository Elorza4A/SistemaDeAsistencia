using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaNegocio.Negocios;
using System.IO;
using System.Collections.Generic;

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
                    // verifica si la base existe
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
            // huella ejemplo
            byte[] datos = new byte[] { 0x01, 0xFF, 0x3A, 0x00 };
            try
            {
                // empleado prueba
                EmpleadoPersonal empleado = new EmpleadoPersonal();
                empleado.nombre = "felipe";
                empleado.apellidoP = "Elorza";
                empleado.apellidoM = "Obregon";
                empleado.fechaNac = DateTime.Now;
                empleado.telefono = "81-3071-8981";
                empleado.correo = "hola@uanl.com";
                empleado.direccion = "Monterrey";
                empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
                empleado.EmpleadoEmpresa.idEmpleado = empleado.idEmpleado;
                empleado.EmpleadoEmpresa.fechaIng = DateTime.Now;
                empleado.EmpleadoEmpresa.tipoPuesto = 1;
                empleado.EmpleadoEmpresa.tipoContrato = 4;
                empleado.EmpleadoEmpresa.horaEntrada = TimeSpan.Parse("08:00:00");
                empleado.EmpleadoEmpresa.horaSalida = TimeSpan.Parse("18:00:00");
                empleado.EmpleadoEmpresa.salario = 15000m;
                empleado.EmpleadoEmpresa.estatus = true;
                empleado.EmpleadoEmpresa.huella = datos;
                empleado.foto = File.ReadAllBytes("C:\\Users\\alexe\\source\\repos\\SistemaDeAsistencia\\UnitTest\\Resources\\BobToronja.jpg");

                // inserta
                bool condicion = NegocioEmpleado.InsertarEmpleado(empleado);
                Assert.IsTrue(condicion, "No se registro el empleado");
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
        public void VerificarEmpleadoTest()
        {
            try
            {
                // devuelve el empleado si lo encontro
                EmpleadoPersonal empleado = NegocioEmpleado.VerificarAsistenciaEmpleado(56);
                Console.WriteLine(empleado.nombre);
                Assert.IsTrue(empleado != null, "No se reactivo el empleado");
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
                // reactiva empleado 16
                NegocioEmpleado.ReactivarEmpleado(16);

                // baja emmpleado 16
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
                // baja emmpleado 16
                NegocioEmpleado.BajaEmpleado(21);
                // reactiva empleado 16
                bool condicion = NegocioEmpleado.ReactivarEmpleado(21);
                Assert.IsTrue(condicion, "No se reactivo el empleado");
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// verifica que haya empleados en la base de datos
        /// </summary>
        [TestMethod]
        public void ObtenerEmpleadosTest()
        {
            List<EmpleadoEmpresa> empleadosLista = new List<EmpleadoEmpresa>();
            try
            {
                empleadosLista = NegocioEmpleado.ObtenerEmpleados();
                Console.WriteLine(empleadosLista.Count.ToString());
                Assert.IsTrue(empleadosLista.Count > 0, "No se pudo obtener los puestos");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
    }
}
