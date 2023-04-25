using Microsoft.EntityFrameworkCore;
using SFCredito.Data;
using SFCredito.Data.Contexto;
using SFCredito.Dominio;
using SFCredito.Web.AutoMapper;

namespace SFCredito.Web
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
            var teste = Configuration.GetConnectionString("DefaultConnection");
            #region Configuracao Entity fremework Postgrer  
            services.AddDbContext<SFcreditoContext>(options =>
            options.UseNpgsql(teste), ServiceLifetime.Transient);
            #endregion

            //injetando as dependências camada serivices
            services.RegisterServices();

            //injetando as dependências camada Data persistencias de dados
            services.RegisterData();

            //Configurando AutoMap
            services.AddAutoMapper(typeof(MappingProfile));

            #region Session
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = System.TimeSpan.FromSeconds(2400);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
