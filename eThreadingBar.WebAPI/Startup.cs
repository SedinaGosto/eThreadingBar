using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eThreadingBar.Model.Requests;

using eThreadingBar.WebAPI.Database;
using eThreadingBar.WebAPI.Security;
using eThreadingBar.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Swagger;


namespace eThreadingBar.WebAPI
{
    public class Startup
    {
        public class BasicAuthDocumentFilter : IDocumentFilter
        {
            public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
            {
                var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

                swaggerDoc.Security = new[] { securityRequirements };
            }
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });
            services.AddAuthentication("BasicAuthentication")
     .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
           
            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<IkorisniciService, KorisniciService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Database.Uloga>>();
            services.AddScoped<ICRUDService<Model.Klijent, KlijentSearchRequest, KlijentInsertRequest,KlijentInsertRequest>, KlijentService >();
            services.AddScoped<ICRUDService<Model.Grad, GradSearchRequest,GradInsertRequest,GradInsertRequest>, GradService>();
            services.AddScoped<ICRUDService<Model.Tretman, TretmanSearchRequest, TretmanInsertRequest, TretmanInsertRequest>,
       TretmanService>();

            services.AddScoped<ICRUDService<Model.Nagrada, NagradaSearchRequest, NagradaInsertRequest, NagradaInsertRequest>, NagradaService>();
            services.AddScoped<ICRUDService<Model.NagradnaIgra, NagradnaIgraSearchRequest, NagradnaIgraInsertRequest, NagradnaIgraInsertRequest>,NagradnaIgraService>();
          
            services.AddScoped<ICRUDService<Model.Termin, TerminSearchRequest, TerminInsertRequest, TerminInsertRequest>, TerminService>();

            services.AddScoped<ICRUDService<Model.ClanakKategorija, ClanakKategorijaSearchRequest, ClanakKategorijaInsertRequest, ClanakKategorijaInsertRequest>, ClanakKategorijaService>();
            
            services.AddScoped<ICRUDService<Model.Clanak, ClanakSearchRequest, ClanakInsertRequest, ClanakInsertRequest>, ClanakService>();
            services.AddScoped<ICRUDService<Model.Rezervacija, RezervacijaSearchRequest, RezervacijaInsertRequest, RezervacijaInsertRequest>, RezervacijaService>();
            services.AddScoped<ICRUDService<Model.PoslataNotifikacija, PoslataNotifikacijaSearchRequest, PoslataNotifikacijaInsertRequest, PoslataNotifikacijaInsertRequest>, PoslataNotifikacijaService>();
            services.AddScoped<ICRUDService<Model.KlijentNotifikacija, KlijentNotifikacijaSearchRequest, KlijentNotifikacijaInsertRequest, KlijentNotifikacijaInsertRequest>, KlijentNotifikacijaService>();



            var connection = @"data source=.;initial catalog=160085; integrated security = True; ";
            services.AddDbContext<BeautyStudio2019Context>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
          
            //app.UseHttpsRedirection();
         
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
