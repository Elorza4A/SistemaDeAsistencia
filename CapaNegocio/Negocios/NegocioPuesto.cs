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
        public static List<Puesto> ObtenerPuestos()
        {
            List<Puesto> puesto = new List<Puesto>();

            try
            {
                using (AsistenciaEntities db = new AsistenciaEntities())
                {
                    puesto = db.Puesto.ToList();

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
