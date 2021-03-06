using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StudentEndOfDay> Students { get; set; }

        public DbSet<StudentEndOfTerm> StudentRecords {get;set;}

        public DbSet<GradeClass> GradeStudent {get;set;}
    }
}