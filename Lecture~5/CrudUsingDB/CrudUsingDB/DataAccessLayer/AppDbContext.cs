using CrudUsingDB.Model;
using CrudUsingDB.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudUsingDB.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<_20b1Context> options)
        : base(options)
        {
        }

        public DbSet<Employee> emp { get; set; }

    }
}
