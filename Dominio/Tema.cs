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
    
    public partial class Tema
    {
        public System.DateTime Fecha { get; set; }
        public byte Nro_Empleado { get; set; }
        public byte id_tema { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
