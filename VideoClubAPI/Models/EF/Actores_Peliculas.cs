//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoClubAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actores_Peliculas
    {
        public int idActor_Pelicula { get; set; }
        public int idPelicula { get; set; }
        public int idActor { get; set; }
        public Nullable<int> Sueldo { get; set; }
    
        public virtual Actores Actores { get; set; }
        public virtual Peliculas Peliculas { get; set; }
    }
}
