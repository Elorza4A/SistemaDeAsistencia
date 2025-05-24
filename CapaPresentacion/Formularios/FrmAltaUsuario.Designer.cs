namespace CapaPresentacion.Formularios
{
    partial class FrmAltaUsuario
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.ckbHuella = new System.Windows.Forms.CheckBox();
            this.btnHuella = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbContacto = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDomicilio = new System.Windows.Forms.GroupBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.ckbGenerarCuenta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbContacto.SuspendLayout();
            this.grbDomicilio.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(29, 53);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(298, 317);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 13;
            this.picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(29, 377);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(298, 42);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.Text = "Seleccionar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(29, 449);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(298, 46);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(149)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(29, 525);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(298, 46);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Registrar empleado";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFoto.Location = new System.Drawing.Point(32, 189);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(299, 23);
            this.lblFoto.TabIndex = 76;
            this.lblFoto.Text = "Ingrese la foto del empleado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbGenerarCuenta);
            this.groupBox2.Controls.Add(this.txtHoraSalida);
            this.groupBox2.Controls.Add(this.txtHoraEntrada);
            this.groupBox2.Controls.Add(this.ckbHuella);
            this.groupBox2.Controls.Add(this.btnHuella);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbContrato);
            this.groupBox2.Controls.Add(this.cmbPuesto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSalario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(381, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(612, 186);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabajo";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtHoraSalida.Location = new System.Drawing.Point(170, 143);
            this.txtHoraSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraSalida.Mask = "00:00:00";
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(80, 26);
            this.txtHoraSalida.TabIndex = 31;
            this.txtHoraSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtHoraEntrada.Location = new System.Drawing.Point(170, 107);
            this.txtHoraEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoraEntrada.Mask = "00:00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(80, 26);
            this.txtHoraEntrada.TabIndex = 30;
            this.txtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckbHuella
            // 
            this.ckbHuella.AutoSize = true;
            this.ckbHuella.Enabled = false;
            this.ckbHuella.Location = new System.Drawing.Point(416, 91);
            this.ckbHuella.Name = "ckbHuella";
            this.ckbHuella.Size = new System.Drawing.Size(18, 17);
            this.ckbHuella.TabIndex = 24;
            this.ckbHuella.UseVisualStyleBackColor = true;
            // 
            // btnHuella
            // 
            this.btnHuella.Location = new System.Drawing.Point(446, 80);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(141, 36);
            this.btnHuella.TabIndex = 23;
            this.btnHuella.Text = "Registrar huella";
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hora de salida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Hora de entrada:";
            // 
            // cmbContrato
            // 
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(170, 71);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(171, 28);
            this.cmbContrato.TabIndex = 19;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(170, 32);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(171, 28);
            this.cmbPuesto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "TIpo de contrato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Salario:  $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Puesto:";
            // 
            // grbContacto
            // 
            this.grbContacto.Controls.Add(this.txtTelefono);
            this.grbContacto.Controls.Add(this.txtCorreo);
            this.grbContacto.Controls.Add(this.label8);
            this.grbContacto.Controls.Add(this.label4);
            this.grbContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbContacto.Location = new System.Drawing.Point(381, 566);
            this.grbContacto.Margin = new System.Windows.Forms.Padding(4);
            this.grbContacto.Name = "grbContacto";
            this.grbContacto.Padding = new System.Windows.Forms.Padding(4);
            this.grbContacto.Size = new System.Drawing.Size(613, 107);
            this.grbContacto.TabIndex = 80;
            this.grbContacto.TabStop = false;
            this.grbContacto.Text = "Contacto";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(124, 25);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(463, 26);
            this.txtCorreo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // grbDomicilio
            // 
            this.grbDomicilio.Controls.Add(this.txtDomicilio);
            this.grbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDomicilio.Location = new System.Drawing.Point(381, 469);
            this.grbDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.grbDomicilio.Name = "grbDomicilio";
            this.grbDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.grbDomicilio.Size = new System.Drawing.Size(612, 70);
            this.grbDomicilio.TabIndex = 78;
            this.grbDomicilio.TabStop = false;
            this.grbDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(29, 26);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(557, 26);
            this.txtDomicilio.TabIndex = 0;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.dtpNacimiento);
            this.grbDatos.Controls.Add(this.label5);
            this.grbDatos.Controls.Add(this.txtApellidoM);
            this.grbDatos.Controls.Add(this.label17);
            this.grbDatos.Controls.Add(this.txtApellidoP);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(380, 53);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatos.Size = new System.Drawing.Size(613, 176);
            this.grbDatos.TabIndex = 77;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(206, 136);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNacimiento.MaxDate = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(383, 26);
            this.dtpNacimiento.TabIndex = 12;
            this.dtpNacimiento.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(205, 102);
            this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(383, 26);
            this.txtApellidoM.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(42, 106);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Apellido materno:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(205, 64);
            this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(383, 26);
            this.txtApellidoP.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(205, 26);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 13;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(383, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido paterno:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 66);
            this.txtTelefono.Mask = "00-0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(126, 26);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(446, 31);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.MaxLength = 13;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(139, 26);
            this.txtSalario.TabIndex = 16;
            // 
            // ckbGenerarCuenta
            // 
            this.ckbGenerarCuenta.AutoSize = true;
            this.ckbGenerarCuenta.Location = new System.Drawing.Point(416, 139);
            this.ckbGenerarCuenta.Name = "ckbGenerarCuenta";
            this.ckbGenerarCuenta.Size = new System.Drawing.Size(147, 24);
            this.ckbGenerarCuenta.TabIndex = 32;
            this.ckbGenerarCuenta.Text = "Generar cuenta";
            this.ckbGenerarCuenta.UseVisualStyleBackColor = true;
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbContacto);
            this.Controls.Add(this.grbDomicilio);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.picFoto);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbContacto.ResumeLayout(false);
            this.grbContacto.PerformLayout();
            this.grbDomicilio.ResumeLayout(false);
            this.grbDomicilio.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtHoraSalida;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        private System.Windows.Forms.CheckBox ckbHuella;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbContacto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox ckbGenerarCuenta;
    }
}