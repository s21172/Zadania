using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cwiczenia7.Models;
using cwiczenia7.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using cwiczenia7.Repositories.Implementation;
using System.Text.Json.Serialization;

namespace cwiczenia7
{
    public class Startup
    {
        public Startup ( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices ( IServiceCollection services )
        {

            services.AddDbContext<_2019SBDContext>( options =>
            {
                options.UseSqlServer( Configuration.GetConnectionString( "MssqlDbConnString" ) );

            } );

            services.AddScoped<ITripsHandler, TripsHandler>();
            services.AddScoped<IClientHandler, ClientHandler>();

            services.AddControllers();
            services.AddSwaggerGen( c =>
             {
                 c.SwaggerDoc( "v1", new OpenApiInfo { Title = "Zad 7 - Client - trip", Version = "v1" } );
             } );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI( c => c.SwaggerEndpoint( "/swagger/v1/swagger.json", "v1" ) );
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints( endpoints =>
             {
                 endpoints.MapControllers();
             } );
        }
    }
}
