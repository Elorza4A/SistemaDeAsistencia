using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio.Negocios
{
    public class NegocioEmpleado
    {
        public static bool InsertarEmpleado(EmpleadoPersonal emp)
        {
            try
            {
                using (var bd = new AsistenciaEntities())
                {
                    bd.EmpleadoPersonal.Add(emp);
                    return bd.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

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

    public static bool 
}
