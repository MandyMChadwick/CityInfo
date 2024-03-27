using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
namespace CityInfo.API.DbContexts
{
    public class CityInfoContext: DbContext
    {
        public DbSet<City> Citys { get; set;}
        public DbSet<PointOfInterest> PointOfInterests { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("connectionstring");
            base.OnConfiguring(optionsBuilder);
        }





    }
}
