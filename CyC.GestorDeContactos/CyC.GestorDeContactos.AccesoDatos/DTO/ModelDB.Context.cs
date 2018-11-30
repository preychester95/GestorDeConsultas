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
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual int CrearContacto(Nullable<System.Guid> uIDContacto, Nullable<System.Guid> uIDDireccion, string nombre, string email, Nullable<decimal> telefono, Nullable<decimal> movil)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(decimal));
    
            var movilParameter = movil.HasValue ?
                new ObjectParameter("Movil", movil) :
                new ObjectParameter("Movil", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearContacto", uIDContactoParameter, uIDDireccionParameter, nombreParameter, emailParameter, telefonoParameter, movilParameter);
        }
    
        public virtual int CrearDireccion(Nullable<System.Guid> uIDDireccion, string cP, string localidad, Nullable<System.Guid> uIDProvincia, Nullable<System.Guid> uIDPais, Nullable<decimal> telefono)
        {
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            var cPParameter = cP != null ?
                new ObjectParameter("CP", cP) :
                new ObjectParameter("CP", typeof(string));
    
            var localidadParameter = localidad != null ?
                new ObjectParameter("Localidad", localidad) :
                new ObjectParameter("Localidad", typeof(string));
    
            var uIDProvinciaParameter = uIDProvincia.HasValue ?
                new ObjectParameter("UIDProvincia", uIDProvincia) :
                new ObjectParameter("UIDProvincia", typeof(System.Guid));
    
            var uIDPaisParameter = uIDPais.HasValue ?
                new ObjectParameter("UIDPais", uIDPais) :
                new ObjectParameter("UIDPais", typeof(System.Guid));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearDireccion", uIDDireccionParameter, cPParameter, localidadParameter, uIDProvinciaParameter, uIDPaisParameter, telefonoParameter);
        }
    
        public virtual int DeleteContactoById(Nullable<System.Guid> uIDContacto)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteContactoById", uIDContactoParameter);
        }
    
        public virtual ObjectResult<GetAllContactos_Result> GetAllContactos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllContactos_Result>("GetAllContactos");
        }
    
        public virtual ObjectResult<GetContactoById_Result> GetContactoById(Nullable<System.Guid> uIDContacto)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetContactoById_Result>("GetContactoById", uIDContactoParameter);
        }
    
        public virtual int CreateContacto(Nullable<System.Guid> uIDContacto, Nullable<System.Guid> uIDDireccion, string nombre, string email, Nullable<decimal> telefono, Nullable<decimal> movil)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(decimal));
    
            var movilParameter = movil.HasValue ?
                new ObjectParameter("Movil", movil) :
                new ObjectParameter("Movil", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateContacto", uIDContactoParameter, uIDDireccionParameter, nombreParameter, emailParameter, telefonoParameter, movilParameter);
        }
    
        public virtual int CreateDireccion(Nullable<System.Guid> uIDDireccion, string cP, string localidad, Nullable<System.Guid> uIDProvincia, Nullable<System.Guid> uIDPais, Nullable<decimal> telefono)
        {
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            var cPParameter = cP != null ?
                new ObjectParameter("CP", cP) :
                new ObjectParameter("CP", typeof(string));
    
            var localidadParameter = localidad != null ?
                new ObjectParameter("Localidad", localidad) :
                new ObjectParameter("Localidad", typeof(string));
    
            var uIDProvinciaParameter = uIDProvincia.HasValue ?
                new ObjectParameter("UIDProvincia", uIDProvincia) :
                new ObjectParameter("UIDProvincia", typeof(System.Guid));
    
            var uIDPaisParameter = uIDPais.HasValue ?
                new ObjectParameter("UIDPais", uIDPais) :
                new ObjectParameter("UIDPais", typeof(System.Guid));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateDireccion", uIDDireccionParameter, cPParameter, localidadParameter, uIDProvinciaParameter, uIDPaisParameter, telefonoParameter);
        }
    
        public virtual int DeleteContactoById1(Nullable<System.Guid> uIDContacto)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteContactoById1", uIDContactoParameter);
        }
    
        public virtual ObjectResult<GetAllContactos1_Result> GetAllContactos1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllContactos1_Result>("GetAllContactos1");
        }
    
        public virtual ObjectResult<GetAllDirecciones_Result> GetAllDirecciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDirecciones_Result>("GetAllDirecciones");
        }
    
        public virtual ObjectResult<GetAllPaises_Result> GetAllPaises()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPaises_Result>("GetAllPaises");
        }
    
        public virtual ObjectResult<GetAllProvincias_Result> GetAllProvincias()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllProvincias_Result>("GetAllProvincias");
        }
    
        public virtual ObjectResult<GetContactoById1_Result> GetContactoById1(Nullable<System.Guid> uIDContacto)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetContactoById1_Result>("GetContactoById1", uIDContactoParameter);
        }
    
        public virtual ObjectResult<GetDireccionById_Result> GetDireccionById(Nullable<System.Guid> uIDDireccion)
        {
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDireccionById_Result>("GetDireccionById", uIDDireccionParameter);
        }
    
        public virtual ObjectResult<GetPaisById_Result> GetPaisById(Nullable<System.Guid> uIDPais)
        {
            var uIDPaisParameter = uIDPais.HasValue ?
                new ObjectParameter("UIDPais", uIDPais) :
                new ObjectParameter("UIDPais", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPaisById_Result>("GetPaisById", uIDPaisParameter);
        }
    
        public virtual ObjectResult<GetProvinciaById_Result> GetProvinciaById(Nullable<System.Guid> uIDProvincia)
        {
            var uIDProvinciaParameter = uIDProvincia.HasValue ?
                new ObjectParameter("UIDProvincia", uIDProvincia) :
                new ObjectParameter("UIDProvincia", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProvinciaById_Result>("GetProvinciaById", uIDProvinciaParameter);
        }
    
        public virtual int UpdateContactoById(Nullable<System.Guid> uIDContacto, Nullable<System.Guid> uIDDireccion, string nombre, string email, Nullable<decimal> telefono, Nullable<decimal> movil)
        {
            var uIDContactoParameter = uIDContacto.HasValue ?
                new ObjectParameter("UIDContacto", uIDContacto) :
                new ObjectParameter("UIDContacto", typeof(System.Guid));
    
            var uIDDireccionParameter = uIDDireccion.HasValue ?
                new ObjectParameter("UIDDireccion", uIDDireccion) :
                new ObjectParameter("UIDDireccion", typeof(System.Guid));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(decimal));
    
            var movilParameter = movil.HasValue ?
                new ObjectParameter("Movil", movil) :
                new ObjectParameter("Movil", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateContactoById", uIDContactoParameter, uIDDireccionParameter, nombreParameter, emailParameter, telefonoParameter, movilParameter);
        }
    }
}
