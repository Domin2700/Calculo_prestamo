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
        public string DIRECCION { get; set; }


    }

    public class Tarifa
    {
        public int ID_TARIFA { get; set; }
        public float MONTO { get; set; }
        public float MONTO_CUOTA { get; set; }
        public int NO_CUOTA { get; set; }
        public int TIPO { get; set;}

    }

    public class Prestamo
    {

        public int ID_PRESTAMO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_TARIFA { get; set; }
        public string TIPO { get; set; }
        public float MONTO { get; set; }
        public float MONTO_CUOTA { get; set; }
        public int NO_CUOTA { get; set; }
        public float MONTO_CALCULADO { get; set;}
        public string FECHA_PRESTAMO { get; set; }

    }

    public class Pagos
    {
        public int ID_PAGO { get; set; }
        public int ID_PRESTAMO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int NO_CUOTA { get; set; }
        public float MONTO_CUOTA { get; set; }
        public string FECHA_PAGO { get; set; }



    }

    public class join_prestamo
    {
        public int ID_CLIENTE { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string CEDULA { get; set; }
        public string CELULAR { get; set; }
        public int ID_PRESTAMO { get; set; }
        public string TIPO { get; set; }
        public float MONTO { get; set; }
        public float MONTO_CUOTA { get; set; }
        public int NO_CUOTA { get; set; }
        public float MONTO_CALCULADO { get; set; }
        public string FECHA_PRESTAMO { get; set; }
      

    }

    

}
