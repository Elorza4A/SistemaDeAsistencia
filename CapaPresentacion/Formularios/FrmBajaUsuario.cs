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
using CapaDatos;
using CapaNegocio.Negocios;

namespace CapaPresentacion.Formularios
{
    public partial class FrmBajaUsuario : Form
    {
        public FrmBajaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EmpleadoEmpresa empleado = new EmpleadoEmpresa();
            try
            {
                if (NegocioEmpleado.BajaEmpleado(int.Parse(txtId.Text)))
                {
                    MessageBox.Show("Empleado dado de baja");
                    btnId.Enabled = false;
                    btnConfirmar.Enabled = false;
                }
                    
                else
                    MessageBox.Show("No se pudo dar de baja el empleado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                        throw new Exception("El empleado ya fue dado de baja anteriormente");
                    txtNombre.Text = empleado.EmpleadoPersonal.nombre;
                    txtApellidoP.Text = empleado.EmpleadoPersonal.apellidoP;
                    txtApellidoM.Text = empleado.EmpleadoPersonal.apellidoM;
                    txtNacimiento.Text = empleado.EmpleadoPersonal.fechaNac.ToString();
                    txtHoraEntrada.Text = empleado.horaEntrada.ToString();
                    txtHoraSalida.Text = empleado.horaSalida.ToString();
                    txtCorreo.Text = empleado.EmpleadoPersonal.correo;
                    txtTelefono.Text = empleado.EmpleadoPersonal.telefono;
                    txtDomicilio.Text = empleado.EmpleadoPersonal.direccion;
                    txtContrato.Text = empleado.Contrato.nombre;
                    txtSalario.Text = empleado.salario.ToString();
                    txtPuesto.Text = empleado.Puesto.nombre;
                    MemoryStream ms = new MemoryStream(empleado.EmpleadoPersonal.foto);
                    Bitmap bm = new Bitmap(ms);
                    picFoto.Image = bm;
                    MessageBox.Show("Empleado encontrado");
                    btnConfirmar.Enabled = true;
                }
            }
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmBajaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
