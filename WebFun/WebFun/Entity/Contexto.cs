using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using WebFun.Entity;
using System.Data.Entity;

namespace WebFun.Entity
{
    public class Contexto : DbContext
    {

        public Contexto()
            : base("Vendas2")
        {
           
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>());
        }

        public DbSet<Produt> Produtos { get; set; }

        protected virtual void OnModelCreating
               (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produt>()
              .Property(r => r.descricao).IsRequired();
        }
    }
}