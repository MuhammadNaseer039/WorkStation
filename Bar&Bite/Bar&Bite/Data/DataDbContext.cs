using Bar_Bite.Models;
using Microsoft.EntityFrameworkCore;

namespace Bar_Bite.Data
{
    public class DataDbContext:DbContext
    {
      
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
