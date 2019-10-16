using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ProAspNetCoreMvcRouting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMvcWithDefaultRoute();
            //app.UseMvc();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(routes => {
                //routes.MapRoute(name: "app", template: "App{controller=Home}/{action=Index}");
                //routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}");
                //routes.MapRoute(name: "", template: "Public/{controller}/{action=Index}");
                routes.MapRoute(name: "parametro", template: "{controller=Home}/{action=Index}/{id=Vazio}");
            });
        }
    }
}
