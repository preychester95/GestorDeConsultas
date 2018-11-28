using CyC.GestorDeContactos.AccesoDatos.DAL;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System.Collections.Generic;

namespace CyC.GestorDeContactos.BLL.BLL
{
    public static class ProvinciaBLL
    {

        public static List<Provincia> getAllProvincias()
        {
            return ProvinciaDAL.getAllProvincias();
        }
    }
}
