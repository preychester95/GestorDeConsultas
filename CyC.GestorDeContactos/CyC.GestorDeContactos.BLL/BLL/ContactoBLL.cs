using Cyc.GestorDeContactos.Comunes;
using CyC.GestorDeContactos.AccesoDatos.DAL;
using CyC.GestorDeContactos.AccesoDatos.DTO;
using System;
using System.Collections.Generic;

namespace CyC.GestorDeContactos.BLL.BLL
{
    public static class ContactoBLL
    {
        public static List<Contacto> getAllContactos()
        {
            return ContactoDAL.getAllContactos();
        }

        public static void createPersona(Guid idContacto, string nombre)
        {
            Contacto nuevoContacto = new Contacto();
            nuevoContacto.UIDContacto = idContacto;
            nuevoContacto.Nombre = nombre;
            ContactoDAL.createContacto(nuevoContacto);
        }

        public static void createContacto(Contacto contacto)
        {
            ContactoDAL.createContacto(contacto);
        }

        public static void updateContacto(Contacto contacto)
        {
            contacto.Direccion = null;
            ContactoDAL.updateContacto(contacto);
        }

        public static Contacto getContactoByGuid(Guid contactoGuid)
        {
            return ContactoDAL.getContactoByGuid(contactoGuid);
        }

        public static void deleteContacto(Contacto contacto)
        {
            ContactoDAL.deleteContacto(contacto);
        }

        public static List<Contacto> applyFilter(Filter filtro)
        {
            return ContactoDAL.applyFilter(filtro);
        }
    }
}
