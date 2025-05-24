using CapaDatos;
using CapaNegocio.Negocios;
using System;
using System.Collections;
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
    public partial class FrmVerEmpleados : Form
    {
        public FrmVerEmpleados()
        {
            InitializeComponent();
        }

        private void FrmVerEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarPuestos();
        }

        /// <summary>
        /// Carga los tipos de puestos que hay en la base de datos
        /// </summary>

        private void CargarPuestos()
        {
            try
            {
                cmbPuesto.DataSource = NegocioPuesto.ObtenerPuestos();
                cmbPuesto.ValueMember = "idPuesto";
                cmbPuesto.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudieron cargar los puestos y/o tipo de contrato");
                this.Close();
            }
        }


        /// <summary>
        /// Carga empleados desde la base de datos a una tabla
        /// </summary>
        private void CargarEmpleados()
        {
            using (AsistenciaEntities bd = new AsistenciaEntities())
            {
                var lista = (from e in bd.EmpleadoPersonal
                             join emp in bd.EmpleadoEmpresa
                             on e.idEmpleado equals emp.idEmpleado
                             join p in bd.Puesto
                             on emp.tipoPuesto equals p.idPuesto
                             where emp.estatus == true
                             select new
                             {
                                 ID = emp.idEmpleado,
                                 Nombre = e.nombre + " " + e.apellidoP + " " + e.apellidoM,
                                 Puesto = p.nombre,
                                 Salario = emp.salario,
                                 HoraEntrada = emp.horaEntrada,
                                 HoraSalida = emp.horaSalida
                             }).ToList();

                dgvEmpleados.DataSource = lista;
                dgvEmpleados.AutoSizeColumnsMode  = DataGridViewAutoSizeColumnsMode.Fill;

            }



        }

        private void CargarEmpleadosFiltro()
        {
            int id = (int)cmbPuesto.SelectedValue;

            using (var bd = new AsistenciaEntities())
            {
                var lista = (from e in bd.EmpleadoPersonal
                             join emp in bd.EmpleadoEmpresa
                             on e.idEmpleado equals emp.idEmpleado
                             join p in bd.Puesto
                             on emp.tipoPuesto equals p.idPuesto
                             where p.idPuesto == id && emp.estatus == true
                             select new
                             {
                                 ID = e.idEmpleado,
                                 Nombre = e.nombre + " " + e.apellidoP + " " + e.apellidoM,
                                 Puesto = p.nombre,
                                 Salario = emp.salario,
                                 HoraEntrada = emp.horaEntrada,
                                 HoraSalida = emp.horaSalida
                             }).ToList();

                dgvEmpleados.DataSource = lista;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ckbFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFiltros.Checked)
            {
                CargarEmpleadosFiltro();
            }
            else
            {
                CargarEmpleados();
            }
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckbFiltros.Checked)
            {
                CargarEmpleadosFiltro();
            }
            else
            {
                CargarEmpleados();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
