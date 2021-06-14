using Lemontea.Client.Api;
using Lemontea.Client.Services;
using Lemontea.Client.Services.Impl;
using Lemontea.Client.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System;

namespace Lemontea.Client
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
      T Configure<T>(string sectionName) where T : class
      {
        var section = Configuration.GetSection(sectionName);
        var settings = section.Get<T>();
        services.Configure<T>(section);

        return settings;
      }

      var appSettings = Configure<AppSettings>(nameof(AppSettings));

      services.AddControllersWithViews().AddRazorRuntimeCompilation();

      services.AddKendo();

      services.AddRefitClient<ILemonteaApi>()
        .ConfigureHttpClient(c => c.BaseAddress = new Uri(appSettings.LemonteaApiBaseUrl));

      services.AddScoped<IAziendaService, AziendaService>();
      services.AddScoped<ICountryService, CountryService>();
      services.AddScoped<IContattoService, ContattoService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
