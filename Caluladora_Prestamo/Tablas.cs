using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluladora_Prestamo
{
    public class Cliente
    {
        public int ID_CLIENTE { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CEDULA { get; set; }
        public string CELULAR { get; set; }
        public string DIRECION { get; set; }


    }

    public class Tarifa
    {
        public int ID_TARIFA { get; set; }
        public float MONTO { get; set; }
        public float MONTO_CUOTA { get; set; }
        public int NO_CUOTA { get; set; }
        public int TIPO { get; set;}

    }



}
