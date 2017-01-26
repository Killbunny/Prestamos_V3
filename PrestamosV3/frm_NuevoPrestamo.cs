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
using System.Diagnostics;
using System.Globalization;

namespace PrestamosV3
{
    public partial class frm_NuevoPrestamo : Form
    {
        DataTable tablaClientes = new DataTable();


        public frm_NuevoPrestamo()
        {
            InitializeComponent();
        }

        private void frm_NuevoPrestamo_Load(object sender, EventArgs e)
        {
            //Aquí ocurre la magia

            //1.- Crear la conexion, configurarla y abrirla
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string consulta = "select * from prestamosv3.clientes";
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            //3.- Extraer datos y manipularlos
            // DataSet ds = new DataSet();
            da.Fill(tablaClientes);
            dlClientes.DataSource = tablaClientes;
            dlClientes.DisplayMember = "clientenombre";
            dlClientes.ValueMember = "idclientes";
            con.Close();
            cbPlazo.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCliente = null;
            try
            {
                idCliente = tablaClientes.Rows[dlClientes.SelectedIndex]["idclientes"].ToString();
            }
            catch (Exception)
            {

            }
            
            bool noLetrasCuotas = System.Text.RegularExpressions.Regex.IsMatch(txtCuotas.Text, "[ ^ 0-9]");
            bool noLetrasMonto = System.Text.RegularExpressions.Regex.IsMatch(txtMonto.Text, "[ ^ 0-9]");
            //lbFlags.Text = "Cuotas: " + noLetrasCuotas.ToString()+ "\n Interes: "+noLetrasInteres.ToString() +"\n Monto: "+noLetrasMonto.ToString();
            if (idCliente == null || txtCuotas.Text == "" || txtMonto.Text == "" || !noLetrasCuotas || !noLetrasMonto)
            {
                MessageBox.Show("Revise las entradas de datos!!");
            }
            else
            {
                try
                {
                    //string fechaSiguiente = dateFechaSiguiente.Date.Year.ToString()+"-"+ dateFechaSiguiente.Date.Month.ToString() + "-" + dateFechaSiguiente.Date.Day.ToString();
                    String sqlquery = "INSERT INTO `prestamosv3`.`prestamos` (`idCliente`, `prestamoMonto`, `prestamoPlazo`, `prestamoCuota`, `prestamoNumeroCuotas`, `prestamoTotalAPagar`, `prestamoRestanteDePagar`, `prestamoFechaDesembolso`, `prestamoUltimaCuotaRegistrada`,`prestamoDia`, `prestamoCuotasPagadas`, `prestamoEstadoPago`, `prestamoAd1`, `prestamoAd2`) " +
                        " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}','{13}');";


                    //Calculos de las cuotas y demás información
                    #region Magia de Cálculos
                    double montoPrestamo = Convert.ToDouble(txtMonto.Text);
                    int numeroCuotas = Convert.ToInt16(txtCuotas.Text);
                    DateTime fecha = datePicker.Value;
                    double interes,multiplicador,cuota,totalaPagar;
                    


                    switch (cbPlazo.SelectedItem.ToString())
                    {
                        case "Semanal (5.7%)":
                            interes = 0.057692;
                            multiplicador = 1;
                            break;
                        case "Semanal (10%)":
                            interes = 0.1;
                            multiplicador = 1;
                            break;
                        case "Semanal (12%)":
                            interes = 0.12;
                            multiplicador = 1;
                            break;
                        case "Quincenal (12%)":
                            interes = 0.12;
                            multiplicador = 2;
                            break;
                        case "Quincenal (15%)":
                            interes = 0.15;
                            multiplicador = 1;
                            break;
                        case "Mensual (15%)":
                            interes = 0.15;
                            multiplicador = 2;
                            break;
                        case "Mensual (20%)":
                            interes = 0.20;
                            multiplicador = 1;
                            break;
                        case "Mensual (30%)":
                            multiplicador = 1;
                            interes = 0.30;
                            break;
                        default:
                            interes = 0.12;
                            multiplicador = 1;
                            break;
                    }
                    
                    cuota = Math.Round(montoPrestamo * interes * multiplicador);
                    totalaPagar = cuota * numeroCuotas;
                    String fechaFormateada = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    String dia =fecha.ToString("dddd",new CultureInfo("es-ES"));

                    if (numeroCuotas == 0)
                    {
                        totalaPagar = montoPrestamo;
                    }
                    #endregion

                    
                    #region Insert 
                    sqlquery = string.Format(sqlquery, dlClientes.SelectedValue.ToString(), montoPrestamo, cbPlazo.SelectedItem.ToString(), cuota, numeroCuotas, totalaPagar, totalaPagar, fechaFormateada,fechaFormateada, dia, "0", "nueva cuenta", "NO-USAR01", "NO-USAR02");
                    string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                    MySqlConnection con = new MySqlConnection(conexion);
                    con.Open();
                    MySqlCommand comando = new MySqlCommand(sqlquery, con);
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha registrado el préstamo");

                    }
                    else
                    {
                        MessageBox.Show("Error al realizar operación");
                    }
                    #endregion */
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
