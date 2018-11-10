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
    public partial class FomMantenimientos : Form
    {
        public FomMantenimientos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmModificarClientes users = new FrmModificarClientes();
            users.ShowDialog();
        }

        private void BtnTarfa_Click(object sender, EventArgs e)
        {
            FrmTarifas tarifa = new FrmTarifas();
            tarifa.ShowDialog();
        }
    }
}
