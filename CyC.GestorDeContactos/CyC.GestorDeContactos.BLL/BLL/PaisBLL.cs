
using CyC.GestorDeContactos.AccesoDatos.DAL;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System.Collections.Generic;
namespace CyC.GestorDeContactos.BLL.BLL
{
    public static class PaisBLL
    {

        public static List<Pais> getAllPaises()
        {
            return PaisDAL.getAllPaises();
        }

    }
}
