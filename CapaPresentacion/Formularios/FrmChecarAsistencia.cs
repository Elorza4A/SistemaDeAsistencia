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

        private void FrmChecarAsistencia_Load(object sender, EventArgs e)
        {
            lblBienvenida.Enabled = false;
        }
    }
}
