﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace КурсоваяWPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarkinD_327Entities3 : DbContext
    {
        public MarkinD_327Entities3()
            : base("name=MarkinD_327Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Count> Count { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Orderr> Orderr { get; set; }
        public virtual DbSet<OrderrProduct> OrderrProduct { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Rolles> Rolles { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Userss> Userss { get; set; }
    }
}