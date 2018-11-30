
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
namespace CyC.GestorDeContactos.AccesoDatos.DAL
{
    public static class ProvinciaDAL
    {

        public static List<Provincia> getAllProvincias()
        {
            try
            {
                List<Provincia> result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    //Llamada directa contra BBDD
                    //result = db.Provincia.ToList();

                    //Llamada a procedimientos almacenados
                    result = db.Database.SqlQuery<Provincia>("exec GetAllProvincias").ToList<Provincia>();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Provincia>();
            }
        }

        public static Provincia getProvinciaById(Guid guidProvincia)
        {
            try
            {
                Provincia result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    var provinciaGuidParameter = new SqlParameter("@UIDProvincia", guidProvincia);
                    result = db.Database.SqlQuery<Provincia>("exec GetProvinciaById @UIDProvincia", provinciaGuidParameter).ToList<Provincia>().FirstOrDefault();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new Provincia();
            }
        }

    }
}
