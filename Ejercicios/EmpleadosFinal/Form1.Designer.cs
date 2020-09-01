namespace EmpleadosFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.hb = new System.Windows.Forms.GroupBox();
            this.txbMesConsultado = new System.Windows.Forms.TextBox();
            this.txbAnios = new System.Windows.Forms.TextBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGratificacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCooperativa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotalAportaciones = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalNeto = new System.Windows.Forms.Label();
            this.hb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANTILLA DE PAGO DE EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INFORMACION GENERAL DEL EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMPLEADO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CARGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA DE INGRESO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MES CONSULTADO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "FECHA DE CONSULTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "AÑOS DE SERVICIO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(618, 56);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(37, 13);
            this.lblFechaActual.TabIndex = 11;
            this.lblFechaActual.Text = "Fecha";
            // 
            // hb
            // 
            this.hb.Controls.Add(this.txbMesConsultado);
            this.hb.Controls.Add(this.txbAnios);
            this.hb.Controls.Add(this.dtFechaIngreso);
            this.hb.Controls.Add(this.txbEmpleado);
            this.hb.Controls.Add(this.cbCargo);
            this.hb.Controls.Add(this.lblFechaActual);
            this.hb.Controls.Add(this.label2);
            this.hb.Controls.Add(this.label8);
            this.hb.Controls.Add(this.label3);
            this.hb.Controls.Add(this.label7);
            this.hb.Controls.Add(this.label4);
            this.hb.Controls.Add(this.label5);
            this.hb.Controls.Add(this.label6);
            this.hb.Location = new System.Drawing.Point(21, 42);
            this.hb.Name = "hb";
            this.hb.Size = new System.Drawing.Size(757, 145);
            this.hb.TabIndex = 12;
            this.hb.TabStop = false;
            // 
            // txbMesConsultado
            // 
            this.txbMesConsultado.Location = new System.Drawing.Point(466, 104);
            this.txbMesConsultado.Name = "txbMesConsultado";
            this.txbMesConsultado.Size = new System.Drawing.Size(127, 20);
            this.txbMesConsultado.TabIndex = 29;
            // 
            // txbAnios
            // 
            this.txbAnios.Location = new System.Drawing.Point(621, 104);
            this.txbAnios.Name = "txbAnios";
            this.txbAnios.Size = new System.Drawing.Size(118, 20);
            this.txbAnios.TabIndex = 28;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(466, 55);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.dtFechaIngreso.TabIndex = 27;
            this.dtFechaIngreso.ValueChanged += new System.EventHandler(this.dtFechaIngreso_ValueChanged);
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Location = new System.Drawing.Point(32, 58);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.Size = new System.Drawing.Size(387, 20);
            this.txbEmpleado.TabIndex = 13;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Coordinador",
            "Jefe",
            "Capacitador",
            "Asistente"});
            this.cbCargo.Location = new System.Drawing.Point(32, 104);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(331, 21);
            this.cbCargo.TabIndex = 13;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(21, 193);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGratificacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.lblSueldoBasico);
            this.groupBox1.Controls.Add(this.lblComision);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(21, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 123);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblGratificacion
            // 
            this.lblGratificacion.AutoSize = true;
            this.lblGratificacion.Location = new System.Drawing.Point(128, 63);
            this.lblGratificacion.Name = "lblGratificacion";
            this.lblGratificacion.Size = new System.Drawing.Size(34, 13);
            this.lblGratificacion.TabIndex = 11;
            this.lblGratificacion.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "INGRESOS";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(17, 87);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(60, 13);
            this.lb.TabIndex = 7;
            this.lb.Text = "COMISION";
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Location = new System.Drawing.Point(128, 44);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(34, 13);
            this.lblSueldoBasico.TabIndex = 6;
            this.lblSueldoBasico.Text = "$0.00";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(128, 87);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(34, 13);
            this.lblComision.TabIndex = 8;
            this.lblComision.Text = "$0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "SUELDO BASICO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "GRATIFICACION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCooperativa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblAFP);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(280, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lblCooperativa
            // 
            this.lblCooperativa.AutoSize = true;
            this.lblCooperativa.Location = new System.Drawing.Point(128, 63);
            this.lblCooperativa.Name = "lblCooperativa";
            this.lblCooperativa.Size = new System.Drawing.Size(34, 13);
            this.lblCooperativa.TabIndex = 11;
            this.lblCooperativa.Text = "$0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "DESCUENTOS";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Location = new System.Drawing.Point(128, 44);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(34, 13);
            this.lblAFP.TabIndex = 6;
            this.lblAFP.Text = "$0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "AFP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "COOPERATIVA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblSeguro);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(561, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 123);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "SEAPORTACIONES";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(128, 44);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(34, 13);
            this.lblSeguro.TabIndex = 6;
            this.lblSeguro.Text = "$0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "SEGURO SOCIAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "TOTAL INGRESOS";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Location = new System.Drawing.Point(134, 362);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(34, 13);
            this.lblTotalIngresos.TabIndex = 20;
            this.lblTotalIngresos.Text = "$0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(277, 362);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "TOTAL DE DESCUENTOS";
            // 
            // lblTotalAportaciones
            // 
            this.lblTotalAportaciones.AutoSize = true;
            this.lblTotalAportaciones.Location = new System.Drawing.Point(713, 362);
            this.lblTotalAportaciones.Name = "lblTotalAportaciones";
            this.lblTotalAportaciones.Size = new System.Drawing.Size(34, 13);
            this.lblTotalAportaciones.TabIndex = 22;
            this.lblTotalAportaciones.Text = "$0.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(567, 362);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(129, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "TOTAL APORTACIONES";
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(420, 362);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(34, 13);
            this.lblTotalDescuentos.TabIndex = 24;
            this.lblTotalDescuentos.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "TOTAL NETO";
            // 
            // lblTotalNeto
            // 
            this.lblTotalNeto.AutoSize = true;
            this.lblTotalNeto.Location = new System.Drawing.Point(567, 415);
            this.lblTotalNeto.Name = "lblTotalNeto";
            this.lblTotalNeto.Size = new System.Drawing.Size(34, 13);
            this.lblTotalNeto.TabIndex = 25;
            this.lblTotalNeto.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTotalNeto);
            this.Controls.Add(this.lblTotalDescuentos);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblTotalAportaciones);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblTotalIngresos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.hb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hb.ResumeLayout(false);
            this.hb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.GroupBox hb;
        private System.Windows.Forms.TextBox txbEmpleado;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGratificacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCooperativa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTotalAportaciones;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalNeto;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.TextBox txbMesConsultado;
        private System.Windows.Forms.TextBox txbAnios;
    }
}

