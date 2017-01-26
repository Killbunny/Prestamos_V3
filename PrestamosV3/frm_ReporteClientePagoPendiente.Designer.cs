namespace PrestamosV3
{
    partial class frm_ReporteClientePagoPendiente
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReporteClientePagoPendiente));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new PrestamosV3.DataSet1();
            this.rvVistaPrevia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.DataTable1TableAdapter = new PrestamosV3.DataSet1TableAdapters.DataTable1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.gvCuentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvVistaPrevia
            // 
            this.rvVistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rvVistaPrevia.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVistaPrevia.LocalReport.ReportEmbeddedResource = "PrestamosV3.Report1.rdlc";
            this.rvVistaPrevia.Location = new System.Drawing.Point(559, 43);
            this.rvVistaPrevia.Name = "rvVistaPrevia";
            this.rvVistaPrevia.Size = new System.Drawing.Size(336, 408);
            this.rvVistaPrevia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Día:";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDia
            // 
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "hoy",
            "mañana",
            "lunes",
            "martes",
            "miércoles",
            "jueves",
            "viernes",
            "sábado",
            "domingo"});
            this.cbDia.Location = new System.Drawing.Point(110, 16);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 3;
            this.cbDia.Visible = false;
            this.cbDia.SelectedIndexChanged += new System.EventHandler(this.cbDia_SelectedIndexChanged);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvCuentas
            // 
            this.gvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCuentas.Location = new System.Drawing.Point(0, 0);
            this.gvCuentas.Name = "gvCuentas";
            this.gvCuentas.Size = new System.Drawing.Size(533, 408);
            this.gvCuentas.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gvCuentas);
            this.panel1.Location = new System.Drawing.Point(20, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 408);
            this.panel1.TabIndex = 6;
            // 
            // frm_ReporteClientePagoPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvVistaPrevia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ReporteClientePagoPendiente";
            this.Text = "Pagos de Clientes";
            this.Load += new System.EventHandler(this.frm_ReporteClientePagoPendiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVistaPrevia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvCuentas;
        private System.Windows.Forms.Panel panel1;
    }
}