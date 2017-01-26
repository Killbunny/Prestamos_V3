namespace PrestamosV3
{
    partial class frm_NuevoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevoPrestamo));
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dlClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(53, 66);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(153, 20);
            this.datePicker.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Registrar Préstamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPlazo
            // 
            this.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Items.AddRange(new object[] {
            "Semanal (5.7%)",
            "Semanal (10%)",
            "Semanal (12%)",
            "Quincenal (12%)",
            "Quincenal (15%)",
            "Mensual (15%)",
            "Mensual (20%)",
            "Mensual (30%)"});
            this.cbPlazo.Location = new System.Drawing.Point(312, 65);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(120, 21);
            this.cbPlazo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo de plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Número de cuotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Monto";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(312, 39);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(120, 20);
            this.txtCuotas.TabIndex = 30;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(53, 39);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(153, 20);
            this.txtMonto.TabIndex = 29;
            // 
            // dlClientes
            // 
            this.dlClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dlClientes.FormattingEnabled = true;
            this.dlClientes.Location = new System.Drawing.Point(53, 12);
            this.dlClientes.Name = "dlClientes";
            this.dlClientes.Size = new System.Drawing.Size(379, 21);
            this.dlClientes.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cliente";
            // 
            // frm_NuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 140);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPlazo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dlClientes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_NuevoPrestamo";
            this.Text = "Nuevo Prestamo";
            this.Load += new System.EventHandler(this.frm_NuevoPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPlazo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox dlClientes;
        private System.Windows.Forms.Label label1;
    }
}