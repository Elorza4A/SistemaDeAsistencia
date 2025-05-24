using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        public FrmAltaUsuario()
        {
            InitializeComponent();
            empleado = new EmpleadoPersonal();
            empleado.EmpleadoEmpresa = new EmpleadoEmpresa();
        }

        /// <summary>
        /// Obtiene a la informacion del empleado de las entradas del forms
        /// </summary>
        /// <exception cref="Exception">Si algun dato no está correcto manda una excepcion</exception>
        private void ObtenerEmpleado()
        {
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

        /// <summary>
        /// regresa al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Intenta insertar el empleado a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerEmpleado();
                if (NegocioEmpleado.InsertarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado registrado exitosamente");
                    btnConfirmar.Enabled = false;
                }
                    
                else
                    MessageBox.Show("El empleado no pudo ser registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Almacena la foto del empleado y la muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "Archivos de imagen (*jpg; *png) | *jpg; *png;";
            if(foto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(foto.FileName);
                MemoryStream ms = new MemoryStream();
                picFoto.Image.Save(ms, ImageFormat.Jpeg);
                lblFoto.Visible = false;
            }
        }

        /// <summary>
        /// Cuando se cargue el programa obtiene tipos de puestos y tipos de contrato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Today;
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

        /// <summary>
        /// Manda a un formulario para obtener la huella del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuella_Click_1(object sender, EventArgs e)
        {
            FrmCapturarHuella frmCapturarHuella = new FrmCapturarHuella();
            if (frmCapturarHuella.ShowDialog() == DialogResult.OK)
            {
                empleado.EmpleadoEmpresa.huella = frmCapturarHuella.template?.Bytes;

                if (empleado.EmpleadoEmpresa.huella != null)
                {
                    ckbHuella.Checked = true;
                    MessageBox.Show("Captura realizada");
                }
                else
                {
                    MessageBox.Show("No se capturó ninguna huella.");
                }
            }
        }

        private void grbContacto_Enter(object sender, EventArgs e)
        {

        }

        private void grbDomicilio_Enter(object sender, EventArgs e)
        {

        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lblFoto_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
