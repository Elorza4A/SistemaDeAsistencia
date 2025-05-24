namespace CapaPresentacion.Formularios
{
    partial class FrmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.asistenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaEmpleadoToolStripMenuItem,
            this.bajaEmpleadoToolStripMenuItem,
            this.verEmpleadosToolStripMenuItem,
            this.editarEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // altaEmpleadoToolStripMenuItem
            // 
            this.altaEmpleadoToolStripMenuItem.Name = "altaEmpleadoToolStripMenuItem";
            this.altaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.altaEmpleadoToolStripMenuItem.Text = "Alta empleado";
            this.altaEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.altaEmpleadoToolStripMenuItem_Click);
            // 
            // bajaEmpleadoToolStripMenuItem
            // 
            this.bajaEmpleadoToolStripMenuItem.Name = "bajaEmpleadoToolStripMenuItem";
            this.bajaEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.bajaEmpleadoToolStripMenuItem.Text = "Baja empleado";
            // 
            // verEmpleadosToolStripMenuItem
            // 
            this.verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            this.verEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.verEmpleadosToolStripMenuItem.Text = "Ver empleados";
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            this.editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            this.editarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.editarEmpleadoToolStripMenuItem.Text = "Editar empleado";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteMensualToolStripMenuItem,
            this.reporteSemanaToolStripMenuItem,
            this.checarToolStripMenuItem});
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // reporteMensualToolStripMenuItem
            // 
            this.reporteMensualToolStripMenuItem.Name = "reporteMensualToolStripMenuItem";
            this.reporteMensualToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reporteMensualToolStripMenuItem.Text = "Reporte mensual";
            // 
            // reporteSemanaToolStripMenuItem
            // 
            this.reporteSemanaToolStripMenuItem.Name = "reporteSemanaToolStripMenuItem";
            this.reporteSemanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reporteSemanaToolStripMenuItem.Text = "Reporte semana";
            this.reporteSemanaToolStripMenuItem.Click += new System.EventHandler(this.reporteSemanaToolStripMenuItem_Click);
            // 
            // checarToolStripMenuItem
            // 
            this.checarToolStripMenuItem.Name = "checarToolStripMenuItem";
            this.checarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checarToolStripMenuItem.Text = "Checar";
            this.checarToolStripMenuItem.Click += new System.EventHandler(this.checarToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(791, 564);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarToolStripMenuItem;
    }
}