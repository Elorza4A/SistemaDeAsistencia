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

        private void checarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChecarAsistencia frm = new FrmChecarAsistencia();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bajaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBajaUsuario frm = new FrmBajaUsuario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerEmpleados frmVerEmpleados = new FrmVerEmpleados();
            this.Hide();
            frmVerEmpleados.ShowDialog();
            this.Show();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarUsuario frmActualizarUsuario = new FrmActualizarUsuario();
            this.Hide();
            frmActualizarUsuario.ShowDialog();
            this.Show();
        }
    }
}
