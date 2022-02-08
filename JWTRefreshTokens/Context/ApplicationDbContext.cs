using JWTRefreshTokens.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTRefreshTokens.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

    }
}
