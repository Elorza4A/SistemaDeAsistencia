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
using DPFP;
using DPFP.Capture;
using DPFP.Verification;
using static DPFP.Verification.Verification;
using System.Collections;
using System.Threading;

namespace CapaPresentacion.Formularios
{
    public partial class FrmChecarAsistencia : Form, DPFP.Capture.EventHandler
    {

        public DPFP.Template template { get; private set; }
        private DPFP.Capture.Capture captura;
        private DPFP.Verification.Verification verificacion;
        public FrmChecarAsistencia()
        {
            InitializeComponent();
        }

        protected virtual void Init()
        {
            try
            {
                captura = new DPFP.Capture.Capture();                
                if (captura != null) // si se creo una captura
                {
                    verificacion = new DPFP.Verification.Verification();
                    captura.EventHandler = this;          
                }
                else // si no se creo una captura
                {
                    MessageBox.Show("No se pudo iniciar la captura");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        protected void IniciarCaptura()
        {
            if (captura != null)
            {
                try
                {
                    captura.StartCapture();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected void PararCaptura()
        {
            if (captura != null)
            {
                try
                {
                    captura.StopCapture();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected Bitmap CrearMapaHuella(ref DPFP.Sample sample)
        {
            DPFP.Capture.SampleConversion convertidor = new SampleConversion(); // variable conversor de sample
            Bitmap mapaBits = null;

            convertidor.ConvertToPicture(sample, ref mapaBits);

            return mapaBits;
        }

        protected DPFP.FeatureSet ObtenerHuellaCaracteristicas(ref Sample sample, DPFP.Processing.DataPurpose purpose)
        {
            DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
            DPFP.Capture.CaptureFeedback info = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet feature = new FeatureSet();

            extractor.CreateFeatureSet(sample, purpose, ref info, ref feature);

            if (info == DPFP.Capture.CaptureFeedback.Good)
                return feature;
            else
                return null;
        }

        private void PonerImagenHuella(Bitmap bmp)
        {
            picHuella.Image = bmp;
        }

        private void MostrarDatos(EmpleadoPersonal empleado)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                MemoryStream ms = new MemoryStream(empleado.foto);
                Bitmap bm = new Bitmap(ms);
                picEmpleado.Image = bm;
                lblBienvenida.Visible = true;
                lblBienvenida.Text = "Buen dia, " + empleado.nombre + " " + empleado.apellidoP;
            }));
        }

        private void MostrarError(String mensaje)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                MessageBox.Show(mensaje);
            }));
        }

        private void SinCoincidencias() { 
            this.Invoke(new MethodInvoker(delegate
            {
                MessageBox.Show("Sin coincidencias");
            }));
        }


        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            PonerImagenHuella(CrearMapaHuella(ref Sample));
            DPFP.FeatureSet caracteristicas = ObtenerHuellaCaracteristicas(ref Sample, DPFP.Processing.DataPurpose.Verification);
            if(caracteristicas != null) {
                DPFP.Verification.Verification.Result resultado = new DPFP.Verification.Verification.Result();
                DPFP.Template template = new DPFP.Template();
                try
                {
                    List<EmpleadoEmpresa> empleadosEmpresa = NegocioEmpleado.ObtenerEmpleados();
                    foreach (EmpleadoEmpresa emp in empleadosEmpresa)
                    {
                        int id = emp.EmpleadoPersonal.idEmpleado;
                        byte[] bytes = (byte[])emp.huella;
                        if (emp.huella != null && emp.estatus == true)
                        {
                            MemoryStream ms = new MemoryStream(bytes);
                            template = new DPFP.Template(ms);
                            verificacion.Verify(caracteristicas, template, ref resultado);
                            Console.WriteLine(resultado.FARAchieved);
                            if (resultado.Verified)
                            {
                                MostrarDatos(NegocioEmpleado.VerificarAsistenciaEmpleado(id));
                                return;
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                    return;
                }
                SinCoincidencias();

            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            
        }

        private void FrmChecarAsistencia_Load(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            Init();
            IniciarCaptura();
        }

        private void FrmChecarAsistencia_Leave(object sender, EventArgs e)
        {
            PararCaptura();
        }
    }
}
