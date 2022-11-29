using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option):base(option)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
