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
    public partial class FrmCobros : Form
    {
        Mantenimiento mantenimiento = new Mantenimiento();
        Controles controls = new Controles();
        List<join_prestamo> Join_prestamo;
        List<Pagos> pagos;
        int Tcuota;
        float Tmonto;

        public FrmCobros()
        {
            InitializeComponent();
        }

        private void FrmCobros_Load(object sender, EventArgs e)
        {

            Join_prestamo = mantenimiento.SelectJoinPrestamo();
            pagos = mantenimiento.SelectPagos();

            DgvCobros.Columns.Add("FECHA", "F E C H A");
            DgvCobros.Columns.Add("MONTO", "M O N T O");
            DgvCobros.Columns.Add("ID_PRESTAMO", "ID_PRESTAMO");
            DgvCobros.Columns.Add("TIPO","TIPO");
            DgvCobros.Columns.Add("NO_CUOTA", "NO_CUOTA");
            DgvCobros.Columns.Add("MONTO_CUOTA", "MONTO_CUOTA");
            DgvCobros.Columns.Add("MONTO_CALCULADO", "MONTO_CALCULADO");
            OrganizarDgv();


            



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            controls.Limpiar(groupBox1,groupBox2);
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            new BuscarClientes().ShowDialog();
        }

        private void FrmCobros_Activated(object sender, EventArgs e)
        {



            ListDetalle.Items.Clear();
            DgvCobros.Rows.Clear();
           
            
            foreach (var campos in Join_prestamo)
                {
                    if (BuscarClientes.idCliente == Convert.ToInt16(campos.ID_CLIENTE))
                    {

                        TxtCodigo.Text = campos.ID_CLIENTE.ToString();
                        TxtNombres.Text = campos.NOMBRES.ToString();
                        TxtApellidos.Text = campos.APELLIDOS.ToString();
                        TxtCedula.Text = campos.CEDULA.ToString();
                        TxtCelular.Text = campos.CELULAR.ToString();

                    
                    DgvCobros.Rows.Add( campos.FECHA_PRESTAMO.ToString().Remove(10,15) , campos.MONTO.ToString(),
                       campos.ID_PRESTAMO.ToString(), campos.TIPO.ToString(), campos.NO_CUOTA.ToString(),campos.MONTO_CUOTA.ToString(),
                        campos.MONTO_CALCULADO.ToString()
                        
                        );
                      

            

                    }



                }

            BuscarClientes.idCliente = 0;

        }


        private void OrganizarDgv()
        {

            DgvCobros.Columns["FECHA"].Width = 125;
            DgvCobros.Columns["MONTO"].Width = 125;
            DgvCobros.Columns["ID_PRESTAMO"].Visible = false;
            DgvCobros.Columns["TIPO"].Visible = false;
            DgvCobros.Columns["NO_CUOTA"].Visible = false;
            DgvCobros.Columns["MONTO_CUOTA"].Visible = false;
            DgvCobros.Columns["MONTO_CALCULADO"].Visible = false;
           

        }

        private void DgvCobros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

               ListDetalle.Items.Clear();
            
                ListDetalle.Items.Add("         INVERSIONES SANTANA         ");
                //ListDetalle.Items.Add("***********************************");
                ListDetalle.Items.Add("");
                ListDetalle.Items.Add("PAGO " + DgvCobros.CurrentRow.Cells["TIPO"].Value.ToString() + " RD$: " + DgvCobros.CurrentRow.Cells["MONTO_CUOTA"].Value.ToString());
                ListDetalle.Items.Add("CANTIDAD DE CUOTAS " + DgvCobros.CurrentRow.Cells["NO_CUOTA"].Value.ToString());
                ListDetalle.Items.Add("TOTAL A PAGAR RD$: " + DgvCobros.CurrentRow.Cells["MONTO_CALCULADO"].Value.ToString());

           
            foreach(var campos in pagos)
            {
                if(Convert.ToInt16(DgvCobros.CurrentRow.Cells["ID_PRESTAMO"].Value) == Convert.ToInt16(campos.ID_PRESTAMO))
                {
                    Tcuota += Convert.ToInt16(campos.NO_CUOTA);
                    Tmonto += float.Parse(campos.MONTO_CUOTA.ToString());
                }
                 


            }

            TxtPendiente.Text = Convert.ToString((float.Parse(DgvCobros.CurrentRow.Cells["NO_CUOTA"].Value.ToString()) - Tcuota));
            TxtHechos.Text = Tcuota.ToString();
            TxtTotal.Text = Convert.ToString((float.Parse(DgvCobros.CurrentRow.Cells["MONTO_CALCULADO"].Value.ToString()) - Tmonto));
            TxtFechaPago.Text = DateTime.Now.ToString("dd-MM-yyyy");

        }




        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pagos pago = new Pagos {

                ID_CLIENTE = Convert.ToInt16(TxtCodigo.Text),
                ID_PRESTAMO = Convert.ToInt16(DgvCobros.CurrentRow.Cells["ID_PRESTAMO"].Value),
                NO_CUOTA = Convert.ToInt16(TxtNoCuota.Text),
                MONTO_CUOTA = Convert.ToInt16(TxtCuota.Text),
                FECHA_PAGO = TxtFechaPago.Text



        };


            mantenimiento.InsertPagos(pago);
            Join_prestamo = mantenimiento.SelectJoinPrestamo();
            pagos = mantenimiento.SelectPagos();
            controls.Limpiar(groupBox1, groupBox2);


        }
    }
}
