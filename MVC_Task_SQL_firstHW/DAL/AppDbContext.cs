using Microsoft.EntityFrameworkCore;
using MVC_Task_SQL_firstHW.Models;

namespace MVC_Task_SQL_firstHW.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }

    }
}
