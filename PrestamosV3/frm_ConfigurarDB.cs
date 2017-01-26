using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosV3
{
    public partial class frm_ConfigurarDB : Form
    {
        public frm_ConfigurarDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //una vez que se ha seleccionado la cadena procedemos a configurarla
            //formamos la cadena de conexion
            string cadConMySQL = "Server={0};Database={1};Uid={2};Pwd={3};";
            cadConMySQL = string.Format(cadConMySQL, txtServer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            //asignar la configuracion a la cadena almacenada
            // usamos un metodo de la clase SqlServerCSM
            SqlServerCSM.SaveConnectionString(txtNomCad.Text, cadConMySQL);
            MessageBox.Show("Configuración guardada");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string oldValue = config.AppSettings.Settings["LocalMySqlConnection"].Value;
            config.AppSettings.Settings["LocalMySqlConnection"].Value = cadConMySQL;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            try
            {
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                string consulta = "select * from prestamosv3.clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                DataTable t = new DataTable();
                da.Fill(t);

            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron bases de datos. \nCreando bases de datos necesarias");
                string cadCon = @"server={0};Port=3306;userid={1};password={2}";
                string cadenaprueba = 
                cadCon = string.Format(cadCon, txtServer.Text, txtUser.Text, txtPass.Text);
                MySqlConnection conn = null;
                MySqlCommand cmd;

                try
                {
                    conn = new MySqlConnection(cadCon);
                    conn.Open();

                    string crearTablaClientes = Properties.Resources.crearTablas;
                    
                    cmd = new MySqlCommand(crearTablaClientes, conn);
                    int a = cmd.ExecuteNonQuery();


                    if (a > 0)
                    {
                        MessageBox.Show("Base de datos PRESTAMOSV3 creada");
                    }


                }
                catch (MySqlException exe)

                {
                    MessageBox.Show(exe.Message);

                }
                finally

                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            this.Close();
        }

        private void lsConexiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtenemos los detalles de la cadena de conexion seleccionada de la lista
            //para ello utilizamos otro metodo de la clase SqlServerCSM
            txtCadCon.Text =
                SqlServerCSM.GetConnectionString(lsConexiones.SelectedItem.ToString());
            //enviamos el nombre de la cadena a la caja de texto
            txtNomCad.Text = lsConexiones.SelectedItem.ToString();
        }

        private void frm_ConfigurarDB_Load(object sender, EventArgs e)
        {
            List<string> ListaConexiones = SqlServerCSM.GetConnectionStringNames();
            //ya que tenemos la lista se la asignamos al componente listBox
            lsConexiones.DataSource = ListaConexiones;
            try
            {
                lsConexiones.SelectedItem = "LocalMySqlServer";

            }
            catch (Exception)
            {
                lsConexiones.SelectedIndex = 0;
            }
        }
    }
}
