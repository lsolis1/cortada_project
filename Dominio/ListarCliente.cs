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
    
    public partial class ListarCliente
    {
        public int id_cliente { get; set; }
        public byte Tipo_Doc { get; set; }
        public long Nro_Doc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }
        public string Domicilio { get; set; }
        public short Cod_Postal { get; set; }
        public Nullable<System.DateTime> Fecha_Baja { get; set; }
        public string NombreCiudad { get; set; }
    }
}
