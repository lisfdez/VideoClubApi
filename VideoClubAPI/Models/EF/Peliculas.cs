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
    
    public partial class Peliculas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Peliculas()
        {
            this.Actores_Peliculas = new HashSet<Actores_Peliculas>();
        }
    
        public int idPelicula { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
        public string Pais { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> idCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actores_Peliculas> Actores_Peliculas { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
