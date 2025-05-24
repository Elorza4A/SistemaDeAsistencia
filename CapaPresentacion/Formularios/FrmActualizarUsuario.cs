using CapaDatos;
using CapaNegocio.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class FrmActualizarUsuario : Form
    {
        private EmpleadoPersonal empleado;
        public FrmActualizarUsuario()
        {
            InitializeComponent();
            empleado = new EmpleadoPersonal();
            empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            try
            {
                using (AsistenciaEntities bd = new AsistenciaEntities())
                {
                    EmpleadoEmpresa empleado;

                    int Id = int.Parse(txtId.Text);
                    empleado = bd.EmpleadoEmpresa.Include("EmpleadoPersonal").FirstOrDefault(o => o.idEmpleado == Id);
                    if (empleado == null)
                        throw new Exception("No existe el empleado");
                    if (empleado.estatus == false)
                        throw new Exception("El empleado esta dado de baja");
                    txtNombre.Text = empleado.EmpleadoPersonal.nombre;
                    txtApellidoP.Text = empleado.EmpleadoPersonal.apellidoP;
                    txtApellidoM.Text = empleado.EmpleadoPersonal.apellidoM;
                    dtpNacimiento.Value = empleado.EmpleadoPersonal.fechaNac;
                    txtHoraEntrada.Text = empleado.horaEntrada.ToString();
                    txtHoraSalida.Text = empleado.horaSalida.ToString();
                    txtCorreo.Text = empleado.EmpleadoPersonal.correo;
                    txtTelefono.Text = empleado.EmpleadoPersonal.telefono;
                    txtDomicilio.Text = empleado.EmpleadoPersonal.direccion;
                    cmbPuesto.SelectedValue = empleado.Puesto.idPuesto;
                    txtSalario.Text = empleado.salario.ToString();
                    cmbContrato.SelectedValue = empleado.Contrato.idContrato;
                    this.empleado.EmpleadoEmpresa.huella = empleado.huella;
                    MemoryStream ms = new MemoryStream(empleado.EmpleadoPersonal.foto);
                    Bitmap bm = new Bitmap(ms);
                    picFoto.Image = bm;
                    MessageBox.Show("Empleado encontrado");
                    ckbHabilitar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmActualizarUsuario_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;
            dtpNacimiento.Value = DateTime.Today;
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
                MessageBox.Show("Error no se pudieron cargar los puestos y/o tipo de contrato");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerEmpleado();
                if (NegocioEmpleado.ActualizarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado actualizado exitosamente");
                    btnConfirmar.Enabled = false;
                }
                else
                    MessageBox.Show("El empleado no pudo ser actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Obtiene a la informacion del empleado de las entradas del forms
        /// </summary>
        /// <exception cref="Exception">Si algun dato no está correcto manda una excepcion</exception>
        private void ObtenerEmpleado()
        {
            empleado.idEmpleado = int.Parse(txtId.Text);
            empleado.nombre = txtNombre.Text;
            empleado.apellidoP = txtApellidoP.Text;
            empleado.apellidoM = txtApellidoM.Text;
            empleado.fechaNac = dtpNacimiento.Value;
            empleado.correo = txtCorreo.Text;
            empleado.telefono = txtTelefono.Text;
            empleado.direccion = txtDomicilio.Text;
            empleado.EmpleadoEmpresa.idEmpleado = empleado.idEmpleado;
            empleado.EmpleadoEmpresa.fechaIng = DateTime.Now;
            empleado.EmpleadoEmpresa.tipoContrato = (int)cmbContrato.SelectedValue;
            empleado.EmpleadoEmpresa.tipoPuesto = (int)cmbPuesto.SelectedValue;
            empleado.EmpleadoEmpresa.estatus = true;
            using (MemoryStream ms = new MemoryStream())
            {
                picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                empleado.foto = ms.ToArray();
            }
            try
            {
                empleado.EmpleadoEmpresa.horaEntrada = TimeSpan.Parse(txtHoraEntrada.Text);
                empleado.EmpleadoEmpresa.horaSalida = TimeSpan.Parse(txtHoraSalida.Text);
                empleado.EmpleadoEmpresa.salario = decimal.Parse(txtSalario.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Formato inválido en hora entradad/sallda o salario. Verifica los datos ingresados.");
            }

        }

        private void btnHuella_Click(object sender, EventArgs e)
        {
            FrmCapturarHuella frmCapturarHuella = new FrmCapturarHuella();
            if (frmCapturarHuella.ShowDialog() == DialogResult.OK)
            {
                empleado.EmpleadoEmpresa.huella = frmCapturarHuella.template?.Bytes;

                if (empleado.EmpleadoEmpresa.huella != null)
                {
                    MessageBox.Show("Captura actualizada");
                }
                else
                {
                    MessageBox.Show("No se capturó ninguna huella.");
                }
            }
        }

        private void ckbHabilitar_CheckedChanged(object sender, EventArgs e)
        {
            ckbHabilitar.Enabled = false;

            grbContacto.Enabled = true;
            grbDatos.Enabled = true;
            grbDomicilio.Enabled = true;
            groupBox2.Enabled = true;

            btnId.Enabled = false;
            txtId.Enabled = false;

            btnConfirmar.Enabled = true;
        }
    }
}
