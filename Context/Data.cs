using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Back_End.Models;

namespace Back_End.Context
{
    public class Data : DbContext
    {

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
            var fixedData = new List<UserInfo>{
                new UserInfo(1, "huegogh", "password"),
            };

            builder.Entity<UserInfo>().HasData(fixedData);
        }


    }
}