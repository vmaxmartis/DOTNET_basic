using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class VContext : DbContext
    {
        //cung cấp phương thức tương tác vs db
        public VContext(DbContextOptions<VContext> options) : base(options)
        {

        }

        public DbSet<a.Core.Entities.Employee> Employee { get; set; }
        public DbSet<a.Core.Entities.Lab> Lab { get; set; }

    }
}
