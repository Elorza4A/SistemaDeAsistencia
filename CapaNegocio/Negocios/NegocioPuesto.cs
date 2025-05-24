using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio.Negocios
{
    public static class NegocioPuesto
    {
        /// <summary>
        /// devuelve todos los tipos de puestos de la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">si no encuentro algun tipo de puesto arroja una excepcion</exception>
        public static List<Puesto> ObtenerPuestos()
        {
            List<Puesto> puesto = new List<Puesto>();

            try
            {
                using (AsistenciaEntities db = new AsistenciaEntities())
                {
                    // obtiene toda la base
                    puesto = db.Puesto.ToList();

                    // si esta vacio
                    if (puesto == null)
                        throw new Exception("No hay datos");
                    return puesto;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


            
        }
    }
}
