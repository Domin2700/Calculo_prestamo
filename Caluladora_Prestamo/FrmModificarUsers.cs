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
        int id;

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
            control.Limpiar(groupBox1);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


           if(TxtDireccion.Text.Length == 0)
            {
                EpError.SetError(TxtDireccion, "Introdusca la direccion");
                TxtDireccion.Focus();


            }
            else
            {
                EpError.Clear();
            }

           if(TxtApellidos.Text.Length == 0)
            {

                EpError.SetError(TxtApellidos, "Introdusca los apellidos");
                TxtApellidos.Focus();                

            }
            else
            {
                EpError.Clear();
            }

           if(TxtNombres.Text.Length == 0 || TxtApellidos.Text.Length ==0)
            {

                EpError.SetError(TxtNombres,"Introdusca los nombres");

            }

            else
            {

                EpError.Clear();

              Cliente campos = new Cliente
                {
                    ID_CLIENTE = id,
                    NOMBRES = TxtNombres.Text,
                    APELLIDOS = TxtApellidos.Text,
                    CEDULA = TxtCedula.Text,
                    CELULAR = TxtCelular.Text,
                    DIRECCION = TxtDireccion.Text



                };

                mantenimiento.UpdateCliente(campos);
                control.Limpiar(this);
                DgvUsuarios.DataSource = mantenimiento.SelectClietes();
                ModificarColumnas();


            }





        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(DgvUsuarios.CurrentRow.Cells["ID_CLIENTE"].Value);

            if (e.ColumnIndex == 0)
            {

                TxtNombres.Text = DgvUsuarios.CurrentRow.Cells["NOMBRES"].Value.ToString();
                TxtApellidos.Text = DgvUsuarios.CurrentRow.Cells["APELLIDOS"].Value.ToString();
                TxtCedula.Text = DgvUsuarios.CurrentRow.Cells["CEDULA"].Value.ToString();
                TxtCelular.Text = DgvUsuarios.CurrentRow.Cells["CELULAR"].Value.ToString();
                TxtDireccion.Text = DgvUsuarios.CurrentRow.Cells["DIRECCION"].Value.ToString();



            }
            else if (e.ColumnIndex == 1)
            {
                Pregunta = MessageBox.Show(" Esta seguro?", "Borrando registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Pregunta == DialogResult.Yes)
                {

                    mantenimiento.DeleteCliente(id);
                    
                    DgvUsuarios.DataSource = mantenimiento.SelectClietes();
                    ModificarColumnas();
                }

            }
        }

        private void FrmModificarUsers_Load(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = mantenimiento.SelectClietes();
            ModificarColumnas();
        }


        private void ModificarColumnas()
        {
            DgvUsuarios.Columns["ID_CLIENTE"].DisplayIndex = 0;
            DgvUsuarios.Columns["NOMBRES"].DisplayIndex = 1;
            DgvUsuarios.Columns["APELLIDOS"].DisplayIndex = 2;
            DgvUsuarios.Columns["CEDULA"].DisplayIndex = 3;
            DgvUsuarios.Columns["CELULAR"].DisplayIndex = 4;
            DgvUsuarios.Columns["DIRECCION"].DisplayIndex = 5;
            DgvUsuarios.Columns["Editar"].DisplayIndex = 6;
            DgvUsuarios.Columns["Borrar"].DisplayIndex = 7;
           
            DgvUsuarios.Columns["ID_CLIENTE"].Visible = false;
            DgvUsuarios.Columns["CELULAR"].Visible = false;
            DgvUsuarios.Columns["DIRECCION"].Visible = false;
            DgvUsuarios.Columns["NOMBRES"].Width = 120;
            DgvUsuarios.Columns["APELLIDOS"].Width = 120;
            DgvUsuarios.Columns["CEDULA"].Width = 100;

           



        }

        private void TxtNombres_MouseClick(object sender, MouseEventArgs e)
        {
            EpError.Clear();
        }

        private void TxtApellidos_MouseClick(object sender, MouseEventArgs e)
        {
            EpError.Clear();
        }

        private void TxtCedula_MouseClick(object sender, MouseEventArgs e)
        {
            EpError.Clear();
        }

        private void TxtCelular_MouseClick(object sender, MouseEventArgs e)
        {
            EpError.Clear();
        }

        private void txtAutoexplicativo1_TextChanged(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = mantenimiento.SelectClietes(txtAutoexplicativo1.Text);
        }
    }
}
