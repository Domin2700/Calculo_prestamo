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
    public partial class FrmClientes : Form
    {
        Controles controls = new Controles();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            controls.Limpiar(this);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*if (new Controles().Validar(this))
            {

                

            }*/


            Cliente campos = new Cliente
            {
                NOMBRES = TxtNombres.Text,
                APELLIDOS = TxtApellidos.Text,
                CEDULA = TxtCedula.Text,
                CELULAR = TxtCelular.Text,
                DIRECION = TxtDireccion.Text
                

            };
        
            new Mantenimiento().InsertClientes(campos);
            controls.Limpiar(this);

        }
    }
}
