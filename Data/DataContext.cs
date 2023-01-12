using Microsoft.EntityFrameworkCore;

namespace RestWebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        
        }

        public DbSet<Items> Items => Set<Items>();
    }
}
