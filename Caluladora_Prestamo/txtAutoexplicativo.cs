using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBoxAutoexplicativo
{
    public class txtAutoexplicativo:TextBox //Heredo de la clase TextBox
    {
        private string textoVacio;
        [Category("Texto Vacio")] //Le agrego una Categoria

        //Nuevas Propiedades
        public string TextoVacio
        {
            get { return textoVacio; }
            set { textoVacio = value; }
        }

        private Color colorTextoVacio;
        public Color ColorTextoVacio
        {
            get { return colorTextoVacio; }
            set { colorTextoVacio = value; }
        }

        //Variables Privadas
        bool bndTextoVacio = false; //Bandera que indica si esta activo el Texto Vacio
        //Constructor
        public txtAutoexplicativo()
        {//Inicio los valores por defecto
            colorTextoVacio = Color.Gray;
            textoVacio = "<Descripcion>";
        }
        //Creo un metodo que me ayudara a verificar si se inserta el texto vacio o no
        private void VerificaTextoVacio()
        {
            if (this.Text.Length > 0)
            {
                bndTextoVacio = false; //como el TextBox tiene contenido desactivo el textoVacio
            }
            else
            {
                bndTextoVacio = true; //en caso contrario activo la bandera
            }
            this.SetStyle(ControlStyles.UserPaint, bndTextoVacio); //Para poder acceder al evento Paint del TextBox segun la bandera
            this.Refresh(); //Refresco el TextBox
        }

        //Sobreescribo los metodos del TextBox
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            VerificaTextoVacio(); //Verifico si debe activarse el TextBox
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            VerificaTextoVacio(); //Cada vez que cambie el contenido del TextBox se verifica si debe activarse el TextoVacio
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Aqui muestro el contenido del TextBox o el contenido de TextoVacio segun sea el caso
            if (bndTextoVacio) //si está activo el TextBox
            {
                e.Graphics.DrawString(textoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colorTextoVacio), new Point(0, 0));
            }
            else
            {
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            }
            base.OnPaint(e);
        }
    }
}
