using HuaMoney.Dto;
using HuaMoney.Interfaces;
using HuaMoney.Models;
using HuaMoney.Services;
using HuaMoney.ViewModel;
using Microsoft.AspNetCore.Identity;
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
            services.AddAutoMapper(cfg =>
            {
                //cfg.CreateMap<string, float>().ConvertUsing(new StringFloatConverter());
                //cfg.CreateMap<string, DateTime>().ConvertUsing(new StringDateTimeConverter());
                //cfg.CreateMap<DateTime, string>().ConvertUsing(new DateTimeStringConverter());
            },
            typeof(DtoMappingProfile),
            typeof(ViewModelMappingProfile));
            
            services.AddControllersWithViews();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            
            string db_host = Environment.GetEnvironmentVariable("DB_HOST");
            string db_user = Environment.GetEnvironmentVariable("DB_USER");
            string db_database = Environment.GetEnvironmentVariable("DB_DATABASE");
            string db_password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            // Replace with your connection string.
            var connectionString = $"server={db_host};user={db_user};password={db_password};database={db_database}";

            // Replace with your server version and type.
            // Use 'MariaDbServerVersion' for MariaDB.
            // Alternatively, use 'ServerVersion.AutoDetect(connectionString)'.
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

            // ----------------------------------------
            // ********** Identity Framework **********
            // ----------------------------------------

            // Settings for Authentication
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
            
            // Settings for Cookies
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
                
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<HuaMoneyContext>()
                .AddDefaultTokenProviders();
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

            app.UseAuthentication();
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
