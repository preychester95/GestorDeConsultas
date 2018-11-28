
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;
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
                    result = db.Provincia.ToList();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Provincia>();
            }
        }

    }
}
