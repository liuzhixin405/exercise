using CAP.MySql.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAP.MySql
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CAP.MySql", Version = "v1" });
            });
            services.AddDbContext<CoreDbContext>(options => options.UseMySql(Configuration.GetConnectionString("ExamOnlineCon"), MySqlServerVersion.LatestSupportedServerVersion));
            services.AddControllers();

            services.AddCap(x =>
            {
                x.UseMySql(Configuration.GetConnectionString("ExamOnlineCon"));
                x.UseEntityFramework<CoreDbContext>();
                x.UseRabbitMQ(
                    rb =>
                    {
                        rb.HostName = "47.94.198.11";
                        rb.UserName = "admin";
                        rb.Password = "admin";
                        rb.Port = 5672;
                        rb.VirtualHost = "/";
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CAP.MySql v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
