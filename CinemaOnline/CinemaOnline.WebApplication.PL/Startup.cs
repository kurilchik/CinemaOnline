using AutoMapper;
using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.DAL.DataModels;
using CinemaOnline.DAL.Repositories;
using CinemaOnline.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CinemaOnline.WebApplication.PL
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
            services.AddControllersWithViews();

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<TicketDbContext>(options => options.UseSqlServer(connection));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<IFilmService, FilmService>();
            services.AddTransient<ITopUpService, TopUpService>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITopUpRepository, TopUpRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<IFilmRepository, FilmRepository>();
            services.AddTransient<ISessionRepository, SessionRepository>();

            var mapperConfig = new MapperConfiguration(mc =>
                {
                   mc.AddProfile(new MappingProfile());
                 });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Films}/{action=Index}/{id?}");
            });
        }
    }
}
