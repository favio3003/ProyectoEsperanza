using Data.Trello.DbTrello.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.Data.DbTrello.Data.Models;

namespace Data.Trello.Domain.Services
{
    public class RolService
    {
        private readonly RolRepositorio rolRepositorio;

        public RolService()
        {
            this.rolRepositorio = new RolRepositorio();
        }

        public int GuardarRol (int id, string nombre, string descripcion)
        {
            if (id == 0)
                id = rolRepositorio.GuardarRol(nombre, descripcion);
            else
                rolRepositorio.ModificarRol(id, nombre, descripcion);
            return id;
        }

        public void EliminarRol (int id)
        {
            rolRepositorio.EliminarRol(id);
        }

        public rol ObtenerRol (int id)
        {
            return rolRepositorio.ObtenerRol(id);
        }

        public List<rol> ObtenerRoles ()
        {
            return rolRepositorio.ObtenerRoles();
        }
    }
}
