using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}