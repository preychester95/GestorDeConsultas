//------------------------------------------------------------------------------
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
    using System.Collections.Generic;

    public partial class Direccion
    {
        public Direccion()
        {
            this.Contacto = new HashSet<Contacto>();
        }

        public System.Guid UIDDireccion { get; set; }
        public string CP { get; set; }
        public string Localidad { get; set; }
        public Nullable<System.Guid> UIDProvincia { get; set; }
        public Nullable<System.Guid> UIDPais { get; set; }
        public Nullable<decimal> Telefono { get; set; }

        public virtual ICollection<Contacto> Contacto { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }


        public string FullName
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            try
            {
                return Localidad + ", " + CP + ", " + Provincia.Provincia1 + ", " + Pais.Pais1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return "";
            }

        }

    }
}