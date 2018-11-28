using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
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
                    result = db.Pais.ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Pais>();
            }
        }

    }
}
