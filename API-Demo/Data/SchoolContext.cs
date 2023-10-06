namespace API_Demo.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

    public class SchoolContext : IdentityDbContext
{
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Vak> Vak { get; set; } = default!;
    }
