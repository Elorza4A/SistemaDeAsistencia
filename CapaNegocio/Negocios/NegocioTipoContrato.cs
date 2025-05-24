using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio.Negocios
{
    public static class NegocioTipoContrato
    {
        /// <summary>
        /// Obtiene todos los tipos de contrato de la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Si no hay contratos arroja una excepcion</exception>
        public static List<Contrato> ObtenerContratos()
        {
            List<Contrato> contratos = new List<Contrato>();
            try
            {
                using (AsistenciaEntities db = new AsistenciaEntities())
                {
                    // obtiene toda la base
                    contratos = db.Contrato.ToList();

                    // si esta vacio
                    if (contratos == null)
                        throw new Exception("No hay tipos de contratos.");
                    return contratos;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
