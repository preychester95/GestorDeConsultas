using Cyc.GestorDeContactos.Comunes;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CyC.GestorDeContactos.AccesoDatos.DAL
{
    public static class ContactoDAL
    {

        public static List<Contacto> getAllContactos()
        {
            try
            {
                List<Contacto> result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    result = db.Contacto.ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Contacto>();
            }
        }


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

        public static List<Contacto> applyFilter(Filter filtro)
        {
            try
            {
                List<Contacto> result = new List<Contacto>();
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    if (filtro != null)
                    {
                        var query = db.Contacto.AsQueryable();
                        if (!String.IsNullOrEmpty(filtro.nombre))
                            query = query.Where(x => x.Nombre == filtro.nombre);
                        if (!String.IsNullOrEmpty(filtro.email))
                            query = query.Where(x => x.Email == filtro.email);
                        if (filtro.telefono != 0)
                            query = query.Where(x => x.Telefono == filtro.telefono);
                        if (filtro.movil != 0)
                            query = query.Where(x => x.Movil == filtro.movil);
                        result = query.ToList();
                        if (!String.IsNullOrEmpty(filtro.direccion))
                        {
                            result = getResultByDireccion(filtro.direccion, result);
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Contacto>();
            }
        }

        private static List<Contacto> getResultByDireccion(string direccionFullName, List<Contacto> result)
        {
            try
            {
                List<Contacto> finalResult = new List<Contacto>();
                foreach (Contacto contacto in result)
                {
                    if (contacto.Direccion.FullName.Contains(direccionFullName))
                    {
                        finalResult.Add(contacto);
                    }
                }
                return finalResult;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return result;
            }
        }
    }
}
