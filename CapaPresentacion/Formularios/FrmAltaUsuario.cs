using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio.Negocios;

namespace CapaPresentacion.Formularios
{
    public partial class FrmAltaUsuario : Form
    {
        private EmpleadoPersonal empleado;
        public DPFP.Template template;
        public FrmAltaUsuario()
        {
            InitializeComponent();
            empleado = new EmpleadoPersonal();
            empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
        }

        private void ObtenerEmpleado()
        {/*
            empleado.nombre = txtNombre.Text;
            empleado.apellidoP = txtApellidoP.Text;
            empleado.apellidoM = txtApellidoM.Text;
            empleado.fechaNac = dtpNacimiento.Value;
            empleado.correo = txtCorreo.Text;
            empleado.telefono = txtTelefono.Text;
            empleado.direccion = txtDomicilio.Text;
            empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
            empleado.EmpleadoEmpresa.idEmpleado = empleado.idEmpleado;
            empleado.EmpleadoEmpresa.fechaIng = DateTime.Now;
            empleado.EmpleadoEmpresa.tipoContrato = (int)cmbContrato.SelectedValue;
            empleado.EmpleadoEmpresa.tipoPuesto = (int)cmbContrato.SelectedValue;
            empleado.EmpleadoEmpresa.horaEntrada = TimeSpan.Parse("08:00:00");
            empleado.EmpleadoEmpresa.horaSalida = TimeSpan.Parse("18:00:00");
            empleado.EmpleadoEmpresa.salario = decimal.Parse(txtSalario.Text);
            empleado.EmpleadoEmpresa.estatus = true;*/

            
            empleado.nombre = "Alexis";
            empleado.apellidoP = "Elorza";
            empleado.apellidoM = "Obregon";
            empleado.fechaNac = dtpNacimiento.Value;
            empleado.telefono = "129012901";
            empleado.correo = "hola@uanl.com";
            empleado.direccion = "Monterrey";
            empleado.EmpleadoEmpresa.idEmpleado = empleado.idEmpleado;
            empleado.EmpleadoEmpresa.fechaIng = DateTime.Now;
            empleado.EmpleadoEmpresa.tipoPuesto = (int)cmbPuesto.SelectedValue;
            empleado.EmpleadoEmpresa.tipoContrato = (int)cmbContrato.SelectedValue;
            empleado.EmpleadoEmpresa.horaEntrada = TimeSpan.Parse("08:00:00");
            empleado.EmpleadoEmpresa.horaSalida = TimeSpan.Parse("18:00:00");
            empleado.EmpleadoEmpresa.salario = 15000m;
            empleado.EmpleadoEmpresa.estatus = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ObtenerEmpleado();
            if (empleado.EmpleadoEmpresa.huella == null)
                MessageBox.Show("error");
            try
            {
                if (NegocioEmpleado.InsertarEmpleado(empleado))
                    MessageBox.Show("Empleado registrado exitosamente");
                else
                    MessageBox.Show("El empleado no pudo ser registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuella_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPuesto.DataSource = NegocioPuesto.ObtenerPuestos();
                cmbPuesto.ValueMember = "idPuesto";
                cmbPuesto.DisplayMember = "nombre";

                cmbContrato.DataSource = NegocioTipoContrato.ObtenerContratos();
                cmbContrato.ValueMember = "idContrato";
                cmbContrato.DisplayMember = "nombre";
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnHuella_Click_1(object sender, EventArgs e)
        {
            FrmCapturarHuella frmCapturarHuella = new FrmCapturarHuella();
            if (frmCapturarHuella.ShowDialog() == DialogResult.OK)
            {
                empleado.EmpleadoEmpresa.huella = frmCapturarHuella.template?.Bytes;

                if (empleado.EmpleadoEmpresa.huella != null)
                {
                    empleado.EmpleadoEmpresa.huella = empleado.EmpleadoEmpresa.huella;
                    ckbHuella.Checked = true;

                    MessageBox.Show($"Bytes recibidos: {empleado.EmpleadoEmpresa.huella.Length}");
                }
                else
                {
                    MessageBox.Show("No se capturó ninguna huella.");
                }
            }
        }
    }
}
