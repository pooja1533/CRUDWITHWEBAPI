using CORSANDMediaTR.Models;
using Microsoft.EntityFrameworkCore;

namespace CORSANDMediaTR.Data
{
    public class DbcontextClass:DbContext
    {
        private readonly IConfiguration _configuration;
        public DbcontextClass(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<StudentDetail> students { get; set; }  
    }
}
