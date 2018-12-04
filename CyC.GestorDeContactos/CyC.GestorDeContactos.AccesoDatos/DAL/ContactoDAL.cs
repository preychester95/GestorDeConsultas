using Cyc.GestorDeContactos.Comunes;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    //Llamada directa contra BBDD
                    //result = db.Contacto.ToList(); 

                    //Llamada a procedimientos almacenados
                    result = db.Database.SqlQuery<Contacto>("exec GetAllContactos").ToList<Contacto>();
                    foreach (Contacto contacto in result)
                    {
                        contacto.Direccion = DireccionDAL.getDireccionByGuid((Guid)contacto.UIDDireccion);
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


        public static void createContacto(Contacto contacto)
        {
            try
            {
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    //Llamada directa contra BBDD
                    //db.Contacto.Add(contacto);
                    //db.SaveChanges();

                    //Llamada a procedimientos almacenados
                    var contactoGuidParameter = new SqlParameter("@UIDContacto", contacto.UIDContacto);
                    var contactoDireccionGuidParameter = new SqlParameter("@UIDDireccion", contacto.UIDDireccion);
                    var contactoNombreParameter = new SqlParameter("@Nombre", contacto.Nombre);
                    var contactoEmailParameter = new SqlParameter("@Email", contacto.Email);
                    var contactoTelefono = new SqlParameter("@Telefono", contacto.Telefono);
                    var contactoMovil = new SqlParameter("@Movil", contacto.Movil);
                    db.Database.ExecuteSqlCommand("exec CreateContacto @UIDContacto,@UIDDireccion,@Nombre,@Email,@Telefono,@Movil",
                                                                        contactoGuidParameter,
                                                                        contactoDireccionGuidParameter,
                                                                        contactoNombreParameter,
                                                                        contactoEmailParameter,
                                                                        contactoTelefono,
                                                                        contactoMovil);
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
                    //Llamada directa contra BBDD
                    //db.Entry(contacto).State = EntityState.Modified;
                    //db.SaveChanges();

                    //Llamada a procedimientos almacenados
                    var contactoGuidParameter = new SqlParameter("@UIDContacto", contacto.UIDContacto);
                    var contactoDireccionGuidParameter = new SqlParameter("@UIDDireccion", contacto.UIDDireccion);
                    var contactoNombreParameter = new SqlParameter("@Nombre", contacto.Nombre);
                    var contactoEmailParameter = new SqlParameter("@Email", contacto.Email);
                    var contactoTelefono = new SqlParameter("@Telefono", contacto.Telefono);
                    var contactoMovil = new SqlParameter("@Movil", contacto.Movil);
                    db.Database.ExecuteSqlCommand("exec UpdateContactoById @UIDContacto,@UIDDireccion,@Nombre,@Email,@Telefono,@Movil",
                                                                        contactoGuidParameter,
                                                                        contactoDireccionGuidParameter,
                                                                        contactoNombreParameter,
                                                                        contactoEmailParameter,
                                                                        contactoTelefono,
                                                                        contactoMovil);
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
                    //Llamada directa contra BBDD
                    //result = db.Contacto.Find(contactoGuid);
                    //result.Direccion = db.Direccion.Find((Guid)result.UIDDireccion);
                    //result.Direccion.Pais = db.Pais.Find((Guid)result.Direccion.UIDPais);
                    //result.Direccion.Provincia = db.Provincia.Find((Guid)result.Direccion.UIDProvincia);

                    //Llamada a procedimientos almacenados
                    var contactoGuidParameter = new SqlParameter("@UIDContacto", contactoGuid); //Tiene que haber una manera mejor de hacerlo...
                    result = db.Database.SqlQuery<Contacto>("exec GetContactoById @UIDContacto ", contactoGuidParameter).ToList<Contacto>().FirstOrDefault();
                    result.Direccion = DireccionDAL.getDireccionByGuid((Guid)result.UIDDireccion);

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
                    //Llamada directa contra BBDD
                    //db.Contacto.Attach(contacto);
                    //db.Contacto.Remove(contacto);
                    //db.SaveChanges();

                    //Llamada a procedimientos almacenados
                    var contactoGuidParameter = new SqlParameter("@UIDContacto", contacto.UIDContacto); //Tiene que haber una manera mejor de hacerlo...
                    db.Database.ExecuteSqlCommand("exec DeleteContactoById @UIDContacto ", contactoGuidParameter);
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
                    //Llamada directa contra BBDD
                    //if (filtro != null)
                    //{
                    //    var query = db.Contacto.AsQueryable();
                    //    if (!String.IsNullOrEmpty(filtro.nombre))
                    //        query = query.Where(x => x.Nombre == filtro.nombre);
                    //    if (!String.IsNullOrEmpty(filtro.email))
                    //        query = query.Where(x => x.Email == filtro.email);
                    //    if (filtro.telefono != 0)
                    //        query = query.Where(x => x.Telefono == filtro.telefono);
                    //    if (filtro.movil != 0)
                    //        query = query.Where(x => x.Movil == filtro.movil);
                    //    result = query.ToList();
                    //    if (!String.IsNullOrEmpty(filtro.direccion))
                    //    {
                    //        result = getResultByDireccion(filtro.direccion, result);
                    //    }
                    //}

                    //Llamada a procedimientos almacenados
                    result = getAllContactos();
                    if (filtro != null)
                    {
                        if (!String.IsNullOrEmpty(filtro.nombre))
                            result = result.Where(x => x.Nombre == filtro.nombre).ToList();
                        if (!String.IsNullOrEmpty(filtro.email))
                            result = result.Where(x => x.Email == filtro.email).ToList();
                        if (filtro.telefono != 0)
                            result = result.Where(x => x.Telefono == filtro.telefono).ToList();
                        if (filtro.movil != 0)
                            result = result.Where(x => x.Movil == filtro.movil).ToList();
                        if (!String.IsNullOrEmpty(filtro.direccion))
                            result = result.Where(x => x.Direccion.FullName.Contains(filtro.direccion)).ToList();
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
