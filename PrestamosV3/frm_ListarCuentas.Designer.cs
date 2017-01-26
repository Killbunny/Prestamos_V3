namespace PrestamosV3
{
    partial class frm_ListarCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ListarCuentas));
            this.button1 = new System.Windows.Forms.Button();
            this.txtLiquida = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pEditar = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSuprimir = new System.Windows.Forms.Button();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAc = new System.Windows.Forms.Button();
            this.txtFechaDeVencimiento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCuotasPendientes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUltimaCuota = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalIntereses = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSiguienteCuota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaUltimaCuota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCuotasPagadas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTasaDeInteres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoDelPrestamo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCuotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoPlazo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCuentas = new System.Windows.Forms.DataGridView();
            this.pEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(807, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 158;
            this.button1.Text = "Liquidar Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLiquida
            // 
            this.txtLiquida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtLiquida.Enabled = false;
            this.txtLiquida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquida.Location = new System.Drawing.Point(807, 392);
            this.txtLiquida.Name = "txtLiquida";
            this.txtLiquida.Size = new System.Drawing.Size(166, 31);
            this.txtLiquida.TabIndex = 157;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(868, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 156;
            this.label18.Text = "Liquida con";
            // 
            // pEditar
            // 
            this.pEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pEditar.Controls.Add(this.btnGuardar);
            this.pEditar.Controls.Add(this.btnSuprimir);
            this.pEditar.Location = new System.Drawing.Point(167, 432);
            this.pEditar.Name = "pEditar";
            this.pEditar.Size = new System.Drawing.Size(365, 37);
            this.pEditar.TabIndex = 155;
            this.pEditar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 25);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar Modificaciones";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSuprimir
            // 
            this.btnSuprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuprimir.Location = new System.Drawing.Point(240, 7);
            this.btnSuprimir.Name = "btnSuprimir";
            this.btnSuprimir.Size = new System.Drawing.Size(120, 25);
            this.btnSuprimir.TabIndex = 39;
            this.btnSuprimir.Text = "Eliminar registro";
            this.btnSuprimir.UseVisualStyleBackColor = true;
            this.btnSuprimir.Click += new System.EventHandler(this.btnSuprimir_Click);
            // 
            // chkEditar
            // 
            this.chkEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkEditar.AutoSize = true;
            this.chkEditar.Checked = true;
            this.chkEditar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditar.Location = new System.Drawing.Point(59, 444);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(102, 17);
            this.chkEditar.TabIndex = 154;
            this.chkEditar.Text = "Habilitar Edición";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // txtCuota
            // 
            this.txtCuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCuota.Enabled = false;
            this.txtCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(673, 292);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(128, 31);
            this.txtCuota.TabIndex = 153;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(594, 393);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(166, 31);
            this.txtTotalAPagar.TabIndex = 152;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(641, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 151;
            this.label17.Text = "Total a pagar";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 150;
            this.label16.Text = "Cuota";
            // 
            // btnAc
            // 
            this.btnAc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAc.Location = new System.Drawing.Point(807, 284);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(161, 39);
            this.btnAc.TabIndex = 149;
            this.btnAc.Text = "Acreditar pago de cuota";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // txtFechaDeVencimiento
            // 
            this.txtFechaDeVencimiento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFechaDeVencimiento.Enabled = false;
            this.txtFechaDeVencimiento.Location = new System.Drawing.Point(635, 354);
            this.txtFechaDeVencimiento.Name = "txtFechaDeVencimiento";
            this.txtFechaDeVencimiento.Size = new System.Drawing.Size(125, 20);
            this.txtFechaDeVencimiento.TabIndex = 148;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(561, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 147;
            this.label15.Text = "Vencimiento";
            // 
            // txtCuotasPendientes
            // 
            this.txtCuotasPendientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCuotasPendientes.Enabled = false;
            this.txtCuotasPendientes.Location = new System.Drawing.Point(407, 329);
            this.txtCuotasPendientes.Name = "txtCuotasPendientes";
            this.txtCuotasPendientes.Size = new System.Drawing.Size(125, 20);
            this.txtCuotasPendientes.TabIndex = 146;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(306, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 145;
            this.label14.Text = "Cuotas pendientes";
            // 
            // txtUltimaCuota
            // 
            this.txtUltimaCuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUltimaCuota.Enabled = false;
            this.txtUltimaCuota.Location = new System.Drawing.Point(407, 404);
            this.txtUltimaCuota.Name = "txtUltimaCuota";
            this.txtUltimaCuota.Size = new System.Drawing.Size(125, 20);
            this.txtUltimaCuota.TabIndex = 144;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 143;
            this.label13.Text = "Ultima cuota pagada";
            // 
            // txtTotalIntereses
            // 
            this.txtTotalIntereses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalIntereses.Enabled = false;
            this.txtTotalIntereses.Location = new System.Drawing.Point(407, 381);
            this.txtTotalIntereses.Name = "txtTotalIntereses";
            this.txtTotalIntereses.Size = new System.Drawing.Size(125, 20);
            this.txtTotalIntereses.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 141;
            this.label11.Text = "Total de intereses";
            // 
            // txtSiguienteCuota
            // 
            this.txtSiguienteCuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSiguienteCuota.Enabled = false;
            this.txtSiguienteCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiguienteCuota.Location = new System.Drawing.Point(805, 345);
            this.txtSiguienteCuota.Name = "txtSiguienteCuota";
            this.txtSiguienteCuota.Size = new System.Drawing.Size(168, 29);
            this.txtSiguienteCuota.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(848, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 139;
            this.label9.Text = "Siguiente Cuota";
            // 
            // txtFechaUltimaCuota
            // 
            this.txtFechaUltimaCuota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFechaUltimaCuota.Enabled = false;
            this.txtFechaUltimaCuota.Location = new System.Drawing.Point(407, 355);
            this.txtFechaUltimaCuota.Name = "txtFechaUltimaCuota";
            this.txtFechaUltimaCuota.Size = new System.Drawing.Size(125, 20);
            this.txtFechaUltimaCuota.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Fecha de la ultima cuota";
            // 
            // txtCuotasPagadas
            // 
            this.txtCuotasPagadas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCuotasPagadas.BackColor = System.Drawing.SystemColors.Window;
            this.txtCuotasPagadas.Enabled = false;
            this.txtCuotasPagadas.Location = new System.Drawing.Point(142, 329);
            this.txtCuotasPagadas.Name = "txtCuotasPagadas";
            this.txtCuotasPagadas.Size = new System.Drawing.Size(128, 20);
            this.txtCuotasPagadas.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "Cuotas Pagadas";
            // 
            // txtTasaDeInteres
            // 
            this.txtTasaDeInteres.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTasaDeInteres.Enabled = false;
            this.txtTasaDeInteres.Location = new System.Drawing.Point(142, 381);
            this.txtTasaDeInteres.Name = "txtTasaDeInteres";
            this.txtTasaDeInteres.Size = new System.Drawing.Size(128, 20);
            this.txtTasaDeInteres.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "Tasa de interés";
            // 
            // txtMontoDelPrestamo
            // 
            this.txtMontoDelPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMontoDelPrestamo.Enabled = false;
            this.txtMontoDelPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDelPrestamo.Location = new System.Drawing.Point(517, 292);
            this.txtMontoDelPrestamo.Name = "txtMontoDelPrestamo";
            this.txtMontoDelPrestamo.Size = new System.Drawing.Size(109, 31);
            this.txtMontoDelPrestamo.TabIndex = 132;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Monto del préstamo";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 292);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 31);
            this.txtNombre.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Nombre del Cliente";
            // 
            // txtNumeroCuotas
            // 
            this.txtNumeroCuotas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNumeroCuotas.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroCuotas.Enabled = false;
            this.txtNumeroCuotas.Location = new System.Drawing.Point(635, 329);
            this.txtNumeroCuotas.Name = "txtNumeroCuotas";
            this.txtNumeroCuotas.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroCuotas.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "Número de plazos";
            // 
            // txtTipoPlazo
            // 
            this.txtTipoPlazo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTipoPlazo.Enabled = false;
            this.txtTipoPlazo.Location = new System.Drawing.Point(142, 404);
            this.txtTipoPlazo.Name = "txtTipoPlazo";
            this.txtTipoPlazo.Size = new System.Drawing.Size(128, 20);
            this.txtTipoPlazo.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 125;
            this.label2.Text = "Tipo de plazo";
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFechaPrestamo.Enabled = false;
            this.txtFechaPrestamo.Location = new System.Drawing.Point(142, 355);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(128, 20);
            this.txtFechaPrestamo.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Fecha del Préstamo";
            // 
            // gvCuentas
            // 
            this.gvCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCuentas.Location = new System.Drawing.Point(40, 12);
            this.gvCuentas.Name = "gvCuentas";
            this.gvCuentas.Size = new System.Drawing.Size(929, 266);
            this.gvCuentas.TabIndex = 122;
            this.gvCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCuentas_CellClick);
            this.gvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCuentas_CellContentClick);
            // 
            // frm_ListarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLiquida);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pEditar);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.txtFechaDeVencimiento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCuotasPendientes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUltimaCuota);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalIntereses);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSiguienteCuota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFechaUltimaCuota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCuotasPagadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTasaDeInteres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoDelPrestamo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroCuotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipoPlazo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ListarCuentas";
            this.Text = "frm_ListarCuentas";
            this.Activated += new System.EventHandler(this.frm_ListarCuentas_Activated);
            this.Load += new System.EventHandler(this.frm_ListarCuentas_Load);
            this.pEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLiquida;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSuprimir;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TextBox txtFechaDeVencimiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCuotasPendientes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUltimaCuota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalIntereses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSiguienteCuota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaUltimaCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCuotasPagadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTasaDeInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoDelPrestamo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroCuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoPlazo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCuentas;
    }
}