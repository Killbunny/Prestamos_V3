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
using CrystalDecisions.CrystalReports.Engine;
using System.Reflection;
using System.IO;

namespace PrestamosV3
{
    public partial class frm_CrystalReports : Form
    {
        public frm_CrystalReports()
        {
            InitializeComponent();
        }

        private void frm_CrystalReports_Load(object sender, EventArgs e)
        {

            #region "select"
            // muestra el contenido de la tabla en el grid

            //1.- Crear la conexion, configurarla y abrirla
            //string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");

            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            
            //2.- Configurar la consulta y ejecutarla
            string consulta = "select clientes.clientenombre,clientes.clientedireccion,prestamos.prestamoCuota,prestamos.prestamoMonto,prestamos.prestamoDia,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes ;";
            
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            //3.- Extraer datos y manipularlos
            DataSet ds = new DataSet();
            da.Fill(ds);
            //generar un xml como origen de datos
            ds.WriteXml(System.Environment.GetEnvironmentVariable("TEMP") + @"\datos.xml");
            MessageBox.Show("1");
            ds.ReadXml(System.Environment.GetEnvironmentVariable("TEMP") + @"\datos.xml");
            #endregion

            ReportDocument Report = new ReportDocument();
            File.WriteAllBytes(System.Environment.GetEnvironmentVariable("TEMP") + @"\CrystalReport1.rpt", Properties.Resources.CrystalReport1);

            Report.Load(System.Environment.GetEnvironmentVariable("TEMP") + @"\CrystalReport1.rpt");
            
            Report.Database.Tables[0].SetDataSource(ds.Tables[0]);
            MessageBox.Show("");
            crystalReportViewer1.ReportSource = Report;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
