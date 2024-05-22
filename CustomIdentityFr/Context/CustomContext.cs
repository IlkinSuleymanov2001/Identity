using CustomIdentityFr.Entities;
using CustomIdentityFr.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentityFr.Context
{
    public  class CustomContext :IdentityDbContext<AppUser,AppRole,int,IdentityUserClaim<int>,AppUserRole,IdentityUserLogin<int >,IdentityRoleClaim<int>,IdentityUserToken<int> >
    {
        //private IConfiguration _configuration;

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRole> Roles { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail > OrderDetails { get; set; }
        public DbSet<AppUserProfile> userProfiles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ProductCountry> ProductCountries { get; set; }




        public CustomContext(DbContextOptions<CustomContext> options):base(options) 
        {
            //_configuration = configuration;
        }

        public CustomContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 

                optionsBuilder.UseSqlServer(@"Server =(localdb)\mssqllocaldb;Database =IdentityDB;Trusted_Connection=true");

            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
