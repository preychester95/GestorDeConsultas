using CyC.GestorDeContactos.AccesoDatos.DAL;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;

namespace CyC.GestorDeContactos.BLL.BLL
{
    public static class DireccionBLL
    {
        public static void createDireccion(Direccion direccion)
        {
            DireccionDAL.createDireccion(direccion);
        }

        public static Direccion getDireccionByGuid(Guid direccionGuid)
        {
            return DireccionDAL.getDireccionByGuid(direccionGuid);
        }

        public static List<Direccion> getAllDirecciones()
        {
            return DireccionDAL.getAllDirecciones();
        }
    }
}
