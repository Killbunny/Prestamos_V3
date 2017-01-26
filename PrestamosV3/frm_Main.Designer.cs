namespace PrestamosV3
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.listarCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.martesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miércolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juevesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viernesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sábadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domingoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.reporteDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEditarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPréstamoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.listarCuentasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.reporteDePagosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Cuentas";
            // 
            // nuevoPréstamoToolStripMenuItem
            // 
            this.nuevoPréstamoToolStripMenuItem.Name = "nuevoPréstamoToolStripMenuItem";
            this.nuevoPréstamoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevoPréstamoToolStripMenuItem.Text = "Nuevo Préstamo";
            this.nuevoPréstamoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPréstamoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // listarCuentasToolStripMenuItem
            // 
            this.listarCuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDíaToolStripMenuItem,
            this.pendientesToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.listarCuentasToolStripMenuItem.Name = "listarCuentasToolStripMenuItem";
            this.listarCuentasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listarCuentasToolStripMenuItem.Text = "Listar Cuentas";
            // 
            // porDíaToolStripMenuItem
            // 
            this.porDíaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lunesToolStripMenuItem,
            this.martesToolStripMenuItem,
            this.miércolesToolStripMenuItem,
            this.juevesToolStripMenuItem,
            this.viernesToolStripMenuItem,
            this.sábadoToolStripMenuItem,
            this.domingoToolStripMenuItem});
            this.porDíaToolStripMenuItem.Name = "porDíaToolStripMenuItem";
            this.porDíaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.porDíaToolStripMenuItem.Text = "Por día";
            // 
            // lunesToolStripMenuItem
            // 
            this.lunesToolStripMenuItem.Name = "lunesToolStripMenuItem";
            this.lunesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lunesToolStripMenuItem.Text = "Lunes";
            this.lunesToolStripMenuItem.Click += new System.EventHandler(this.lunesToolStripMenuItem_Click);
            // 
            // martesToolStripMenuItem
            // 
            this.martesToolStripMenuItem.Name = "martesToolStripMenuItem";
            this.martesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.martesToolStripMenuItem.Text = "Martes";
            this.martesToolStripMenuItem.Click += new System.EventHandler(this.martesToolStripMenuItem_Click);
            // 
            // miércolesToolStripMenuItem
            // 
            this.miércolesToolStripMenuItem.Name = "miércolesToolStripMenuItem";
            this.miércolesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.miércolesToolStripMenuItem.Text = "Miércoles";
            this.miércolesToolStripMenuItem.Click += new System.EventHandler(this.miércolesToolStripMenuItem_Click);
            // 
            // juevesToolStripMenuItem
            // 
            this.juevesToolStripMenuItem.Name = "juevesToolStripMenuItem";
            this.juevesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.juevesToolStripMenuItem.Text = "Jueves";
            this.juevesToolStripMenuItem.Click += new System.EventHandler(this.juevesToolStripMenuItem_Click);
            // 
            // viernesToolStripMenuItem
            // 
            this.viernesToolStripMenuItem.Name = "viernesToolStripMenuItem";
            this.viernesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viernesToolStripMenuItem.Text = "Viernes";
            this.viernesToolStripMenuItem.Click += new System.EventHandler(this.viernesToolStripMenuItem_Click);
            // 
            // sábadoToolStripMenuItem
            // 
            this.sábadoToolStripMenuItem.Name = "sábadoToolStripMenuItem";
            this.sábadoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sábadoToolStripMenuItem.Text = "Sábado";
            this.sábadoToolStripMenuItem.Click += new System.EventHandler(this.sábadoToolStripMenuItem_Click);
            // 
            // domingoToolStripMenuItem
            // 
            this.domingoToolStripMenuItem.Name = "domingoToolStripMenuItem";
            this.domingoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.domingoToolStripMenuItem.Text = "Domingo";
            this.domingoToolStripMenuItem.Click += new System.EventHandler(this.domingoToolStripMenuItem_Click);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // reporteDePagosToolStripMenuItem
            // 
            this.reporteDePagosToolStripMenuItem.Name = "reporteDePagosToolStripMenuItem";
            this.reporteDePagosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reporteDePagosToolStripMenuItem.Text = "Reporte de pagos";
            this.reporteDePagosToolStripMenuItem.Click += new System.EventHandler(this.reporteDePagosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.listarEditarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // listarEditarClientesToolStripMenuItem
            // 
            this.listarEditarClientesToolStripMenuItem.Name = "listarEditarClientesToolStripMenuItem";
            this.listarEditarClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listarEditarClientesToolStripMenuItem.Text = "Listar/Editar Clientes";
            this.listarEditarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarEditarClientesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarDBToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // configurarDBToolStripMenuItem
            // 
            this.configurarDBToolStripMenuItem.Name = "configurarDBToolStripMenuItem";
            this.configurarDBToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.configurarDBToolStripMenuItem.Text = "Configurar DB";
            this.configurarDBToolStripMenuItem.Click += new System.EventHandler(this.configurarDBToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::PrestamosV3.Properties.Resources.list0;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(162, 22);
            this.toolStripButton1.Text = "Listar Cuentas Pendientes";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::PrestamosV3.Properties.Resources.user;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton2.Text = "Nuevo Cliente";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(970, 574);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Prestamos V3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEditarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reporteDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listarCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem martesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miércolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juevesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viernesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sábadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domingoToolStripMenuItem;
    }
}

