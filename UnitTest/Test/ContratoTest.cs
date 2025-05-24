using CapaDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.Negocios;

namespace UnitTest.Test
{

    /// <summary>
    /// Verifica que haya regrese tipos de puestos de la base de datos
    /// </summary>
    [TestClass]
    public class ContratoTest
    {
        [TestMethod]
        public void ObtenerTipoContratoTest()
        {
            List<Contrato> puestosLista = new List<Contrato>();
            try
            {
                puestosLista = NegocioTipoContrato.ObtenerContratos();
                Assert.IsTrue(puestosLista.Count > 0, "No se pudo obtener los tipos de contrato");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }
    }
}

