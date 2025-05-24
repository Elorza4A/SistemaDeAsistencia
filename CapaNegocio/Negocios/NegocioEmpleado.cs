using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Text.RegularExpressions;

namespace CapaNegocio.Negocios
{
    public static class NegocioEmpleado
    {
        /// <summary>
        /// valida la informacion del empleado para despues insertar en la base de datos
        /// </summary>
        /// <param name="emp">Empleado a validar</param>
        /// <exception cref="Exception">Si algun dato del empleado esta mal arroja una excepcion</exception>
        private static void validarEmpleado(EmpleadoPersonal emp)
        {
            if (!Regex.IsMatch(emp.nombre, @"^[a-zA-Z\s]+$"))
                throw new Exception("El nombre es obligatorio. Solo puede contener letras y espacios.");
            if (!Regex.IsMatch(emp.apellidoP, @"^[a-zA-Z\s]+$"))
                throw new Exception("El apellido paterno es obligatorio. Solo puede contener letras y espacios.");
            if (!Regex.IsMatch(emp.apellidoM, @"^[a-zA-Z\s]+$"))
                throw new Exception("El apellido materno es obligatorio. Solo puede contener letras y espacios.");

            if (emp.direccion == "")
                throw new Exception("El domicilio es obligatorio. No puede estar vacío.");

            if (!Regex.IsMatch(emp.telefono, @"^\d{2}-\d{4}-\d{4}$"))
                throw new Exception("El telefono es obligatorio. No puede estar vacio.");

            if (!Regex.IsMatch(emp.correo, @"^[a-zA-Z0-9]+[a-zA-Z0-9.]*@[a-zA-Z]+\.[a-zA-Z]{3,}$"))
                throw new Exception("El correo electronico es obligatorio. No puede estar vacío.");

            if (emp.EmpleadoEmpresa.huella == null)
                throw new Exception("La huella es obligatoria.");

            if (emp.EmpleadoEmpresa.salario < 8000)
                throw new Exception("El salario no puede ser menor que 8000");
            if (emp.EmpleadoEmpresa.horaEntrada >= emp.EmpleadoEmpresa.horaSalida)
                throw new Exception("La hora entrada no puede ser después que la hora salida.");

            if(emp.foto == null)
                throw new Exception("La foto del empleado es obligatoria.");
        }

        /// <summary>
        /// Inserta un empleado a la base de datos
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Si algun dato esta mal o hay un error en la conexion manda una excepcion</exception>
        public static bool InsertarEmpleado(EmpleadoPersonal emp)
        {
            try
            {
                validarEmpleado(emp);
                using (var bd = new AsistenciaEntities())
                {                        
                    bd.EmpleadoPersonal.Add(emp);
                    int rows = bd.SaveChanges();
                    return rows > 0;
                }
               

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Verifica que existe un empleado en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Si no encuentra un empleado arroja una excepcion</exception>
        public static EmpleadoPersonal VerificarEmpleado(int id)
        {
            try
            {
                using (var bd = new AsistenciaEntities())
                {
                    EmpleadoPersonal empleado = bd.EmpleadoPersonal.Find(id);

                    if (empleado == null)
                        throw new Exception("No se encontro el empleado");

                    return empleado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Da de baja (logica) a un empleado de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Si el usuario esta dado de baja arroja una excepcion</exception>
        public static bool BajaEmpleado(int id)
        {
            try
            {
                using (var bd = new AsistenciaEntities())
                {
                    EmpleadoEmpresa empleado = bd.EmpleadoEmpresa.Find(id);

                    if (empleado == null)
                        throw new Exception("No se encontro el empleado");
                    if (empleado.estatus == false)
                        return false;

                    empleado.estatus = false;

                    return bd.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Reactiva un empleado que haya sido dado de baja
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception">Si el usuario esta activo arroja una excepcion</exception>
        public static bool ReactivarEmpleado(int id)
        {
            try
            {
                using (var bd = new AsistenciaEntities())
                {
                    EmpleadoEmpresa empleado = bd.EmpleadoEmpresa.Find(id);

                    if (empleado == null)
                        throw new Exception("No se encontro el empleado");
                    if (empleado.estatus == true)
                        return false;

                    empleado.estatus = true;

                    return bd.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    
}
