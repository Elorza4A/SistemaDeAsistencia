using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    public class Empleado
    {
        /// <value>Número de empleado registrado ante el sistema</value>
        private int _id;
        /// <value>Nombre(s) del empleado</value>
        private String _nombre;
        /// <value>Apellido paterno del empleado</value>
        private String _apellidoP;
        /// <value>Apellido materno del empleado</value>
        private String _apellidoM;
        /// <value>Fecha de nacimiento del empleado</value>
        private DateTime _fechaNac;
        /// <value>Fecha que ingreso ante el sistema</value>
        private DateTime _fechaIng;
        /// <value>Cadena de bytes del empleado</value>
        private byte[] _huella = null;

        public Empleado(string nombre, string apellidoP, string apellidoM, DateTime fechaNac, DateTime fechaIng)
        {
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FechaNac = fechaNac;
            FechaIng = fechaIng;
        }

        public Empleado(string nombre, byte[] cadenaHuella)
        {
            Nombre = nombre;
            GuardarHuella(ref cadenaHuella);
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoP { get => _apellidoP; set => _apellidoP = value; }
        public string ApellidoM { get => _apellidoM; set => _apellidoM = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public DateTime FechaIng { get => _fechaIng; set => _fechaIng = value; }

        /// <summary>
        /// Almacena la cadena de bytes de la huella del empleado
        /// </summary>
        /// <param name="cadenaHuella"></param>
        public void GuardarHuella(ref byte[] cadenaHuella)
        {
            _huella = cadenaHuella;
        }

        /// <summary>
        /// Obtiene la cadena de bytes de la huella del empleado
        /// </summary>
        /// <returns></returns>
        public byte[] ObtenerHuella()
        {
            return _huella;
        }

    }
}
