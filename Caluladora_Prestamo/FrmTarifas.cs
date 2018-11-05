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
    public partial class FrmTarifas : Form
    {
        
        int tipo;// Esta variable entera la uso para guardar el tipo que puede ser 1 o 0
        int id;// Esta variable la uso para guardar el id del registro o tarifa que quiero Borrar o modificar
        Controles controls = new Controles();// Aqui creo un objeto de la clase Controles en la cual tengo los metodos limpiar y Validar
        Mantenimiento mantenimiento = new Mantenimiento();// Aqui creamos un objeto de la clase Mantenimiento la cual contiene todos los metodos para manejar la base de datos
        DialogResult pregunta;
        bool validar = false;
        public FrmTarifas()
        {
            InitializeComponent();
            
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//Aqui invoco al metodo Close(); de mi formulario
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            controls.Limpiar(this);// Aqui llamo mi metodo Limpiar de la clase Controles y le paso este formula para que me limpie los TextBox
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            

            if(RdbSemanal.Checked )// Si mi RadioButton Semanal esta Chekado entonces mi variable Tipo vale 1
            {
                tipo = 1;

            }

            if(RdbMensual.Checked)// Si mi RadioButton Mensual esta Chekado entonces mi variable Tipo vale 0
            {

                tipo = 0;
            }


            if (validar)
            {
                Tarifa campos = new Tarifa
                { // Aqui creo un objeto de la clase Tarifa. Esta clase tiene la misma extructura
                    MONTO = float.Parse(TxtMonto.Text),// que mi tabla tarifas. Lo que hago aqui es llenar las propiedades 
                    MONTO_CUOTA = float.Parse(TxtCuota.Text),// de mi clase con los valores de los TextBox Y despues los envio a la 
                    NO_CUOTA = int.Parse(TxtNoCuota.Text),// Clase Mantenimiento para insertalos a la base de datos
                    TIPO = tipo

                };

                mantenimiento.InsertTarifa(campos);// Aqui Llamo mi metodo InsertTarifa de la clase Mantenimiento Y le paso el objeto de la clase Tarifa estando este lleno.
                controls.Limpiar(this);//Aqui llamo mi metodo limpiar
                DgvTarifas.DataSource = mantenimiento.SelectTarifa();// Aqui Llamo El metodo SelectTarifa y refresco mi DataGribviw
                OrganizarColumns();
                validar = false;
            }



        }

        private void FrmTarifas_Load(object sender, EventArgs e)
        {
           DgvTarifas.DataSource = mantenimiento.SelectTarifa();// Aqui en le evento Load de mi form llamo la metodo SelectTarifa y lleno mi DataGribview
           OrganizarColumns();

        }

        private void DgvTarifas_CellClick(object sender, DataGridViewCellEventArgs e)
        {// Aqui estamo en el evento CellClick de mi DgvTarifa 

            if(e.ColumnIndex == 0)// Aqui pregunto si el indice de la columna es 0 
            {// Aqui abajo lo que hago es llenar los TexBox Con los valores que tenga el registro seleccionado 
                TxtMonto.Text = DgvTarifas.CurrentRow.Cells["MONTO"].Value.ToString();
                TxtCuota.Text = DgvTarifas.CurrentRow.Cells["MONTO_CUOTA"].Value.ToString();
                TxtNoCuota.Text = DgvTarifas.CurrentRow.Cells["NO_CUOTA"].Value.ToString();
                id = Convert.ToInt16(DgvTarifas.CurrentRow.Cells["ID_TARIFA"].Value);
                if(Convert.ToUInt16(DgvTarifas.CurrentRow.Cells["TIPO"].Value) == 1 )
                {
                    RdbSemanal.Select();

                }
                else
                {
                    RdbMensual.Select();

                }

                BtnActualizar.Visible = true;
                
            }

            else if (e.ColumnIndex== 1)
            {
                pregunta = MessageBox.Show("Esta Seguro","Borrando registro....",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (pregunta == DialogResult.Yes)
                {
                    id = Convert.ToInt16(DgvTarifas.CurrentRow.Cells["ID_TARIFA"].Value);
                    mantenimiento.DeleteTarifa(id);
                    DgvTarifas.DataSource = mantenimiento.SelectTarifa();
                    OrganizarColumns();


                }

            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            Tarifa campos = new Tarifa
            {
                ID_TARIFA = id,
                MONTO = float.Parse(TxtMonto.Text),
                MONTO_CUOTA = float.Parse(TxtCuota.Text),
                NO_CUOTA = int.Parse(TxtNoCuota.Text),
                TIPO = tipo

            };

            mantenimiento.UpdateTarifa(campos);
            controls.Limpiar(this);
            BtnActualizar.Visible = false;
            DgvTarifas.DataSource = mantenimiento.SelectTarifa();
            OrganizarColumns();

        }

       private  void OrganizarColumns()
        {
           // DgvTarifas.AutoGenerateColumns = false;
            DgvTarifas.Columns["MONTO"].DisplayIndex = 0;
            DgvTarifas.Columns["MONTO_CUOTA"].DisplayIndex = 1;
            DgvTarifas.Columns["NO_CUOTA"].DisplayIndex = 2;
            DgvTarifas.Columns["TIPO"].DisplayIndex = 3;
            DgvTarifas.Columns["Editar"].DisplayIndex = 4;
           DgvTarifas.Columns["Borrar"].DisplayIndex = 5;
           DgvTarifas.Columns["ID_TARIFA"].DisplayIndex = 6;
            DgvTarifas.Columns["ID_TARIFA"].Visible = false;
            DgvTarifas.Columns["TIPO"].Width = 50;
            DgvTarifas.Columns["Monto"].Width = 60;
            DgvTarifas.Columns["NO_CUOTA"].Width = 70;


        }

        private void TxtMonto_Validated(object sender, EventArgs e)
        {
            if(TxtMonto.Text.Trim() == "")
            {
                EpError.SetError(TxtMonto, "Introdusca el monto..");
                TxtMonto.Focus();
                
            }
            else
            {
                EpError.Clear();
                validar = true;
            }
        }

        private void TxtCuota_Validated(object sender, EventArgs e)
        {
            if(TxtCuota.Text.Trim() == "")
            {
                EpError.SetError(TxtCuota, "Introdusca la cuota");
                TxtCuota.Focus();

            }
            else
            {
                EpError.Clear();
            }
        }

        private void TxtNoCuota_Validated(object sender, EventArgs e)
        {
            if(TxtNoCuota.Text.Trim()=="")
            {
                EpError.SetError(TxtNoCuota, "Introdusca el no. Cuotas");
                TxtNoCuota.Focus();

            }
            else
            {
                EpError.Clear();
            }
        }
    }
}
