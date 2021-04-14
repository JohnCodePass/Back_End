using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Back_End.Models;

namespace Back_End.Context
{
    public class Data : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Path> Paths { get; set; }
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
            builder.Entity<UserInfo>().HasData(userFixedData);
            builder.Entity<Route>().HasData(routeFixedData);
            builder.Entity<Path>().HasData(pathFixedData);
        }
    }
}