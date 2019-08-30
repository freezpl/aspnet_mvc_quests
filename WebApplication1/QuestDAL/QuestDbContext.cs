using EntityModels.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestDAL
{
    public class QuestDbContext : DbContext
    {
        public QuestDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<QuestEntity> Quests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestEntity>().HasData(
                new QuestEntity[]
                {
                    new QuestEntity {Id = 1, Name = "Quest1"},
                    new QuestEntity {Id = 2, Name = "Quest2"},
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
