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


    public partial class FrmModificarUsers : Form

    {
        Controles control = new Controles();
        DialogResult Pregunta;
        Mantenimiento mantenimiento = new Mantenimiento();

        public FrmModificarUsers()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            control.Limpiar(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {




        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt16(DgvUsuarios.CurrentRow.Cells[1].Value);

            if (e.ColumnIndex == 0)
            {



            }
            else if (e.ColumnIndex == 1)
            {
                Pregunta = MessageBox.Show(" Esta seguro?", "Borrando registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pregunta == DialogResult.Yes)
                {
                    MessageBox.Show("Esto Funciona");

                }

            }
        }

        private void FrmModificarUsers_Load(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = mantenimiento.SelectClietes();
        }

    }
}
