using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Negocios;
using CapaDatos;
using System.IO;

namespace CapaPresentacion.Formularios
{
    public partial class FrmChecarAsistencia : Form
    {
        public FrmChecarAsistencia()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            
            EmpleadoPersonal empleado = NegocioEmpleado.VerificarEmpleado(int.Parse(txtId.Text));
            MemoryStream ms = new MemoryStream(empleado.foto);
            Bitmap foto = new Bitmap(ms);
            lblSaludo.Text = empleado.nombre + " "+ empleado.apellidoP;
            picFoto.Image = foto;
        }
    }
}
