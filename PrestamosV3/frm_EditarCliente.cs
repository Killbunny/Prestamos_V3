using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosV3
{
    public partial class frm_EditarCliente : Form
    {
        public frm_EditarCliente()
        {
            InitializeComponent();
        }

        private void frm_EditarCliente_Load(object sender, EventArgs e)
        {
            cargarTabla();
            activarComponentes();
            
        }
        public void activarComponentes()
        {
            btnEliminarCliente.Enabled = ckEditar.Checked;
            btnGuardar.Enabled = ckEditar.Checked;
            txtClienteNombre.Enabled = ckEditar.Checked;
            txtClienteDireccion.Enabled = ckEditar.Checked;
            txtClienteCiudad.Enabled = ckEditar.Checked;
            txtClienteTel1.Enabled = ckEditar.Checked;
            txtClienteTel2.Enabled = ckEditar.Checked;
            cbClienteDia.Enabled = ckEditar.Checked;
            txtClienteTel3.Enabled = ckEditar.Checked;
            txtClienteAd1.Enabled = ckEditar.Checked;
            txtClienteAd2.Enabled = ckEditar.Checked;
            txtClienteComentarios.Enabled = ckEditar.Checked;
            txtAvalNombre.Enabled = ckEditar.Checked;
            txtAvalDireccion.Enabled = ckEditar.Checked;
            txtAvalCiudad.Enabled = ckEditar.Checked;
            txtAvalTel1.Enabled = ckEditar.Checked;
            txtAvalTel2.Enabled = ckEditar.Checked;
            txtAvalAd1.Enabled = ckEditar.Checked;
            txtAvalAd2.Enabled = ckEditar.Checked;
            txtAvalComentarios.Enabled = ckEditar.Checked;
        }
        public void cargarTabla()

        {
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            string consulta = "use prestamosv3; select * from clientes;";
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            DataTable t = new DataTable();
            da.Fill(t);
            gvClientes.DataSource = t;
            gvClientes.ReadOnly = true;
            gvClientes.AllowUserToAddRows = false;
            //4.- Cerrar la conexion
            con.Close();
        }

        public void mostrarInfo()
        {
            //Mostrar info del cliente
            txtClienteID.Text = gvClientes.CurrentRow.Cells["idclientes"].Value.ToString();
            txtClienteNombre.Text = gvClientes.CurrentRow.Cells["clientenombre"].Value.ToString();
            txtClienteDireccion.Text = gvClientes.CurrentRow.Cells["clientedireccion"].Value.ToString();
            txtClienteCiudad.Text = gvClientes.CurrentRow.Cells["clienteciudad"].Value.ToString();
            txtClienteTel1.Text = gvClientes.CurrentRow.Cells["clientetel1"].Value.ToString();
            txtClienteTel2.Text = gvClientes.CurrentRow.Cells["clientetel2"].Value.ToString();
            cbClienteDia.SelectedItem = gvClientes.CurrentRow.Cells["clientedia"].Value.ToString();
            txtClienteTel3.Text = gvClientes.CurrentRow.Cells["clientetel3"].Value.ToString();
            txtClienteAd1.Text = gvClientes.CurrentRow.Cells["clienteadicional1"].Value.ToString();
            txtClienteAd2.Text = gvClientes.CurrentRow.Cells["clienteadicional2"].Value.ToString();
            txtClienteComentarios.Text = gvClientes.CurrentRow.Cells["clientecomentarios"].Value.ToString();
            //Mostrar info del aval
            txtAvalNombre.Text = gvClientes.CurrentRow.Cells["avalnombre"].Value.ToString();
            txtAvalDireccion.Text = gvClientes.CurrentRow.Cells["avaldireccion"].Value.ToString();
            txtAvalCiudad.Text = gvClientes.CurrentRow.Cells["avalciudad"].Value.ToString();
            txtAvalTel1.Text = gvClientes.CurrentRow.Cells["avaltel1"].Value.ToString();
            txtAvalTel2.Text = gvClientes.CurrentRow.Cells["avaltel2"].Value.ToString();
            txtAvalAd1.Text = gvClientes.CurrentRow.Cells["avaldicional1"].Value.ToString();
            txtAvalAd2.Text = gvClientes.CurrentRow.Cells["avaladicional2"].Value.ToString();
            txtAvalComentarios.Text = gvClientes.CurrentRow.Cells["avalcomentarios"].Value.ToString();
        }

        private void ckEditar_CheckedChanged(object sender, EventArgs e)
        {
            activarComponentes();
        }

        private void gvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarInfo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string instrucPre = "UPDATE `prestamosv3`.`clientes` SET `clientenombre`='{0}', `clientedireccion`='{1}', `clienteciudad`='{2}', `clientetel1`='{3}', `clientetel2`='{4}', `clientedia`='{5}', `clientetel3`='{6}', `clienteadicional1`='{7}', `clienteadicional2`='{8}', `clientecomentarios`='{9}', `avalnombre`='{10}', `avaldireccion`='{11}', `avalciudad`='{12}', `avaltel1`='{13}', `avaltel2`='{14}', `avaldicional1`='{15}', `avaladicional2`='{16}', `avalcomentarios`='{17}' WHERE `idclientes`='{18}';";
            string instruc = string.Format(instrucPre,
                txtClienteNombre.Text,
                txtClienteDireccion.Text,
                txtClienteCiudad.Text,
                txtClienteTel1.Text,
                txtClienteTel2.Text,
                cbClienteDia.SelectedItem,
                txtClienteTel3.Text,txtClienteAd1.Text,txtClienteAd2.Text,txtClienteComentarios.Text,txtAvalNombre.Text,txtAvalDireccion.Text,txtAvalCiudad.Text,txtAvalTel1.Text,txtAvalTel2.Text,txtAvalAd1.Text,txtAvalAd2.Text,txtAvalComentarios.Text, txtClienteID.Text);
            MySqlCommand comando = new MySqlCommand(instruc, con);
            int resultado = comando.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Informacion Actualizada");
            }
            else
            {
                MessageBox.Show("Error al realizar operación");
            }
            con.Close();
            cargarTabla();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string instruc = "DELETE FROM `prestamosv3`.`clientes` WHERE `idclientes`='{0}';";
            instruc = string.Format
                    (instruc, txtClienteID.Text);
            MySqlCommand comando = new MySqlCommand(instruc, con);
            int resultado = comando.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Eliminado");
            }
            else
            {
                MessageBox.Show("Error al realizar operación");
            }
            con.Close();
            cargarTabla();
        }
    }
}
