﻿using Microsoft.EntityFrameworkCore;
using RemSlyCore.Models;
using RemSlyCore.Datas;

namespace RemSlyApi.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Commentary> Commentaries { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(InitialClub.clubInit);
            modelBuilder.Entity<Session>().HasData(InitialClub.sessionInit);
            modelBuilder.Entity<User>().HasData(InitialUser.UserInit);
        }


    }
}
