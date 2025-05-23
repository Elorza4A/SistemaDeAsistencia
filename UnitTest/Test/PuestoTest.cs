﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio.Negocios;

namespace UnitTest.Test
{
    /// <summary>
    /// Verifica que haya regrese tipos de puestos de la base de datos
    /// </summary>
    [TestClass]
    public class PuestoTest
    {
        [TestMethod]
        public void ObtenerPuestosTest()
        {
            List<Puesto> puestosLista = new List<Puesto>();
            try 
            {
                puestosLista = NegocioPuesto.ObtenerPuestos();

                Assert.IsTrue(puestosLista.Count > 0, "No se pudo obtener los puestos");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }

    }
}
