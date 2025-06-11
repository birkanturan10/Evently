using Microsoft.EntityFrameworkCore;
using EntityLayer;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
