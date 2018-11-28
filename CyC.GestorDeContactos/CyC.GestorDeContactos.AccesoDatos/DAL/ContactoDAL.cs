using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Data.Entity;

namespace CyC.GestorDeContactos.AccesoDatos.DAL
{
    public static class ContactoDAL
    {
        public static void createContacto(Contacto contacto)
        {
            try
            {
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    db.Contacto.Add(contacto);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public static void updateContacto(Contacto contacto)
        {
            try
            {
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    db.Entry(contacto).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        //TODO: ver como cargar los objetos lazy

        public static Contacto getContactoByGuid(Guid contactoGuid)
        {
            try
            {
                Contacto result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    result = db.Contacto.Find(contactoGuid);
                    result.Direccion = db.Direccion.Find((Guid)result.UIDDireccion);
                    result.Direccion.Pais = db.Pais.Find((Guid)result.Direccion.UIDPais);
                    result.Direccion.Provincia = db.Provincia.Find((Guid)result.Direccion.UIDProvincia);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return null;
            }
        }

        public static void deleteContacto(Contacto contacto)
        {
            try
            {
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    db.Contacto.Attach(contacto);
                    db.Contacto.Remove(contacto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}
