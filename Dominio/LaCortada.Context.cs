﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_LaCortadaEntities : DbContext
    {
        public DB_LaCortadaEntities()
            : base("name=DB_LaCortadaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<Cancha> Canchas { get; set; }
        public virtual DbSet<Ciudade> Ciudades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<Compras_Renglones> Compras_Renglones { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Estado_Turno> Estado_Turno { get; set; }
        public virtual DbSet<Lista_Espera> Lista_Espera { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tipo_Comprobante> Tipo_Comprobante { get; set; }
        public virtual DbSet<Tipos_Documento> Tipos_Documento { get; set; }
        public virtual DbSet<Tipos_Turno> Tipos_Turno { get; set; }
        public virtual DbSet<Turno> Turnos { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Ventas_Lineas> Ventas_Lineas { get; set; }
    }
}
