using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Caluladora_Prestamo
{
    public partial class FrmPrestamo : Form
    {
        string tipo;
        float calculo;
        Mantenimiento mantenimiento = new Mantenimiento();
        List<Tarifa> tarifa;
        List<Cliente> cliente;
        Controles controls = new Controles();
        BuscarClientes BuscarClient = new BuscarClientes();
        




        public FrmPrestamo()
        {
            InitializeComponent();
            
        }
        

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
           tarifa = mantenimiento.SelectTarifa();
            RdbDiario.Select();
            ClearCmb();
            CargarComoBox();
            CmbMonto.SelectedIndex = 0;
            cliente = mantenimiento.SelectClietes();




        }
          


        

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

          

            if(ListDetalle.Items.Count < 1 || TxtNombres.Text.Length ==0 || TxtApellidos.Text.Length == 0 || TxtCedula.Text.Length ==0 )

            {
                MessageBox.Show("Tiene que calcular el prestamo antes de guardar", "Calcule..", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {

              Prestamo campos = new Prestamo
                {
                    ID_CLIENTE = Convert.ToInt16(TxtCodigo.Text),
                    TIPO = tipo,
                    MONTO = float.Parse(CmbMonto.Text),
                    MONTO_CUOTA = float.Parse(CmbPagoXdia.Text),
                    NO_CUOTA = Convert.ToInt16(CmbNoCuota.Text),
                    MONTO_CALCULADO = calculo,
                    FECHA_PRESTAMO = TxtFechaPrestamo.Text
                    


                };

                mantenimiento.InsertPrestamo(campos);
                controls.Limpiar(groupBox1, groupBox2);
                ListDetalle.Items.Clear();

                MessageBox.Show("Prestamo guardado!", "Guardando...",MessageBoxButtons.OK, MessageBoxIcon.Information);
              


            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
             controls.Limpiar(groupBox1,groupBox2);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtNombres.Text.Length == 0 || TxtApellidos.Text.Length == 0 || TxtCedula.Text.Length == 0)
            {

                MessageBox.Show("Seleccione un cliente por favor", "Cliente vacio!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            else
            {
                if (ListDetalle.Items.Count > 1)
                {

                    MessageBox.Show("Seleccione otro cliente", "Ya tiene un cliente", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {

                    if (RdbMensual.Checked)
                    {
                        tipo = "MENSUAL";

                    }
                    else if (RdbDiario.Checked)
                    {

                        tipo = "DIARIO";

                    }
                    calculo = (float.Parse(CmbPagoXdia.Text) * float.Parse(CmbNoCuota.Text));

                    ListDetalle.Items.Add("         INVERSIONES SANTANA         ");
                    //ListDetalle.Items.Add("***********************************");
                    // ListDetalle.Items.Add("");
                    ListDetalle.Items.Add("                FECHA :" + TxtFechaPrestamo.Text);
                    ListDetalle.Items.Add("");
                    ListDetalle.Items.Add("Codigo cliente: " + TxtCodigo.Text);
                    ListDetalle.Items.Add("Cliente :" + TxtNombres.Text + " " + TxtApellidos.Text);
                    ListDetalle.Items.Add("MONTO PRESTADO RD$: " + CmbMonto.Text);
                    //ListDetalle.Items.Add("");
                    ListDetalle.Items.Add("PAGO " + tipo + " RD$: " + CmbPagoXdia.Text);
                    //ListDetalle.Items.Add("");
                    ListDetalle.Items.Add("CANTIDAD DE CUOTAS " + CmbNoCuota.Text);
                    // ListDetalle.Items.Add("");
                    ListDetalle.Items.Add("TOTAL A PAGAR RD$: " + calculo);
                    // controls.Limpiar(groupBox1);

                }

            }

        }

        private void CmbMonto_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbPagoXdia.SelectedIndex = CmbMonto.SelectedIndex;
            CmbNoCuota.SelectedIndex = CmbMonto.SelectedIndex;
           

        }

        private void CargarComoBox()
        {

            foreach (var datos in tarifa)
            {

                if (RdbDiario.Checked && datos.TIPO == 1)
                {
                    CmbMonto.Items.Add(datos.MONTO.ToString());
                    CmbPagoXdia.Items.Add(datos.MONTO_CUOTA.ToString());
                    CmbNoCuota.Items.Add(datos.NO_CUOTA.ToString());
                    
                }
                else if (RdbMensual.Checked && datos.TIPO == 0)
                {
                    CmbMonto.Items.Add(datos.MONTO.ToString());
                    CmbPagoXdia.Items.Add(datos.MONTO_CUOTA.ToString());
                    CmbNoCuota.Items.Add(datos.NO_CUOTA.ToString());
                }
                



            }



        }

        private void RdbDiario_CheckedChanged(object sender, EventArgs e)
        {
            ClearCmb();
            CargarComoBox();
            
        }

        private void RdbMensual_CheckedChanged(object sender, EventArgs e)
        {
            ClearCmb();
            CargarComoBox();
        }
        private void ClearCmb()
        {
            CmbPagoXdia.Items.Clear();
            CmbMonto.Items.Clear();
            CmbNoCuota.Items.Clear();

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {

            BuscarClient.ShowDialog();

        }

        private void FrmPrestamo_Activated(object sender, EventArgs e)
        {

          /* if (BuscarClientes.idCliente != 0)
            {*/

                ListDetalle.Items.Clear();

                foreach (var campos in cliente)
                {
                    if(BuscarClientes.idCliente == campos.ID_CLIENTE )
                    { 
                    TxtCodigo.Text = campos.ID_CLIENTE.ToString();
                    TxtNombres.Text = campos.NOMBRES.ToString();
                    TxtApellidos.Text = campos.APELLIDOS.ToString();
                    TxtCedula.Text = campos.CEDULA.ToString();
                    TxtCelular.Text = campos.CELULAR.ToString();
                    TxtDireccion.Text = campos.DIRECCION.ToString();
                    }

                }


            //}

           BuscarClientes.idCliente = 0;
            TxtFechaPrestamo.Text = DateTime.Now.ToString("dd-MM-yyyy");



        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }

            if (e.KeyChar == '\r')
            {



                ListDetalle.Items.Clear();


                foreach (var campos in cliente)
                {
                    if (Convert.ToInt32(TxtBuscar.Text) == campos.ID_CLIENTE && TxtBuscar.Text.Length <= 6)
                    {
                        TxtCodigo.Text = campos.ID_CLIENTE.ToString();
                        TxtNombres.Text = campos.NOMBRES.ToString();
                        TxtApellidos.Text = campos.APELLIDOS.ToString();
                        TxtCedula.Text = campos.CEDULA.ToString();
                        TxtCelular.Text = campos.CELULAR.ToString();
                        TxtDireccion.Text = campos.DIRECCION.ToString();
                    }
                }

                //cliente.Clear();
                TxtBuscar.Clear();
                TxtFechaPrestamo.Text = DateTime.Now.ToString("dd-MM-yyyy");
             
                

               

            }
        }
    }
}

