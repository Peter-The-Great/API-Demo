namespace API_Demo.Data;
using Microsoft.EntityFrameworkCore;

    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<API_Demo.Models.Vak> Vak { get; set; } = default!;
    }
