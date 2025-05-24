namespace CapaPresentacion.Formularios
{
    partial class FrmChecarAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picHuella = new System.Windows.Forms.PictureBox();
            this.picEmpleado = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHuella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // picHuella
            // 
            this.picHuella.Location = new System.Drawing.Point(61, 134);
            this.picHuella.Margin = new System.Windows.Forms.Padding(4);
            this.picHuella.Name = "picHuella";
            this.picHuella.Size = new System.Drawing.Size(174, 204);
            this.picHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHuella.TabIndex = 0;
            this.picHuella.TabStop = false;
            // 
            // picEmpleado
            // 
            this.picEmpleado.Location = new System.Drawing.Point(340, 24);
            this.picEmpleado.Name = "picEmpleado";
            this.picEmpleado.Size = new System.Drawing.Size(308, 376);
            this.picEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmpleado.TabIndex = 4;
            this.picEmpleado.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Location = new System.Drawing.Point(340, 423);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(308, 80);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "label1";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmChecarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 575);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.picEmpleado);
            this.Controls.Add(this.picHuella);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChecarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checador";
            this.Load += new System.EventHandler(this.FrmChecarAsistencia_Load);
            this.Leave += new System.EventHandler(this.FrmChecarAsistencia_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.picHuella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHuella;
        private System.Windows.Forms.PictureBox picEmpleado;
        private System.Windows.Forms.Label lblBienvenida;
    }
}