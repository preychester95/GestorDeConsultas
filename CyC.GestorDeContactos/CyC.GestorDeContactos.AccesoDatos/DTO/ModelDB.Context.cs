﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyC.GestorDeContactos.AccesoDatos.DTO
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class CYC_PracticasEntities : DbContext
    {
        public CYC_PracticasEntities()
            : base("name=CYC_PracticasEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}