using Microsoft.EntityFrameworkCore;

namespace VerticalSliceArchitecture.Database
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
    }
}
