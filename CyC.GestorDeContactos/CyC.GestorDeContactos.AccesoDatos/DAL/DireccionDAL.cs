using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CyC.GestorDeContactos.AccesoDatos.DAL
{
    public static class DireccionDAL
    {
        public static void createDireccion(Direccion direccion)
        {
            try
            {
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    //Llamada directa contra BBDD
                    //db.Direccion.Add(direccion);
                    //db.SaveChanges();

                    //Llamada a procedimientos almacenados
                    var direccionGuidParameter = new SqlParameter("@UIDDireccion", direccion.UIDDireccion);
                    var direccionCP = new SqlParameter("@CP", direccion.CP);
                    var direccionLocalidad = new SqlParameter("@Localidad", direccion.Localidad);
                    var direccionGuidProvincia = new SqlParameter("@UIDProvincia", direccion.UIDProvincia);
                    var direccionGuidPais = new SqlParameter("@UIDPais", direccion.UIDPais);
                    var direccionTelefono = new SqlParameter("@Telefono", direccion.Telefono);
                    db.Database.ExecuteSqlCommand("exec CreateDireccion @UIDDireccion,@CP,@Localidad,@UIDProvincia,@UIDPais,@Telefono",
                                                                        direccionGuidParameter,
                                                                        direccionCP,
                                                                        direccionLocalidad,
                                                                        direccionGuidProvincia,
                                                                        direccionGuidPais,
                                                                        direccionTelefono);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public static Direccion getDireccionByGuid(Guid direccionGuid)
        {
            try
            {
                Direccion result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    //Llamada directa contra BBDD
                    //result = db.Direccion.Find(direccionGuid);
                    //result.Pais = db.Pais.Find((Guid)result.UIDPais);
                    //result.Provincia = db.Provincia.Find((Guid)result.UIDProvincia);

                    //Llamada a procedimientos almacenados
                    var direccionGuidParameter = new SqlParameter("UIDDireccion", direccionGuid);
                    result = db.Database.SqlQuery<Direccion>("exec GetDireccionById @UIDDireccion ", direccionGuidParameter).ToList<Direccion>().FirstOrDefault();
                    result.Pais = PaisDAL.getPaisById((Guid)result.UIDPais);
                    result.Provincia = ProvinciaDAL.getProvinciaById((Guid)result.UIDProvincia);
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return null;
            }
        }

        public static List<Direccion> getAllDirecciones()
        {
            try
            {
                List<Direccion> result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {

                    //Llamada directa a BBDD
                    //result = db.Direccion.ToList();
                    //foreach (var direccion in result)
                    //{
                    //    try
                    //    {
                    //        direccion.Pais = db.Pais.Find((Guid)direccion.UIDPais);
                    //        direccion.Provincia = db.Provincia.Find((Guid)direccion.UIDProvincia);
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Console.Write(ex.ToString());
                    //    }

                    //}

                    //Llamada a procedimientos almacenados
                    result = db.Database.SqlQuery<Direccion>("exec GetAllDirecciones").ToList<Direccion>();
                    foreach (Direccion direccion in result)
                    {
                        try
                        {
                            direccion.Pais = PaisDAL.getPaisById((Guid)direccion.UIDPais);
                            direccion.Provincia = ProvinciaDAL.getProvinciaById((Guid)direccion.UIDProvincia);
                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex.ToString());
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Direccion>();
            }
        }


    }
}
