using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PcColletion.InfraStructure;
using PcColletion.InfraStructure.Repository;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.Api
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
            services.AddDbContext<BaseDbContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection"),
                  sqlServerOptions => sqlServerOptions.CommandTimeout(32767)));

            ScopeService(services);

            AddSingletonService(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        private void AddSingletonService(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(new HttpClient() { Timeout = TimeSpan.FromDays(1) });

        }

        private void ScopeService(IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped(typeof(IBaseGenericRepository<,,>), typeof(BaseGenericRepository<,,>));
            services.AddScoped<ICategorieRepository, CategorieRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            ServiceGetter.SetAccessor(httpContextAccessor);

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
