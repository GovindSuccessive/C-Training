﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramworkProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_Employee1Entities : DbContext
    {
        public db_Employee1Entities()
            : base("name=db_Employee1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Department> tb_Department { get; set; }
        public virtual DbSet<tb_Employee> tb_Employee { get; set; }
        public virtual DbSet<tb_OrderDetails> tb_OrderDetails { get; set; }
        public virtual DbSet<tb_Orders> tb_Orders { get; set; }
        public virtual DbSet<tb_Products> tb_Products { get; set; }
    }
}
