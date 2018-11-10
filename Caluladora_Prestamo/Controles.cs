﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caluladora_Prestamo
{
    class Controles
    {
        //private bool vacio = false;
        //private DialogResult mensaje;

        public void Limpiar(GroupBox group1, GroupBox group2)
        {

            foreach (var txt in group1.Controls)
            {

                if (txt is TextBox)

                {
                    ((TextBox)txt).Clear();

                }


            }

            foreach (var txt in group2.Controls)
            {

                if (txt is TextBox)

                {
                    ((TextBox)txt).Clear();


                }

                else if (txt is ListView)
                {

                    ((ListView)txt).Clear();

                }

                else if (txt is ComboBox)

                {

                   ((ComboBox)txt).SelectedIndex = 0;

                }


            }






        }

        public void Limpiar(GroupBox group1)
        {

            foreach (var txt in group1.Controls)
            {

                if (txt is TextBox)
                {

                    ((TextBox)txt).Clear();


                }

                else if (txt is ComboBox)
                {
                    //((ComboBox)txt).SelectedIndex = 0;

                }

                else if (txt is DataGridView)
                {

                    ((DataGridView)txt).Rows.Clear();

                }
                else if(txt is MaskedTextBox)
                {

                    ((MaskedTextBox)txt).Clear();
                }

            }



        }

        public void Limpiar(Control form)
        {

            foreach (var txt in form.Controls)
            {

                if (txt is TextBox)
                {

                    ((TextBox)txt).Clear();

                }

                else if(txt is MaskedTextBox)
                    {

                    ((MaskedTextBox)txt).Clear();
                    }


            }

        }


        public bool Validar(Control group1/*, GroupBox group2*/ )
        {
            bool b = false;

            foreach (var txt in group1.Controls)
            {

                if (txt is TextBox && ((TextBox)txt).Text == String.Empty)
                {

                    MessageBox.Show("Campo vacio!", "No deje campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }

                else { b = true; }

                break;
            }

           
            return b;

            /* foreach(var txt in group2.Controls)
             {

                 if(txt is TextBox && ((TextBox)txt).Text == String.Empty)
                 {

                     MessageBox.Show("Campo vacio!", "No deje campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 }*/


        } 



        }


    }

