//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Ventas_Lineas = new HashSet<Ventas_Lineas>();
        }
    
        public int id_venta { get; set; }
        public int id_cliente { get; set; }
        public short Tipo_Comprobante { get; set; }
        public int Nro_Comprobante { get; set; }
        public int Nro_Movimiento { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<short> Porcentaje_Descuento { get; set; }
        public Nullable<int> Total_Descuento { get; set; }
        public int Total_General { get; set; }
    
        public virtual Caja Caja { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Tipo_Comprobante Tipo_Comprobante1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas_Lineas> Ventas_Lineas { get; set; }
    }
}
