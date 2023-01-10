
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using DesafioBackend.Infra.Data;
using DesafioBackend.application.Services;
using DesafioBackend.Domain.Interfaces;
using Microsoft.OpenApi.Models;
using DesafioBackend.Integrations.CotacaoMoedas;

namespace DesafioBackend.Apis.Web
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
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ICotacaoMoedaService, CotacaoMoedaService>();
            services.AddScoped<ICotacaoMoedasClient, CotacaoMoedasClient>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("V1", new OpenApiInfo { Title = "DesafioBackend", Version = "V1" });
            });

            services.AddInfrastructure(Configuration);      
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();                
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/V1/swagger.json", "DesafioBackend.Api V1"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });           
        }
    }
}
