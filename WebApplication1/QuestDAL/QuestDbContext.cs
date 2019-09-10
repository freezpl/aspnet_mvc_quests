using EntityModels.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestDAL
{
    public class QuestDbContext : IdentityDbContext<UserEntity>
    {
        public QuestDbContext(DbContextOptions<QuestDbContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }

        public DbSet<QuestEntity> Quests { get; set; }
        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<ImageEntity> Images { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CompanyEntity>().HasData(
            //    new CompanyEntity[]
            //    {
            //        new CompanyEntity{Id = 1, Name = "FearCorporation", Logo="fear.jpg"},
            //        new CompanyEntity{Id = 2, Name = "BlackBox", Logo="box.jpg"},
            //    });

            //modelBuilder.Entity<QuestEntity>().HasData(
            //    new QuestEntity[]
            //    {
            //        new QuestEntity {Id = 1, Name = "Quest1111", CompanyId=1, Address = "Dubno", Email="admin@gamil.com",
            //            Description="Very scary", FearLevel=5, HardLevel=5, MaxPlayers=10, MinAge=21, MinPlayers=3, Phone="066-85-26-406",
            //        Raiting=8.5, WalkTime=TimeSpan.FromMinutes(180)},
            //        new QuestEntity {Id = 2, Name = "Quest2222", CompanyId=1, Address = "Rivne", Email="admin@ukr.net",
            //            Description="Find predmets", FearLevel=1, HardLevel=3, MaxPlayers=5, MinAge=14, MinPlayers=1, Phone="095-32-21-109",
            //        Raiting=9.2, WalkTime=TimeSpan.FromMinutes(160)},
            //    });

            //modelBuilder.Entity<ImageEntity>().HasData(
            //    new ImageEntity[]
            //    {
            //        new ImageEntity{Id = 1, Name = "Img1", Path="1.jpg", QuestId = 1},
            //        new ImageEntity{Id = 2, Name = "Img2", Path="2.jpg", QuestId = 1},
            //        new ImageEntity{Id = 3, Name = "Img3", Path="3.jpg", QuestId = 2},
            //        new ImageEntity{Id = 4, Name = "Img4", Path="4.jpg", QuestId = 2},
            //    });
            base.OnModelCreating(modelBuilder);
        }

    }
}
