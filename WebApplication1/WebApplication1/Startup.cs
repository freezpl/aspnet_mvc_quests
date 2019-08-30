using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestBLL;
using QuestBLL.Interfaces;
using QuestDAL;

namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            new QuestDbContext();
            //services.AddDbContext<QuestDbContext>(options => options.UseSqlServer(connection));
            //services.AddTransient<IService, SqlQuestService>( serviceProvider =>
            //    {
            //    return new SQLRepository(serviceProvider.GetService<QuestDbContext>());
            //    );
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvc( 
                routes =>
                {
                    routes.MapRoute(
                    name: "default",
                    template: "{controller=Quest}/{action=Quests}/{id?}");
                });
        }
    }
}
