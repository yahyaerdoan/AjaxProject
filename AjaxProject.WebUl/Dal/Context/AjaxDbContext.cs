using AjaxProject.WebUl.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace AjaxProject.WebUl.Dal.Context
{
    public class AjaxDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YAHYAERDOGAN; initial catalog=AjaxProjeDb; integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
