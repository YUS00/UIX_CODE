﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UsersEntities : DbContext
    {
        public UsersEntities()
            : base("name=UsersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Planets> Planets { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<UserCategories> UserCategories { get; set; }
        public virtual DbSet<UserRanks> UserRanks { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
