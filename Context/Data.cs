using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Back_End.Models;

namespace Back_End.Context
{
    public class Data : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<UserFavorite> Favorites { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Path> Paths { get; set; }
        public DbSet<Stop> Stop { get; set; }
        public DbSet<RiderAlert> RiderAlert { get; set; }
        public DbSet<Fare> Fares { get; set; }

        public Data(DbContextOptions<Data> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }
        private void SeedData(ModelBuilder builder)
        {
            var userFixedData = new List<UserInfo>
            {
                new UserInfo(1, "huegogh", "password", "email"),
            };
            var routeFixedData = new List<Route>
            {
                new Route(1, 40, "BART EXPRESS"),
            };
            var pathFixedData = new List<Path>
            {
                new Path(1,  42, "BRT-Express", "Weekday", "North", "['stop 1']", "[['9:55am']]"),
            };
            var stopFixedData = new List<Stop>
            {
                new Stop(1, "DTC Depart", "E Weber Ave, Stockton, CA 95202","0","0"),
            };
            var favoriteFixedData = new List<UserFavorite>
            {
                new UserFavorite(1, "huegogh", "DTC Depart","E Weber Ave, Stockton, CA 95202","Pacific & Ben Holt"),
            };
            var riderAlertFixedData = new List<RiderAlert>
            {
                new RiderAlert(1, "1/1/2021", "title","content"),
            };
            var fareFixedData = new List<Fare>
            {
                new Fare(1, "Full-test", "Local-test","1-Ride", "$1.50"),
            };
            builder.Entity<UserInfo>().HasData(userFixedData);
            builder.Entity<Route>().HasData(routeFixedData);
            builder.Entity<Path>().HasData(pathFixedData);
            builder.Entity<Fare>().HasData(fareFixedData);
            builder.Entity<UserFavorite>().HasData(favoriteFixedData);
        }
    }
}