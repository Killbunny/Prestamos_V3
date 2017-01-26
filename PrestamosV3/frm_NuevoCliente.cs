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
    public partial class frm_NuevoCliente : Form
    {
        public frm_NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtClienteNombre.Text.Trim() != "" && txtClienteDireccion.Text.Trim() != "" && (txtClienteTel1.Text.Trim() != "" || txtClienteTel2.Text.Trim() != ""))
                {
                    string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                    MySqlConnection con = new MySqlConnection(conexion);
                    con.Open();
                
                //2.- Configurar la consulta y ejecutarla
                string instruc = "INSERT INTO `prestamosv3`.`clientes` " +
                    "(`clientenombre`, `clientedireccion`, `clienteciudad`, `clientetel1`, `clientetel2`, `clientedia`, `clientetel3`, `clienteadicional1`, `clienteadicional2`, `clientecomentarios`," +
                    " `avalnombre`, `avaldireccion`, `avalciudad`, `avaltel1`, `avaltel2`, `avaldicional1`, `avaladicional2`, `avalcomentarios`)" +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}');";
                instruc = string.Format(instruc, txtClienteNombre.Text, txtClienteDireccion.Text, txtClienteCiudad.Text, txtClienteTel1.Text, txtClienteTel2.Text, cbClienteDia.SelectedItem.ToString(), txtClienteTel3.Text, txtClienteAd1.Text, txtClienteAd2.Text, txtClienteComentarios.Text,txtAvalNombre.Text, txtAvalDireccion.Text, txtAvalCiudad.Text, txtAvalTel1.Text, txtAvalTel2.Text, txtClienteAd1.Text, txtClienteAd2.Text, txtAvalComentarios.Text);
                Console.WriteLine(instruc);
                MySqlCommand comando = new MySqlCommand(instruc, con);
                int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Nuevo Cliente Registrado");

                    }
                    else
                    {
                        MessageBox.Show("Error al realizar operación");
                    }
                    
                }
                
                else
                {
                    MessageBox.Show("No se registro nuevo cliente.\nEl nombre y direccion no pueden estar Vacíos \nDebe haber al menos un teléfono ");
                }
                
                        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_NuevoCliente_Load(object sender, EventArgs e)
        {
            cbClienteDia.SelectedIndex = 0;
        }

        private void cbClienteDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
