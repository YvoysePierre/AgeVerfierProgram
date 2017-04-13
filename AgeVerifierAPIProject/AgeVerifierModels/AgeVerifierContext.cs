using Microsoft.EntityFrameworkCore;

namespace AgeVerifierWebApplication.AgeVerifierModels
{
    public class AgeVerifierContext : DbContext
    {
        public AgeVerifierContext(DbContextOptions<AgeVerifierContext> options)
            : base(options)
        {
        }

        public DbSet<AgeVerifierItem> AgeVerifier { get; set; }

    }
}