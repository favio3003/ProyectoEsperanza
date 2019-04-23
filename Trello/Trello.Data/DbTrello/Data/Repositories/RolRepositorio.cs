
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Trello.Domain.Entities;
using Trello.Data.DbTrello.Data.Models;

namespace Data.Trello.DbTrello.Data.Repositories
{
    class RolRepositorio : EntityFRepositorio<rol>
    {
        public int GuardarRol (string nombre, string descripcion)
        {
            rol Rol = new rol()
            {
                Nombre = nombre,
                Descripcion = descripcion
            };
            Add(Rol);
            SaveChanges();
            return Rol.idRol;
        }

        public void ModificarRol (int id, string nombre, string descripcion)
        {
            rol Rol = Get(id);
            Rol.Nombre = nombre;
            Rol.Descripcion = descripcion;
            Update(Rol);
            SaveChanges();
        }

        public void EliminarRol (int id)
        {
            rol Rol = Get(id);
            Remove(Rol);
            SaveChanges();
        }

        public rol ObtenerRol (int id)
        {
            return Get(id);
        }

        public List<rol> ObtenerRoles ()
        {
            return GetAll().OrderBy(x => x.Nombre).ToList();
        }

        public List<rol> ObtenerRolDto ()
        {
            return BuildQuery().Select(Rol => new rol()
            {
                idRol = Rol.idRol,
                Nombre = Rol.Nombre,
                Descripcion = Rol.Descripcion
            }).ToList();
        }
    }
}
