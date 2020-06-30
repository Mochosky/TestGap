using Appointments.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace Appointments
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
            services.AddDbContext<AppointmentDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AppointmentContext")));

            services.AddIdentity<User, IdentityRole>(options =>
                {
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 2;
                })
                .AddEntityFrameworkStores<AppointmentDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using (var context = serviceProvider.GetService<AppointmentDbContext>())
            {
                if (context.Database.CanConnect())
                {
                    //
                    context.Database.Migrate();

                    //
                    SeedUserData(serviceProvider, context).Wait();
                }
            }
        }

        private async Task SeedUserData(IServiceProvider serviceProvider, AppointmentDbContext context)
        {
            var userManager = serviceProvider.GetService<UserManager<User>>();

            var superAdminEmail = Configuration.GetValue<string>("Admin:Email");
            var user = await userManager.FindByEmailAsync(superAdminEmail);

            if (user == null)
            {
                user = new User
                {
                    UserName = superAdminEmail,
                    Email = superAdminEmail,
                    EmailConfirmed = true
                };

                string superAdminPassword = Configuration.GetValue<string>("Admin:Password");
                await userManager.CreateAsync(user, superAdminPassword);
            }
        }
    }
}
