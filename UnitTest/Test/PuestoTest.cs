using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace UnitTest.Test
{
    [TestClass]
    public class PuestoTest
    {
        [TestMethod]
        public void ObtenerPuestosTest()
        {
            List<Puesto> puestosLista = new List<Puesto>();
            try 
            {
                using (AsistenciaEntities db = new AsistenciaEntities())
                {
                    puestosLista = db.Puesto.ToList();

                    Assert.IsTrue(puestosLista.Count > 0, "No se pudo obtener los puestos");
                }    
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }

    }
}
