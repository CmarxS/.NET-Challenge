using ChallengeMottu.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChallengeMottu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Moto> Motos { get; set; }

    }
}
