using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caluladora_Prestamo
{
    class Controles
    {

        public void Limpiar(Control control,GroupBox group)
        {

            foreach( var gb in group.Controls)
            {
                if(gb is TextBox)
                {
                    ((TextBox)gb).Clear();

                }

                

            }

            foreach(var txt in control.Controls)
                {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();

                }
                        


                }




        }


    }
}
