namespace PrestamosV3
{
    partial class frm_ConfigurarDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConfigurarDB));
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomCad = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lsConexiones = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadCon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cadena de Conexion";
            // 
            // txtNomCad
            // 
            this.txtNomCad.Enabled = false;
            this.txtNomCad.Location = new System.Drawing.Point(126, 190);
            this.txtNomCad.Name = "txtNomCad";
            this.txtNomCad.Size = new System.Drawing.Size(100, 20);
            this.txtNomCad.TabIndex = 35;
            // 
            // txtDB
            // 
            this.txtDB.Enabled = false;
            this.txtDB.Location = new System.Drawing.Point(126, 163);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 20);
            this.txtDB.TabIndex = 34;
            this.txtDB.Text = "prestamosv3";
            this.txtDB.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(126, 137);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 32;
            this.txtPass.Text = "pass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(126, 111);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 30;
            this.txtUser.Text = "root";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(126, 85);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 28;
            this.txtServer.Text = "localhost";
            // 
            // lsConexiones
            // 
            this.lsConexiones.FormattingEnabled = true;
            this.lsConexiones.Location = new System.Drawing.Point(12, 23);
            this.lsConexiones.Name = "lsConexiones";
            this.lsConexiones.Size = new System.Drawing.Size(217, 56);
            this.lsConexiones.TabIndex = 26;
            this.lsConexiones.SelectedIndexChanged += new System.EventHandler(this.lsConexiones_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Base de datos";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Conexiones Disponibles";
            // 
            // txtCadCon
            // 
            this.txtCadCon.Location = new System.Drawing.Point(145, 0);
            this.txtCadCon.Name = "txtCadCon";
            this.txtCadCon.Size = new System.Drawing.Size(100, 20);
            this.txtCadCon.TabIndex = 38;
            this.txtCadCon.Visible = false;
            // 
            // frm_ConfigurarDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 260);
            this.Controls.Add(this.txtCadCon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomCad);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lsConexiones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ConfigurarDB";
            this.Text = "Configurar DB";
            this.Load += new System.EventHandler(this.frm_ConfigurarDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomCad;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.ListBox lsConexiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadCon;
    }
}