using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BURAK;initial catalog=DbMimoza; integrated security=true");
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts  { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Food2> Food2s { get; set; }
        public DbSet<Food3> Food3s { get; set; }
        public DbSet<Food4> Food4s { get; set; }
        public DbSet<Food5> Food5s { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Social> Socials { get; set; }
    }
}
