using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PrestamosV3
{
    public partial class frm_Main : Form
    {
        //Variables de la forma




        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.White;
                    // 4#
                    break;
                }
            }
        }

      

        private void configurarDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ConfigurarDB)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ConfigurarDB f = new frm_ConfigurarDB();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("pendiente");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_NuevoCliente)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_NuevoCliente f = new frm_NuevoCliente();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_NuevoCliente)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_NuevoCliente f = new frm_NuevoCliente();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void listarEditarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_EditarCliente)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_EditarCliente f = new frm_EditarCliente();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void nuevoPréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_NuevoPrestamo)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_NuevoPrestamo f = new frm_NuevoPrestamo();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void reporteDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ReporteClientePagoPendiente)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ReporteClientePagoPendiente f = new frm_ReporteClientePagoPendiente();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frm_CrystalReports v = new frm_CrystalReports();
            v.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("pendiente");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void lunesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("lunes");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void martesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("martes");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void miércolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("miércoles");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void juevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("jueves");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void viernesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("viernes");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void sábadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("sábado");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void domingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_ListarCuentas f = new frm_ListarCuentas("domingo");
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is frm_ListarCuentas)
                {
                    f.Focus();
                    isOpen = true;
                    return;
                }
            }
            if (!isOpen)
            {
                frm_CrystalReports f = new frm_CrystalReports();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
