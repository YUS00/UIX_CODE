//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace G7_Users
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int idUser { get; set; }
        public string CodeUser { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> idUserRank { get; set; }
        public Nullable<int> idUserCategory { get; set; }
        public string Photo { get; set; }
        public Nullable<int> idPlanet { get; set; }
        public Nullable<int> idSpecie { get; set; }
        public Nullable<int> level { get; set; }
    
        public virtual Planets Planets { get; set; }
        public virtual Species Species { get; set; }
        public virtual UserCategories UserCategories { get; set; }
        public virtual UserRanks UserRanks { get; set; }
    }
}
