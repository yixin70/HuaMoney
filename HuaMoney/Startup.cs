using HuaMoney.Interfaces;
using HuaMoney.Models;
using HuaMoney.Services;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney
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
            services.AddAutoMapper(typeof(Startup));
            
            
            services.AddControllersWithViews();
            services.AddScoped<IBankService, BankService>();
            

            string db_host = Environment.GetEnvironmentVariable("DB_HOST");
            string db_user = Environment.GetEnvironmentVariable("DB_USER");
            string db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
            string db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            // Replace with your connection string.
            var connectionString = $"server={db_host};user={db_user};password={db_password};database={db_database}";

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
            // For common usages, see pull request #1233.
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));

            // Replace 'YourDbContext' with the name of your own DbContext derived class.
            services.AddDbContext<HuaMoneyContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(connectionString, serverVersion)
                    // The following three options help with debugging, but should
                    // be changed or removed for production.
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );

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
