using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeptaKit.DI;
using System.Linq;
using AbrPlus.Integration.OpenERP.SampleERP.Options;
using AbrPlus.Integration.OpenERP.SampleERP.Repository.DI;
using AbrPlus.Integration.OpenERP.SampleERP.Service.DI;
using AbrPlus.Integration.OpenERP.SampleERP.Api.DI;
using AbrPlus.Integration.OpenERP.Hosting.DI;
using AbrPlus.Integration.OpenERP.Hosting.Hosting;
using AbrPlus.Integration.OpenERP.DI;
using SeptaKit.Repository;
using Noyan.Repository2;
using Noyan.Repository2.Models;
using Microsoft.EntityFrameworkCore;

namespace AbrPlus.Integration.OpenERP.SampleERP.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.GeneralConfigure(Configuration);

            services.Configure<SampleErpOption>(x => Configuration.GetSection("App").Bind(x));
            services.Configure<ConnectionStringOption>(x => Configuration.GetSection("ConnectionStringOption").Bind(x));

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<NoyanDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddScoped<ITrackingRepository<Sefactor>, TrackingRepository<Sefactor>>();
            services.AddScoped<ITrackingRepository<Vwsehesab>, TrackingRepository<Vwsehesab>>();
            services.AddScoped<ITrackingRepository<Vwsewsgetinvoice>, TrackingRepository<Vwsewsgetinvoice>>();
            services.AddScoped<ITrackingRepository<Vwsewsgetproforma>, TrackingRepository<Vwsewsgetproforma>>();
            services.AddScoped<ITrackingRepository<Vwsewsgetreturninvoice>, TrackingRepository<Vwsewsgetreturninvoice>>();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<InfrastructureDIModule>();
            builder.RegisterModule<ExtendedDIModule>();
            builder.RegisterModule<RepositoryDIModule>();
            builder.RegisterModule<ServiceDIModule>();
            builder.RegisterModule<ApiDIModule>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });

            app.UseEndpoints(endpoints =>
            {
                var asembely = typeof(Startup).Assembly;
                var apiTypes = asembely.GetTypes().Where(x => typeof(IApi).IsAssignableFrom(x) && !x.IsInterface).ToList();
                foreach (var apiType in apiTypes)
                {
                    endpoints.UseSoapEndPoint(apiType);
                    endpoints.UseGrpcEndPoint(apiType);
                }
            });
        }


    }

}
