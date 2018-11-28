using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
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
                    db.Direccion.Add(direccion);
                    db.SaveChanges();
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
                    result = db.Direccion.Find(direccionGuid);
                    result.Pais = db.Pais.Find((Guid)result.UIDPais);
                    result.Provincia = db.Provincia.Find((Guid)result.UIDProvincia);
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
                    result = db.Direccion.ToList();
                    foreach (var direccion in result)
                    {
                        try
                        {
                            direccion.Pais = db.Pais.Find((Guid)direccion.UIDPais);
                            direccion.Provincia = db.Provincia.Find((Guid)direccion.UIDProvincia);
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
