using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosV3
{
    public partial class frm_ReporteClientePagoPendiente : Form
    {
        public frm_ReporteClientePagoPendiente()
        {
            InitializeComponent();
        }



        private void frm_ReporteClientePagoPendiente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            cbDia.SelectedItem = "lunes";
            this.rvVistaPrevia.RefreshReport();

            DataTable tnueva=null;

            #region Cargar gridview 
            try
            {
                //1.- Crear la conexion, configurarla y abrirla
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                //2.- Configurar la consulta y ejecutarla
                string consulta = "select prestamos.*,clientes.clientenombre,clientes.clientedireccion from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes;";

                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                //3.- Extraer datos y manipularlos
                // DataSet ds = new DataSet();
                DataTable t = new DataTable();
                t.Clear();
                da.Fill(t);
                //4.- Cerrar la conexion
                con.Close();

                gvCuentas.DataSource = t;
                gvCuentas.ReadOnly = true;
                gvCuentas.MultiSelect = false;
                gvCuentas.AllowUserToAddRows = false;

                
                DateTime dtHoy = DateTime.Today;
               // int cont = 0;
                DataTable t2 = new DataTable();
                t2.Columns.Add("clientenombre");
                t2.Columns.Add("clientedireccion");
                t2.Columns.Add("prestamocuota");
                t2.Columns.Add("Días de atraso");
                t2.Columns.Add("prestamomonto");

                gvCuentas.DefaultCellStyle.BackColor = Color.Yellow;

               
                foreach (DataGridViewRow row in gvCuentas.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    DateTime dtFecha;
                    switch (row.Cells["prestamoPlazo"].Value.ToString())
                    {
                        case "Semanal (5.7%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(7);
                            break;
                        case "Semanal (10%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(7);
                            break;
                        case "Semanal (12%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(7);
                            break;
                        case "Quincenal (12%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(14);
                            break;
                        case "Quincenal (15%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(14);
                            break;
                        case "Mensual (15%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddMonths(1);
                            break;
                        case "Mensual (20%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddMonths(1);
                            break;
                        case "Mensual (30%)":
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddMonths(1);
                            break;
                        default:
                            dtFecha = DateTime.Parse(row.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString()).Date.AddDays(7);
                            break;
                    }
                    if (dtFecha.Date <= dtHoy.Date)
                    {
                        double dias = (dtHoy - dtFecha).TotalDays;
                        double pago = dias * 50;
                        DataRow drow = (row.DataBoundItem as DataRowView).Row;
                        //MessageBox.Show(drow[0].ToString()+"\n"+ drow[1].ToString() + "\n" +drow[2].ToString() + "\n" +  drow[3].ToString() + "\n" +drow[4].ToString() + "\n" +  drow[5].ToString() + "\n" +drow[6].ToString() + "\n" + drow[7].ToString() + "\n" +drow[8].ToString() + "\n" + drow[9].ToString() + "\n" +drow[10].ToString() + "\n" +drow[11].ToString() + "\n" +drow[12].ToString() + "\n" +drow[13].ToString() + "\n" +drow[14].ToString() + "\n" +drow[15].ToString() + "\n" );
                        t2.Rows.Add(drow[15].ToString(), drow[16].ToString(), Convert.ToInt32(drow[4]), dias.ToString(), Convert.ToInt32(drow[4])+pago);
                    }

                }
                t.Clear();
                gvCuentas.DataSource = null;
                gvCuentas.Rows.Clear();
                gvCuentas.Refresh();
                if (t2.Rows.Count > 0)
                {
                    //MessageBox.Show("Hay cuentas a pagar hoy!");
                    gvCuentas.DataSource = t2;
                    tnueva = t2;
                }
                else
                {
                    MessageBox.Show("Todas las cuentas están al día");

                }
                //lbCont.Text = cont.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operacion"+ex.Message);
            }
            #endregion

            File.WriteAllBytes(System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc", Properties.Resources.Report1);

            rvVistaPrevia.Clear();
            rvVistaPrevia.LocalReport.DataSources.Clear();

            rvVistaPrevia.LocalReport.ReportPath = System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc";
            rvVistaPrevia.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", tnueva));
            rvVistaPrevia.RefreshReport();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbDia.SelectedItem.ToString() != "hoy" || cbDia.SelectedItem.ToString() != "mañana" || cbDia.SelectedItem.ToString() != "todos")
            {
                
                #region "select"
                // muestra el contenido de la tabla en el grid

                //1.- Crear la conexion, configurarla y abrirla
                //string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                //2.- Configurar la consulta y ejecutarla
                string consulta = "select clientes.clientenombre,clientes.clientedireccion,prestamos.prestamoCuota,prestamos.prestamoMonto,prestamos.prestamoDia,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes where prestamoDia='" + cbDia.SelectedItem.ToString() + "';";

                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                
                
                //3.- Extraer datos y manipularlos
                DataSet ds = new DataSet();
                da.Fill(ds);
                //generar un xml como origen de datos
                ds.WriteXml(System.Environment.GetEnvironmentVariable("TEMP") + @"\datos.xml");

                //MessageBox.Show("XMLeado");

                File.WriteAllBytes(System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc", Properties.Resources.Report1);

                rvVistaPrevia.Clear();
                rvVistaPrevia.LocalReport.DataSources.Clear();

                rvVistaPrevia.LocalReport.ReportPath = System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc";
                rvVistaPrevia.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
                rvVistaPrevia.RefreshReport();
                //4.- Cerrar la conexion
                con.Close();
                #endregion
            }
            
        }

        private void cbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
               
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region "select"
            // muestra el contenido de la tabla en el grid

            //1.- Crear la conexion, configurarla y abrirla
            //string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string consulta = "select clientes.clientenombre,clientes.clientedireccion,prestamos.prestamoCuota,prestamos.prestamoMonto,prestamos.prestamoDia,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes where prestamos.prestamoEstadoPago='nueva cuenta' OR 'pendiente';";

            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            //3.- Extraer datos y manipularlos
            DataSet ds = new DataSet();
            da.Fill(ds);
            //generar un xml como origen de datos
            ds.WriteXml(System.Environment.GetEnvironmentVariable("TEMP") + @"\datos.xml");
            //MessageBox.Show("XMLeado");
            File.WriteAllBytes(System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc", Properties.Resources.Report1);

            rvVistaPrevia.Clear();
            rvVistaPrevia.LocalReport.DataSources.Clear();
            rvVistaPrevia.LocalReport.ReportPath = System.Environment.GetEnvironmentVariable("TEMP") + @"\Report1.rdlc";
            rvVistaPrevia.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
            rvVistaPrevia.RefreshReport();
            //4.- Cerrar la conexion
            con.Close();
            #endregion
        }
    }
}
