using JwtWebApi.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using JwtWebApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApi.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class JwtWebApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-IRRMMDJ; database = JwtWebApi; integrated security = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppRoleMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
