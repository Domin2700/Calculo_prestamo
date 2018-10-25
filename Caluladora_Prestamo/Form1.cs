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
    public partial class FmrPrincipal : Form
    {
        public FmrPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo prestamo = new FrmPrestamo();
            prestamo.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.ShowDialog();
        }

        private void FmrPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobros Cobros = new FrmCobros();
            Cobros.Show();
        }
    }
}
