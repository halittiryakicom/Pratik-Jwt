using Microsoft.EntityFrameworkCore;
using Pratik_Jwt.Model;

namespace Pratik_Jwt.Context
{
    public class IdentityandDataProtectionDbContext : DbContext
    {
        
        public IdentityandDataProtectionDbContext(DbContextOptions<IdentityandDataProtectionDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
