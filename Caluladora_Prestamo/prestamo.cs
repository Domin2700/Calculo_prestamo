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
    
    public partial class prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prestamo()
        {
            this.pagos = new HashSet<pagos>();
        }
    
        public int ID_PRESTAMO { get; set; }
        public int ID_CLIENTE { get; set; }
        public string TIPO { get; set; }
        public double MONTO_CALCULADO { get; set; }
        public double MONTO { get; set; }
        public double MONTO_CUOTA { get; set; }
        public int NO_CUOTA { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagos> pagos { get; set; }
    }
}
