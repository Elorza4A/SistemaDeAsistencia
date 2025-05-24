namespace CapaPresentacion.Formularios
{
    partial class FrmCapturarHuella
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.picHuella = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(358, 152);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 33);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar huella";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(253, 68);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(72, 23);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "label1";
            // 
            // picHuella
            // 
            this.picHuella.Location = new System.Drawing.Point(36, 36);
            this.picHuella.Name = "picHuella";
            this.picHuella.Size = new System.Drawing.Size(187, 215);
            this.picHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHuella.TabIndex = 2;
            this.picHuella.TabStop = false;
            // 
            // FrmCapturarHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 287);
            this.Controls.Add(this.picHuella);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCapturarHuella";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapturarHuella";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCapturarHuella_FormClosed);
            this.Load += new System.EventHandler(this.FrmCapturarHuella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.PictureBox picHuella;
    }
}