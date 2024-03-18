using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Domain.Entities;
using TravelAgency.Infrastructure.Identity;

namespace TravelAgency.Infrastructure
{
    public class TravelAgencyContext : IdentityDbContext<User>
    {
        public TravelAgencyContext(DbContextOptions options) : base(options)
        {

        }
        //Create an instance to be mapped as a table.
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
         public DbSet<Hotel> Hotels { get; set; }
        

        //Override the method to make each Agency's name unique.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Here we can add other restrictions if needed.
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Agency>().HasIndex(x => x.Name).IsUnique();
            

            
        }
        


    }
}