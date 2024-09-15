using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sopra_Steria.Data;

namespace Sopra_Steria.Models
{
    public class NewsDB : DbContext
    {
        public NewsDB(DbContextOptions<NewsDB> options)
            : base(options)
        {
        }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Teammember> Teammembers { get; set; }
    }
}
