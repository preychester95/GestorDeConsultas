using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
namespace CyC.GestorDeContactos.AccesoDatos.DAL
{
    public static class PaisDAL
    {

        public static List<Pais> getAllPaises()
        {
            try
            {
                List<Pais> result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    //Llamada directa contra BBDD
                    //result = db.Pais.ToList();

                    //Llamada a procedimientos almacenados
                    result = db.Database.SqlQuery<Pais>("exec GetAllPaises").ToList<Pais>();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Pais>();
            }
        }

        public static Pais getPaisById(Guid guidPais)
        {
            try
            {
                Pais result;
                using (CYC_PracticasEntities db = new CYC_PracticasEntities())
                {
                    var paisGuidParameter = new SqlParameter("@UIDPais", guidPais);
                    result = db.Database.SqlQuery<Pais>("exec GetPaisById @UIDPais", paisGuidParameter).ToList<Pais>().FirstOrDefault();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return null;
            }
        }

    }
}
