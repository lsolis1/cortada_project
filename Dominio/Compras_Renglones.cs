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
    
    public partial class Compras_Renglones
    {
        public int id_comprasRenglones { get; set; }
        public int id_compra { get; set; }
        public int Cod_Producto { get; set; }
        public short Nro_Linea_Producto { get; set; }
        public short Cantidad { get; set; }
        public Nullable<short> Porcentaje_Desc { get; set; }
        public Nullable<int> Importe_Desc { get; set; }
        public short Porcentaje_IVA { get; set; }
        public int Importe_Total { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
