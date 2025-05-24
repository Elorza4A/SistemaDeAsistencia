using DPFP;
using DPFP.Capture;
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
    public partial class FrmCapturarHuella : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture captura;
        private DPFP.Processing.Enrollment enroller;
        private delegate void DelegadoMuestra(String texto);
        private delegate void DelegadoControles();
        public DPFP.Template template { get; private set; }

        private void mostrarVeces(String texto)
        {
            if (lblTexto.InvokeRequired)
            {
                DelegadoMuestra delegado = new DelegadoMuestra(mostrarVeces);
                this.Invoke(delegado, texto);
            }
            else
            {
                lblTexto.Text = texto;
            }
        }

        private void modificarControles()
        {
            if (btnGuardar.InvokeRequired)
            {
                DelegadoControles delegado = new DelegadoControles(modificarControles);
                this.Invoke(delegado, null);
            }
            else
            {
                btnGuardar.Enabled = true;
            }                
        }

        protected virtual void Init()
        {
            try
            {
                captura = new DPFP.Capture.Capture();
                if (captura != null) // si se creo una captura
                {
                    captura.EventHandler = this;
                    enroller = new DPFP.Processing.Enrollment();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Necesitas pasar tu dedo {0} veces", enroller.FeaturesNeeded);
                    lblTexto.Text = sb.ToString();
                }
                else // si no se creo una captura
                {
                    MessageBox.Show("No se pudo iniciar la captura");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void PonerImagenHuella(Bitmap bmp)
        {
            picHuella.Image = bmp;
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

        protected void Procesar(ref Sample sample)
        {
            DPFP.FeatureSet caracteristicas = ObtenerHuellaCaracteristicas(ref sample, DPFP.Processing.DataPurpose.Enrollment);
            if (caracteristicas != null)
                try
                {
                    enroller.AddFeatures(caracteristicas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Necesitas pasar tu dedo {0} veces", enroller.FeaturesNeeded);
                    mostrarVeces(sb.ToString());
                    switch (enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            template = enroller.Template;
                            PararCaptura();
                            modificarControles();
                            break;
                        case DPFP.Processing.Enrollment.Status.Failed:
                            enroller.Clear();
                            PararCaptura();
                            IniciarCaptura();
                            break;
                    }
                }
        }
        public FrmCapturarHuella()
        {
            InitializeComponent();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            PonerImagenHuella(CrearMapaHuella(ref Sample));
            Procesar(ref Sample);
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

        private void FrmCapturarHuella_Load(object sender, EventArgs e)
        {
            Init();
            IniciarCaptura();
        }

        private void FrmCapturarHuella_FormClosed(object sender, FormClosedEventArgs e)
        {
            PararCaptura();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}