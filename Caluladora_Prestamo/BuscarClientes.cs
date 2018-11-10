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
    public partial class BuscarClientes : Form
    {
        public static int idCliente;
        Mantenimiento mantenimiento = new Mantenimiento();
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = mantenimiento.SelectClietes();
            ModificarColumnas();
        }


        private void ModificarColumnas()
        {
           /* DgvUsuarios.Columns["ID_CLIENTE"].DisplayIndex = 0;
            DgvUsuarios.Columns["NOMBRES"].DisplayIndex = 1;
            DgvUsuarios.Columns["APELLIDOS"].DisplayIndex = 2;
            DgvUsuarios.Columns["CEDULA"].DisplayIndex = 3;
            DgvUsuarios.Columns["CELULAR"].DisplayIndex = 4;
            DgvUsuarios.Columns["DIRECCION"].DisplayIndex = 5;*/
           

            DgvUsuarios.Columns["ID_CLIENTE"].Visible = false;
            DgvUsuarios.Columns["CELULAR"].Visible = false;
            DgvUsuarios.Columns["DIRECCION"].Visible = false;
            DgvUsuarios.Columns["NOMBRES"].Width = 120;
            DgvUsuarios.Columns["APELLIDOS"].Width = 120;
            DgvUsuarios.Columns["CEDULA"].Width = 100;





        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = mantenimiento.SelectClietes(TxtBuscar.Text);
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt16(DgvUsuarios.CurrentRow.Cells["ID_CLIENTE"].Value);
 
            this.Close();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
