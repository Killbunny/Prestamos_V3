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
    public partial class frm_ListarCuentas : Form
    {

        DataTable t = new DataTable();
        string busqueda;



        public frm_ListarCuentas()
        {
            InitializeComponent();
        }

        public frm_ListarCuentas(string busqueda)
        {
            this.busqueda = busqueda;
            InitializeComponent();
        }


        public void recolorearTabla()
        {
            DateTime dtHaceDosSemanas = DateTime.Today.Date.Subtract(new TimeSpan(14, 0, 0, 0));
            foreach (DataGridViewRow row in gvCuentas.Rows)
                if (row.Cells["prestamoEstadoPago"].Value.ToString() == "pendiente")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }

            foreach (DataGridViewRow row in gvCuentas.Rows)
                if (row.Cells["prestamoEstadoPago"].Value.ToString() == "saldado")
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
            foreach (DataGridViewRow row in gvCuentas.Rows)
                if (Convert.ToInt32(row.Cells["prestamoCuotasPagadas"].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Cyan;
                }


            //foreach (DataGridViewRow row in gvCuentas.Rows)
            //    if (DateTime.Parse(row.Cells["ultimacuota"].Value.ToString()) <= dtHaceDosSemanas.Date)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            
        }


        private void cargarTabla()
        {
            //1.- Crear la conexion, configurarla y abrirla
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string consulta;
            if (this.busqueda == "pendiente")
            {
                consulta = "use prestamosv3; select prestamos.*,clientes.clientenombre,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes where prestamoEstadoPago='pendiente' or prestamoEstadoPago='nueva cuenta'";
                // consulta = "select prestamos.*,clientes.nombre from prestamos inner join clientes on prestamos.cliente=clientes.idclientes;";
                this.Text = "Listado de Cuentas (Pendientes)";
            }
            else if (this.busqueda == "lunes" || this.busqueda == "martes" || this.busqueda == "miércoles" || this.busqueda == "jueves" || this.busqueda == "viernes" || this.busqueda == "sábado" || this.busqueda == "domingo")
            {
                consulta = "use prestamosv3; select prestamos.*,clientes.clientenombre,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes where prestamoDia='" + busqueda + "'";
                // consulta = "select prestamos.*,clientes.nombre from prestamos inner join clientes on prestamos.cliente=clientes.idclientes;";
                this.Text = "Listado de Cuentas (" + busqueda + ")";
            }
            else
            {
                consulta = "use prestamosv3; select prestamos.*,clientes.clientenombre,clientes.clientedia from prestamos inner join clientes on prestamos.idCliente=clientes.idclientes";
            this.Text = "Listado de Cuentas (Todos)";
            }

            MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
            //3.- Extraer datos y manipularlos
            t.Clear();
            da.Fill(t);
            //4.- Cerrar la conexion
            con.Close();

            gvCuentas.DataSource = t;
            gvCuentas.ReadOnly = true;
            gvCuentas.MultiSelect = false;
            gvCuentas.AllowUserToAddRows = false;
            //Columnas que no se necesitan mostrar
            gvCuentas.Columns["idprestamos"].Visible = false;
            gvCuentas.Columns["idcliente"].Visible = false;
            gvCuentas.Columns["prestamoAd1"].Visible = false;
            gvCuentas.Columns["prestamoAd2"].Visible = false;
            gvCuentas.Columns["prestamoRestanteDePagar"].Visible = false;

            //Nomenclatura de la columna
            gvCuentas.Columns["idPrestamos"].HeaderText = "ID Préstamo";
            gvCuentas.Columns["idCliente"].HeaderText = "ID Cliente";
            gvCuentas.Columns["prestamoMonto"].HeaderText = "Monto del Préstamo";
            gvCuentas.Columns["prestamoPlazo"].HeaderText = "Tipo de plazo";
            gvCuentas.Columns["prestamoCuota"].HeaderText = "Cuota";
            gvCuentas.Columns["prestamoNumeroCuotas"].HeaderText = "Número de Cuotas";
            gvCuentas.Columns["prestamoTotalAPagar"].HeaderText = "Total a pagar";
            gvCuentas.Columns["prestamoRestanteDePagar"].HeaderText = "Restante por pagar";
            gvCuentas.Columns["prestamoFechaDesembolso"].HeaderText = "Fecha de Desembolso";
            gvCuentas.Columns["prestamoUltimaCuotaRegistrada"].HeaderText = "Última cuota registrada";
            gvCuentas.Columns["prestamoDia"].HeaderText = "Dia del préstamo";
            gvCuentas.Columns["prestamoCuotasPagadas"].HeaderText = "Cuotas pagadas";
            gvCuentas.Columns["prestamoEstadoPago"].HeaderText = "Estado de la cuenta";
            gvCuentas.Columns["prestamoAd1"].HeaderText = "XXXXXX";
            gvCuentas.Columns["prestamoAd1"].HeaderText = "XXXXXX";
            gvCuentas.Columns["clientenombre"].HeaderText = "Nombre";
            gvCuentas.Columns["clientedia"].HeaderText = "Día del Cliente";

            //Ordenamiento de las columnas
            gvCuentas.Columns["clientenombre"].DisplayIndex = 0;
            gvCuentas.Columns["prestamoMonto"].DisplayIndex = 1;
            gvCuentas.Columns["prestamoCuota"].DisplayIndex = 2;
            gvCuentas.Columns["prestamoTotalAPagar"].DisplayIndex = 3;
            gvCuentas.Columns["prestamoRestanteDePagar"].DisplayIndex = 4;
            gvCuentas.Columns["prestamoPlazo"].DisplayIndex = 5;
            gvCuentas.Columns["prestamoNumeroCuotas"].DisplayIndex = 6;
            gvCuentas.Columns["prestamoCuotasPagadas"].DisplayIndex = 7;
            gvCuentas.Columns["prestamoFechaDesembolso"].DisplayIndex = 8;
            gvCuentas.Columns["prestamoUltimaCuotaRegistrada"].DisplayIndex = 9;
            gvCuentas.Columns["prestamoDia"].DisplayIndex = 10;
            gvCuentas.Columns["clientedia"].DisplayIndex = 11;
            gvCuentas.Columns["prestamoEstadoPago"].DisplayIndex = 12;

        }

        public void mostrarInfo()
        {


            try
            {
                txtNombre.Text = gvCuentas.CurrentRow.Cells["clientenombre"].Value.ToString();
                txtMontoDelPrestamo.Text = gvCuentas.CurrentRow.Cells["prestamoMonto"].Value.ToString();
                txtCuotasPagadas.Text = gvCuentas.CurrentRow.Cells["prestamoCuotasPagadas"].Value.ToString();
                txtTipoPlazo.Text = gvCuentas.CurrentRow.Cells["prestamoPlazo"].Value.ToString();
                txtNumeroCuotas.Text = gvCuentas.CurrentRow.Cells["prestamoNumeroCuotas"].Value.ToString();
                txtFechaPrestamo.Text = gvCuentas.CurrentRow.Cells["prestamoFechaDesembolso"].Value.ToString().Substring(0, 10);
                txtFechaUltimaCuota.Text = gvCuentas.CurrentRow.Cells["prestamoUltimaCuotaRegistrada"].Value.ToString().Substring(0, 10);
                double interes;
                double multiplicador = 1;
                string plazo;
                switch (txtTipoPlazo.Text)
                {
                    case "Semanal (10%)":
                        txtTasaDeInteres.Text = "10%";
                        plazo = "semanal";
                        interes = .10;
                        break;
                    case "Semanal (12%)":
                        txtTasaDeInteres.Text = "12%";
                        plazo = "semanal";
                        interes = .12;
                        break;
                    case "Quincenal (12%)":
                        txtTasaDeInteres.Text = "12%";
                        plazo = "quincenal";
                        interes = .12;
                        multiplicador = 2;
                        break;
                    case "Quincenal (15%)":
                        txtTasaDeInteres.Text = "15%";
                        plazo = "quincenal";
                        interes = .15;
                        break;
                    case "Mensual (15%)":
                        txtTasaDeInteres.Text = "15%";
                        plazo = "mensual";
                        interes = .15;
                        multiplicador = 2;
                        break;
                    case "Mensual (20%)":
                        txtTasaDeInteres.Text = "20%";
                        plazo = "mensual";
                        interes = .20;
                        break;
                    case "Mensual (30%)":
                        txtTasaDeInteres.Text = "30%";
                        plazo = "mensual";
                        interes = .30;
                        break;
                    default:
                        txtTasaDeInteres.Text = "12%";
                        plazo = "semanal";
                        interes = .30;
                        break;
                }

                txtCuota.Text = (Convert.ToDouble(txtMontoDelPrestamo.Text) * interes * multiplicador).ToString();
                txtCuotasPendientes.Text = (Convert.ToDouble(txtNumeroCuotas.Text) - Convert.ToDouble(txtCuotasPagadas.Text)).ToString();

                txtTotalAPagar.Text = (Convert.ToDouble(txtCuota.Text) * Convert.ToDouble(txtNumeroCuotas.Text)).ToString();
                txtTotalIntereses.Text = (Convert.ToDouble(txtTotalAPagar.Text) - Convert.ToDouble(txtMontoDelPrestamo.Text)).ToString();

                DateTime dtimeUltimaCuota = DateTime.Parse(txtFechaPrestamo.Text);
                DateTime dtimeSiguienteCuota = dtimeUltimaCuota;
                switch (plazo)
                {
                    case "semanal":
                        for (int i = 0; i < Convert.ToInt32(txtNumeroCuotas.Text); i++)
                        {
                            dtimeUltimaCuota = dtimeUltimaCuota.AddDays(7);
                        }
                        for (int i = -1; i < Convert.ToInt32(txtCuotasPagadas.Text); i++)
                        {
                            dtimeSiguienteCuota = dtimeSiguienteCuota.AddDays(7);
                        }
                        break;
                    case "quincenal":
                        for (int i = 0; i < Convert.ToInt32(txtNumeroCuotas.Text); i++)
                        {
                            dtimeUltimaCuota = dtimeUltimaCuota.AddDays(14);
                        }
                        for (int i = -1; i < Convert.ToInt32(txtCuotasPagadas.Text); i++)
                        {
                            dtimeSiguienteCuota = dtimeSiguienteCuota.AddDays(14);
                        }
                        break;
                    case "mensual":
                        for (int i = 0; i < Convert.ToInt32(txtNumeroCuotas.Text); i++)
                        {
                            dtimeUltimaCuota = dtimeUltimaCuota.AddMonths(1);
                        }
                        for (int i = -1; i < Convert.ToInt32(txtCuotasPagadas.Text); i++)
                        {
                            dtimeSiguienteCuota = dtimeSiguienteCuota.AddMonths(1);
                        }
                        break;
                }
                txtUltimaCuota.Text = dtimeUltimaCuota.ToShortDateString();
                txtSiguienteCuota.Text = dtimeSiguienteCuota.ToShortDateString();
                txtFechaDeVencimiento.Text = dtimeSiguienteCuota.AddDays(1).ToShortDateString();



                txtLiquida.Text = (Convert.ToDouble(txtTotalAPagar.Text) - (Convert.ToDouble(txtCuota.Text) * Convert.ToDouble(txtCuotasPagadas.Text))).ToString();
            }
            catch (Exception)
            {

                //MessageBox.Show("Error en la operación! \n" + ex.Message);
            }


        }

        private void activarComponentes()
        {
            pEditar.Visible = chkEditar.Checked;
            txtNumeroCuotas.Enabled = chkEditar.Checked;
            txtCuotasPagadas.Enabled = chkEditar.Checked;
            if(chkEditar.Checked)
            {
                txtNumeroCuotas.BackColor = Color.Yellow;
                txtCuotasPagadas.BackColor = Color.Yellow;
            }
            else
            {
                txtNumeroCuotas.BackColor = txtNombre.BackColor;
                txtCuotasPagadas.BackColor = txtNombre.BackColor;
            }
        }

        private void frm_ListarCuentas_Load(object sender, EventArgs e)
        {
            activarComponentes();

        }

        private void frm_ListarCuentas_Activated(object sender, EventArgs e)
        {
            cargarTabla();
            recolorearTabla();
        }

        private void gvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO CARGAR DATOS A LOS CAMPOS
            mostrarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Liquidar cuenta", "Liquidar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            { return; }
            //1.- Crear la conexion, configurarla y abrirla
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string consulta = "UPDATE `prestamosv3`.`prestamos` SET prestamoCuotasPagadas = prestamoNumeroCuotas  WHERE idprestamos = " + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString(); ;
            MySqlCommand comando = new MySqlCommand(consulta, con);
            int resultado = comando.ExecuteNonQuery();
            consulta = "UPDATE `prestamosv3`.`prestamos` SET prestamoUltimaCuotaRegistrada = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE idprestamos = " + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString();
            comando = new MySqlCommand(consulta, con);
            int resultado2 = comando.ExecuteNonQuery();

            consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='saldado' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
            comando = new MySqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            //3.- Cerrar la conexion
            con.Close();
            cargarTabla();
            mostrarInfo();
            recolorearTabla();
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            activarComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //1.- Crear la conexion, configurarla y abrirla
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                //2.- Configurar la consulta y ejecutarla
                string consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoNumeroCuotas`={0}, `prestamoMonto`={1}, `prestamoCuotasPagadas`={2} WHERE `idprestamos`=" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString();
                consulta = string.Format(consulta, txtNumeroCuotas.Text, txtMontoDelPrestamo.Text, txtCuotasPagadas.Text);
                MySqlCommand comando = new MySqlCommand(consulta, con);
                int resultado = comando.ExecuteNonQuery();
                consulta = "UPDATE `prestamosv3`.`prestamos` SET prestamoUltimaCuotaRegistrada = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE idprestamos = " + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString();
                comando = new MySqlCommand(consulta, con);
                int resultado2 = comando.ExecuteNonQuery();
                if (resultado > 0 && txtCuotasPagadas.Text != txtNumeroCuotas.Text)
                {
                    MessageBox.Show("Actualización realizada");


                }
                else if (resultado > 0 && txtCuotasPagadas.Text == txtNumeroCuotas.Text)
                {
                    MessageBox.Show("La cuenta ya ha sido pagada");
                    consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='saldado' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
                    comando = new MySqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                }
                if (resultado > 0 && Convert.ToDouble(txtCuotasPagadas.Text) < Convert.ToDouble(txtNumeroCuotas.Text))
                {
                    //MessageBox.Show("La cuenta sesificó como pendiente");
                    consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='pendiente' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
                    comando = new MySqlCommand(consulta, con);
                    comando.ExecuteNonQuery();

                }


                //3.- Cerrar la conexion
                con.Close();
                cargarTabla();
                mostrarInfo();
                recolorearTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operación!!\n"+ex.Message);
            }
        }

        private void gvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            #region 
            //1.- Crear la conexion, configurarla y abrirla
            string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
            MySqlConnection con = new MySqlConnection(conexion);
            con.Open();
            //2.- Configurar la consulta y ejecutarla
            string consulta = "UPDATE `prestamosv3`.`prestamos` SET prestamoCuotasPagadas = if (prestamoCuotasPagadas < prestamoNumeroCuotas, prestamoCuotasPagadas + 1,prestamoCuotasPagadas)  WHERE idPrestamos = " + gvCuentas.CurrentRow.Cells["idPrestamos"].Value.ToString();
            MySqlCommand comando = new MySqlCommand(consulta, con);
            int resultado = comando.ExecuteNonQuery();
            consulta = "UPDATE `prestamosv3`.`prestamos` SET prestamoUltimaCuotaRegistrada = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' WHERE idprestamos = " + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString();
            comando = new MySqlCommand(consulta, con);
            int resultado2 = comando.ExecuteNonQuery();
            if (resultado > 0 && txtCuotasPagadas.Text != txtNumeroCuotas.Text)
            {
                MessageBox.Show("Pago de cuota Registrado");
                if (txtCuotasPendientes.Text == "1")
                {
                    consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='saldado' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
                    comando = new MySqlCommand(consulta, con);
                    comando.ExecuteNonQuery();
                }
                else
                {
                    consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='pendiente' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
                    comando = new MySqlCommand(consulta, con);
                    comando.ExecuteNonQuery();
                }

            }
            else if (txtNumeroCuotas.Text == "0")
            {
                MessageBox.Show("Pago de cuota Registrado");

                consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='pendiente' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';" +
               "UPDATE `prestamosv3`.`prestamos` SET `prestamoCuotasPagadas`=prestamoCuotasPagadas + 1 WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";

                comando = new MySqlCommand(consulta, con);
                comando.ExecuteNonQuery();
            }
            else if (resultado > 0 && txtCuotasPagadas.Text == txtNumeroCuotas.Text && txtNumeroCuotas.Text != "0")
            {
                MessageBox.Show("La cuenta ya ha sido pagada");
                consulta = "UPDATE `prestamosv3`.`prestamos` SET `prestamoEstadoPago`='saldado' WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "';";
                comando = new MySqlCommand(consulta, con);
                comando.ExecuteNonQuery();

            } 
            else
            {
                MessageBox.Show("Error al realizar la operación!!" );
            }

            //3.- Cerrar la conexion
            con.Close();
            cargarTabla();
            mostrarInfo();
            recolorearTabla();
            #endregion
        }

        private void btnSuprimir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Eliminar Registro? \n Esta acción es irreversible", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //1.- Crear la conexion, configurarla y abrirla
                string conexion = SqlServerCSM.GetConnectionString("LocalMySqlServer");
                MySqlConnection con = new MySqlConnection(conexion);
                con.Open();
                //2.- Configurar la consulta y ejecutarla
                string consulta = "DELETE FROM `prestamosv3`.`prestamos` WHERE `idprestamos`='" + gvCuentas.CurrentRow.Cells["idprestamos"].Value.ToString() + "'";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0 && txtCuotasPagadas.Text != txtNumeroCuotas.Text)
                {
                    MessageBox.Show("Registro eliminado");
                }
                //3.- Cerrar la conexion
                con.Close();
                cargarTabla();
                mostrarInfo();
                recolorearTabla();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
