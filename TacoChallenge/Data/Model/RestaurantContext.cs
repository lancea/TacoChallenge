using Microsoft.EntityFrameworkCore;
using TacoChallenge.Models;

namespace TacoChallenge.Data.Model
{
    public class RestaurantContext : DbContext
    {
        private RestaurantContext()
        { }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
       : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //foreach (var entity in modelBuilder.Model.GetEntityTypes())
            //{
            //    modelBuilder.Entity(entity.Name).ToTable(entity.ClrType.Name + "s");
            //}

            modelBuilder
                .Entity<Category>(eb =>
                {
                    //eb.HasNoKey();
                    eb.HasKey(x => x.Id);
                    eb.HasMany(x => x.MenuItems);
                    eb.ToView("View_Categories");
                })
                .Entity<MenuItem>(eb =>
                {
                    eb.HasKey(x => x.Id);
                    eb.ToView("View_MenuItems");
                })
                .Entity<Restaurant>(eb =>
                {
                    eb.HasKey(x => x.Id);
                    eb.HasMany(x => x.Categories);
                    eb.ToView("View_Restaurants");
                });
        }

        public DbSet<Restaurant> Restaurant { get; set; }
    }
}