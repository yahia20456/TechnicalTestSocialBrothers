using Microsoft.EntityFrameworkCore;

namespace TechnicalTestSocialBrothers.Properties.Models
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options )
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<AddressInformation> Adresses { get; set; }
    }
}
