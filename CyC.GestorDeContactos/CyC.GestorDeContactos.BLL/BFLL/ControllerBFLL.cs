using CyC.GestorDeContactos.AccesoDatos.DTO;
using CyC.GestorDeContactos.BLL.BLL;
using System;
using System.Collections.Generic;

namespace CyC.GestorDeContactos.BLL.BFLL
{
    public class ControllerBFLL
    {
        //Llamadas a métodos de ContactoBLL
        public void createPersona(string nombre)
        {
            ContactoBLL.createPersona(Guid.NewGuid(), nombre);
        }

        public void createContacto(Contacto contacto)
        {
            ContactoBLL.createContacto(contacto);
        }

        public void updateContacto(Contacto contacto)
        {
            ContactoBLL.updateContacto(contacto);
        }

        public Contacto getContactoByGuid(Guid contactoGuid)
        {
            return ContactoBLL.getContactoByGuid(contactoGuid);
        }

        public void deleteContacto(Contacto contacto)
        {
            ContactoBLL.deleteContacto(contacto);
        }

        //Llamadas a métodos de DireccionBLL
        public void createDireccion(Direccion direccion)
        {
            DireccionBLL.createDireccion(direccion);
        }

        public Direccion getDireccionByGuid(Guid direccionGuid)
        {
            return DireccionBLL.getDireccionByGuid(direccionGuid);
        }

        public List<Direccion> getAllDirecciones()
        {
            return DireccionBLL.getAllDirecciones();
        }

        //Llamadas a métodos de PaisBLL
        public List<Pais> getAllPaises()
        {
            return PaisBLL.getAllPaises();
        }

        //Llamadas a métodos de ProvinciaBLL
        public List<Provincia> getAllProvincias()
        {
            return ProvinciaBLL.getAllProvincias();
        }
    }
}
