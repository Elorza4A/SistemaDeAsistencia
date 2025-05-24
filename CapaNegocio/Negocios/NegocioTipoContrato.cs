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
        public static List<Contrato> ObtenerContratos()
        {
            List<Contrato> contratos = new List<Contrato>();
            try
            {
                using (AsistenciaEntities db = new AsistenciaEntities())
                {
                    contratos = db.Contrato.ToList();

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
