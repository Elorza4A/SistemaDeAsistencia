using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void reporteSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void altaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            this.Hide();
            frmAltaUsuario.ShowDialog();
            this.Show();
        }
    }
}
