using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Integration.Mvc;
using EntityModels.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestBLL;
using QuestBLL.Interfaces;
using QuestDAL;
using QuestDAL.Interfaces;
using QuestDAL.Repository;

namespace WebApplication1
{
    public class Startup
    {
        IConfiguration _configuration;

        public IContainer ApplicationContainer { get; private set; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            string connection = _configuration.GetConnectionString("SQLConnection");

            services.AddDbContext<QuestDbContext>(options => options.UseSqlServer(connection));

            services.AddMvc();

            ///autofac
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.Populate(services);
            var _dbContextOptionsBuilder = new DbContextOptionsBuilder<QuestDbContext>();
            _dbContextOptionsBuilder.UseSqlServer(connection);
         
            builder.RegisterGeneric(typeof(SQLRepository<>)).As(typeof(IRepository<>))
                .WithParameter("context", services.BuildServiceProvider().GetService<QuestDbContext>());
            builder.RegisterType<SqlQuestService>().As<IService>();
            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
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
