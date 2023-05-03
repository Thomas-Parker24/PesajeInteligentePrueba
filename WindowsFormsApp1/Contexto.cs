using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;


namespace WindowsFormsApp1
{
    public partial class Contexto : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        public Contexto()
            : base("name = Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
        }
    }

}
