//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trello.Data.DbTrello.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trabajo
    {
        public int idTrabajo { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal Tiempotrabajada { get; set; }
        public string Comentario { get; set; }
        public System.DateTime Fechaguardado { get; set; }
        public int idRequisitos { get; set; }
        public int idUsuario { get; set; }
    
        public virtual requisitos requisitos { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
