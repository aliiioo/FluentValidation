using FluentValidationing.Entites;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationing.Data
{
    public class FluentValdatetionContext:DbContext
    {
        public FluentValdatetionContext(DbContextOptions<FluentValdatetionContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Courses> courses { get; set; }
        public DbSet<Students> Students{ get; set; }
    }
}
