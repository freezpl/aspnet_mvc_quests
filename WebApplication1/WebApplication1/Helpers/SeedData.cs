using EntityModels.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using QuestDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestWebApp.Helpers
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            QuestDbContext context = (QuestDbContext)app.ApplicationServices.GetService(typeof(QuestDbContext));
            context.Database.Migrate();

            if (!context.Companies.Any())
            {
                CompanyEntity[] companies = new CompanyEntity[]
                {
                    new CompanyEntity{Name = "FearCorporation", Logo="fear.jpg"},
                    new CompanyEntity{Name = "BlackBox", Logo="box.jpg"},
                };
                context.AddRange(companies);
                
                QuestEntity[] quests = new QuestEntity[]
                {
                    new QuestEntity {Name = "Escape from house", Company = companies[0], Address = "Dubno", Email="admin@gamil.com",
                        Description="Very scary", FearLevel=5, HardLevel=5, MaxPlayers=10, MinAge=21, MinPlayers=3, Phone="066-85-26-406",
                    Raiting=8.5, WalkTime=TimeSpan.FromMinutes(180)},
                    new QuestEntity {Name = "Find predmets in house", Company = companies[1], Address = "Rivne", Email="admin@ukr.net",
                        Description="Find predmets", FearLevel=1, HardLevel=3, MaxPlayers=5, MinAge=14, MinPlayers=1, Phone="095-32-21-109",
                    Raiting=9.2, WalkTime=TimeSpan.FromMinutes(160)},
                };
                context.AddRange(quests);

                ImageEntity[] images = new ImageEntity[]
                {
                    new ImageEntity{Name = "Img1", Path="1.jpg", Quest = quests[0]},
                    new ImageEntity{Name = "Img2", Path="2.jpg", Quest = quests[0]},
                    new ImageEntity{Name = "Img3", Path="3.jpg", Quest = quests[1]},
                    new ImageEntity{Name = "Img4", Path="4.jpg", Quest = quests[1]},
                };
                context.AddRange(images);
                context.SaveChanges();
            }
        }
    }
}
