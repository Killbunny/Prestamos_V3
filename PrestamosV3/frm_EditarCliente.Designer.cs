namespace PrestamosV3
{
    partial class frm_EditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditarCliente));
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.ckEditar = new System.Windows.Forms.CheckBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAvalTel2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAvalAd2 = new System.Windows.Forms.TextBox();
            this.txtAvalCiudad = new System.Windows.Forms.TextBox();
            this.txtAvalAd1 = new System.Windows.Forms.TextBox();
            this.txtAvalComentarios = new System.Windows.Forms.TextBox();
            this.txtAvalDireccion = new System.Windows.Forms.TextBox();
            this.txtAvalNombre = new System.Windows.Forms.TextBox();
            this.txtAvalTel1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClienteAd2 = new System.Windows.Forms.TextBox();
            this.txtClienteCiudad = new System.Windows.Forms.TextBox();
            this.cbClienteDia = new System.Windows.Forms.ComboBox();
            this.txtClienteTel3 = new System.Windows.Forms.TextBox();
            this.txtClienteAd1 = new System.Windows.Forms.TextBox();
            this.txtClienteComentarios = new System.Windows.Forms.TextBox();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.txtClienteTel2 = new System.Windows.Forms.TextBox();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteTel1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(452, 301);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(123, 33);
            this.btnEliminarCliente.TabIndex = 129;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // ckEditar
            // 
            this.ckEditar.AutoSize = true;
            this.ckEditar.Location = new System.Drawing.Point(254, 8);
            this.ckEditar.Name = "ckEditar";
            this.ckEditar.Size = new System.Drawing.Size(53, 17);
            this.ckEditar.TabIndex = 127;
            this.ckEditar.Text = "Editar";
            this.ckEditar.UseVisualStyleBackColor = true;
            this.ckEditar.CheckedChanged += new System.EventHandler(this.ckEditar_CheckedChanged);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Enabled = false;
            this.txtClienteID.Location = new System.Drawing.Point(139, 6);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 20);
            this.txtClienteID.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 125;
            this.label17.Text = "Identificador del Cliente:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(624, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(290, 33);
            this.btnGuardar.TabIndex = 128;
            this.btnGuardar.Text = "Guardar Cliente";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAvalTel2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtAvalAd2);
            this.groupBox3.Controls.Add(this.txtAvalCiudad);
            this.groupBox3.Controls.Add(this.txtAvalAd1);
            this.groupBox3.Controls.Add(this.txtAvalComentarios);
            this.groupBox3.Controls.Add(this.txtAvalDireccion);
            this.groupBox3.Controls.Add(this.txtAvalNombre);
            this.groupBox3.Controls.Add(this.txtAvalTel1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(469, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 263);
            this.groupBox3.TabIndex = 124;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Aval";
            // 
            // txtAvalTel2
            // 
            this.txtAvalTel2.Location = new System.Drawing.Point(345, 66);
            this.txtAvalTel2.MaxLength = 13;
            this.txtAvalTel2.Name = "txtAvalTel2";
            this.txtAvalTel2.Size = new System.Drawing.Size(100, 20);
            this.txtAvalTel2.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Teléfono Celular";
            // 
            // txtAvalAd2
            // 
            this.txtAvalAd2.Location = new System.Drawing.Point(226, 136);
            this.txtAvalAd2.MaxLength = 90;
            this.txtAvalAd2.Name = "txtAvalAd2";
            this.txtAvalAd2.Size = new System.Drawing.Size(219, 20);
            this.txtAvalAd2.TabIndex = 84;
            // 
            // txtAvalCiudad
            // 
            this.txtAvalCiudad.Location = new System.Drawing.Point(345, 39);
            this.txtAvalCiudad.MaxLength = 45;
            this.txtAvalCiudad.Name = "txtAvalCiudad";
            this.txtAvalCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtAvalCiudad.TabIndex = 80;
            // 
            // txtAvalAd1
            // 
            this.txtAvalAd1.Location = new System.Drawing.Point(13, 136);
            this.txtAvalAd1.MaxLength = 90;
            this.txtAvalAd1.Name = "txtAvalAd1";
            this.txtAvalAd1.Size = new System.Drawing.Size(203, 20);
            this.txtAvalAd1.TabIndex = 83;
            // 
            // txtAvalComentarios
            // 
            this.txtAvalComentarios.Location = new System.Drawing.Point(9, 175);
            this.txtAvalComentarios.MaxLength = 300;
            this.txtAvalComentarios.Multiline = true;
            this.txtAvalComentarios.Name = "txtAvalComentarios";
            this.txtAvalComentarios.Size = new System.Drawing.Size(436, 77);
            this.txtAvalComentarios.TabIndex = 85;
            // 
            // txtAvalDireccion
            // 
            this.txtAvalDireccion.Location = new System.Drawing.Point(112, 39);
            this.txtAvalDireccion.MaxLength = 90;
            this.txtAvalDireccion.Name = "txtAvalDireccion";
            this.txtAvalDireccion.Size = new System.Drawing.Size(181, 20);
            this.txtAvalDireccion.TabIndex = 79;
            // 
            // txtAvalNombre
            // 
            this.txtAvalNombre.Location = new System.Drawing.Point(112, 13);
            this.txtAvalNombre.MaxLength = 90;
            this.txtAvalNombre.Name = "txtAvalNombre";
            this.txtAvalNombre.Size = new System.Drawing.Size(333, 20);
            this.txtAvalNombre.TabIndex = 78;
            // 
            // txtAvalTel1
            // 
            this.txtAvalTel1.Location = new System.Drawing.Point(112, 65);
            this.txtAvalTel1.MaxLength = 13;
            this.txtAvalTel1.Name = "txtAvalTel1";
            this.txtAvalTel1.Size = new System.Drawing.Size(100, 20);
            this.txtAvalTel1.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "informacion Adicional 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "informacion Adicional 1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Teléfono Particular";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Comentarios";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Dirección";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClienteAd2);
            this.groupBox1.Controls.Add(this.txtClienteCiudad);
            this.groupBox1.Controls.Add(this.cbClienteDia);
            this.groupBox1.Controls.Add(this.txtClienteTel3);
            this.groupBox1.Controls.Add(this.txtClienteAd1);
            this.groupBox1.Controls.Add(this.txtClienteComentarios);
            this.groupBox1.Controls.Add(this.txtClienteDireccion);
            this.groupBox1.Controls.Add(this.txtClienteTel2);
            this.groupBox1.Controls.Add(this.txtClienteNombre);
            this.groupBox1.Controls.Add(this.txtClienteTel1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 263);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Día de corrida";
            // 
            // txtClienteAd2
            // 
            this.txtClienteAd2.Location = new System.Drawing.Point(226, 136);
            this.txtClienteAd2.MaxLength = 90;
            this.txtClienteAd2.Name = "txtClienteAd2";
            this.txtClienteAd2.Size = new System.Drawing.Size(219, 20);
            this.txtClienteAd2.TabIndex = 40;
            // 
            // txtClienteCiudad
            // 
            this.txtClienteCiudad.Location = new System.Drawing.Point(345, 39);
            this.txtClienteCiudad.MaxLength = 45;
            this.txtClienteCiudad.Name = "txtClienteCiudad";
            this.txtClienteCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCiudad.TabIndex = 3;
            // 
            // cbClienteDia
            // 
            this.cbClienteDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienteDia.FormattingEnabled = true;
            this.cbClienteDia.Items.AddRange(new object[] {
            "lunes",
            "martes",
            "miércoles",
            "jueves",
            "viernes",
            "sábado",
            "domingo"});
            this.cbClienteDia.Location = new System.Drawing.Point(112, 90);
            this.cbClienteDia.Name = "cbClienteDia";
            this.cbClienteDia.Size = new System.Drawing.Size(100, 21);
            this.cbClienteDia.TabIndex = 6;
            // 
            // txtClienteTel3
            // 
            this.txtClienteTel3.Location = new System.Drawing.Point(345, 91);
            this.txtClienteTel3.MaxLength = 13;
            this.txtClienteTel3.Name = "txtClienteTel3";
            this.txtClienteTel3.Size = new System.Drawing.Size(100, 20);
            this.txtClienteTel3.TabIndex = 7;
            // 
            // txtClienteAd1
            // 
            this.txtClienteAd1.Location = new System.Drawing.Point(9, 136);
            this.txtClienteAd1.MaxLength = 90;
            this.txtClienteAd1.Name = "txtClienteAd1";
            this.txtClienteAd1.Size = new System.Drawing.Size(203, 20);
            this.txtClienteAd1.TabIndex = 8;
            // 
            // txtClienteComentarios
            // 
            this.txtClienteComentarios.Location = new System.Drawing.Point(9, 175);
            this.txtClienteComentarios.MaxLength = 300;
            this.txtClienteComentarios.Multiline = true;
            this.txtClienteComentarios.Name = "txtClienteComentarios";
            this.txtClienteComentarios.Size = new System.Drawing.Size(436, 77);
            this.txtClienteComentarios.TabIndex = 41;
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Location = new System.Drawing.Point(112, 39);
            this.txtClienteDireccion.MaxLength = 90;
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(181, 20);
            this.txtClienteDireccion.TabIndex = 2;
            // 
            // txtClienteTel2
            // 
            this.txtClienteTel2.Location = new System.Drawing.Point(345, 65);
            this.txtClienteTel2.MaxLength = 13;
            this.txtClienteTel2.Name = "txtClienteTel2";
            this.txtClienteTel2.Size = new System.Drawing.Size(100, 20);
            this.txtClienteTel2.TabIndex = 5;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(112, 13);
            this.txtClienteNombre.MaxLength = 90;
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(333, 20);
            this.txtClienteNombre.TabIndex = 1;
            // 
            // txtClienteTel1
            // 
            this.txtClienteTel1.Location = new System.Drawing.Point(112, 65);
            this.txtClienteTel1.MaxLength = 13;
            this.txtClienteTel1.Name = "txtClienteTel1";
            this.txtClienteTel1.Size = new System.Drawing.Size(100, 20);
            this.txtClienteTel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Recomendado por";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Grupo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Teléfono Adicional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teléfono Particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comentarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Teléfono Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // gvClientes
            // 
            this.gvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvClientes.Location = new System.Drawing.Point(12, 340);
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.Size = new System.Drawing.Size(903, 230);
            this.gvClientes.TabIndex = 122;
            this.gvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClientes_CellClick);
            // 
            // frm_EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 582);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.ckEditar);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditarCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frm_EditarCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.CheckBox ckEditar;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAvalTel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAvalAd2;
        private System.Windows.Forms.TextBox txtAvalCiudad;
        private System.Windows.Forms.TextBox txtAvalAd1;
        private System.Windows.Forms.TextBox txtAvalComentarios;
        private System.Windows.Forms.TextBox txtAvalDireccion;
        private System.Windows.Forms.TextBox txtAvalNombre;
        private System.Windows.Forms.TextBox txtAvalTel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClienteAd2;
        private System.Windows.Forms.TextBox txtClienteCiudad;
        private System.Windows.Forms.ComboBox cbClienteDia;
        private System.Windows.Forms.TextBox txtClienteTel3;
        private System.Windows.Forms.TextBox txtClienteAd1;
        private System.Windows.Forms.TextBox txtClienteComentarios;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.TextBox txtClienteTel2;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteTel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvClientes;
    }
}