using Employee_JisaHW.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_JisaHW.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
