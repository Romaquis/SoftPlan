using Api.Domain.Entitys;
using Api.Infrastructure.CrossCutting.IOC;
using Api.Infrastructure.Data;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace Product.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddDbContext<SqlContext>(opt => opt.UseInMemoryDatabase("Store"));
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            CategoryMock(app.ApplicationServices.GetService<SqlContext>());
        }


        private static void CategoryMock(SqlContext context)
        {
            var categoryList = new List<Category>
            {
                new Category { Title = "Brinquedos", Margin = 25 },
                new Category { Title = "Bebidas", Margin = 30 },
                new Category { Title = "Informática", Margin = 10 },
                new Category { Title = "Softplan", Margin = 5 },
                new Category { Title = "Toda e qualquer outra categoria informada", Margin = 15 }
            };

            foreach (Category c in categoryList)
            {
                context.Categories.Add(c);
            }

            context.SaveChanges();
        }

    }
}
