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
    
    public partial class Ventas_Lineas
    {
        public int Nro_Comprobante { get; set; }
        public short Tipo_Comprobante { get; set; }
        public int Nro_Linea { get; set; }
        public int Cod_Producto { get; set; }
        public short Cantidad { get; set; }
        public Nullable<short> Porcentaje_Descuento { get; set; }
        public Nullable<int> Importe_Descuento { get; set; }
        public int Importe_Total { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}