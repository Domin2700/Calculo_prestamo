//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caluladora_Prestamo
{
    using System;
    using System.Collections.Generic;
    
    public partial class pagos
    {
        public int ID_PAGO { get; set; }
        public int ID_PRESTAMO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int NO_CUOTA { get; set; }
        public double MONTO_CUOTA { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual prestamo prestamo { get; set; }
    }
}
