using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidWebAPI.Data;
using CovidWebAPI.Model;
using Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;

namespace CovidWebAPI
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
            services.AddDbContext<CovidAuthContext>(options => options.UseSqlServer(Configuration.GetValue<string>("CovidWebAPI:ConnectionStrings:defaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                config.SignIn.RequireConfirmedEmail = false;
                config.Password.RequireDigit = false;
                config.Password.RequireLowercase = false;
                config.Password.RequireUppercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequiredLength = 8;
            })
             .AddEntityFrameworkStores<CovidAuthContext>()
             .AddDefaultTokenProviders();



            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = "yourdomain.com",
                     ValidAudience = "yourdomain.com",
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                         Configuration.GetValue<string>("CovidWebAPI:Security:SymmetricSecurityKey"))),

                     ClockSkew = TimeSpan.Zero
                 });

            services.Configure<IISServerOptions>(options =>
            {
                options.AutomaticAuthentication = false;
            });

            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //services.AddControllers().ADD;



            // Register the Swagger services
            //services.AddSwaggerDocument();
            services.AddSwaggerDocument(document =>
            {
                document.AddSecurity("JWT", Enumerable.Empty<string>(), new OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Authorization",
                    In = OpenApiSecurityApiKeyLocation.Header,
                    Description = "Type into the textbox: Bearer {your JWT token}."
                });

                document.OperationProcessors.Add(
                    new AspNetCoreOperationSecurityScopeProcessor("JWT"));
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                               IWebHostEnvironment env,
                               UserManager<ApplicationUser> userManager,
                               RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            // Register the Swagger generator and the Swagger UI middlewares
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            bool CargarUsuarios = false;

            if (CargarUsuarios)
            {
                Task<bool> existeAdmin = roleManager.RoleExistsAsync("Admin");
                do { } while (!existeAdmin.IsCompleted);
                if (!existeAdmin.Result)
                {
                    var role1 = new IdentityRole() { Name = "Admin" };
                    var result1 = roleManager.CreateAsync(role1);
                    do { } while (!result1.IsCompleted);
                }

                Task<bool> existeApp = roleManager.RoleExistsAsync("App");
                do { } while (!existeApp.IsCompleted);
                if (!existeApp.Result)
                {
                    var role2 = new IdentityRole() { Name = "App" };
                    var result2 = roleManager.CreateAsync(role2);
                    do { } while (!result2.IsCompleted);
                }

                Task<bool> existeAppUser = roleManager.RoleExistsAsync("AppUser");
                do { } while (!existeAppUser.IsCompleted);
                if (!existeAppUser.Result)
                {
                    var role3 = new IdentityRole() { Name = "AppUser" };
                    var result3 = roleManager.CreateAsync(role3);
                    do { } while (!result3.IsCompleted);
                }

                if (userManager.FindByNameAsync("Admin").Result == null)
                {
                    ApplicationUser user01 = new ApplicationUser { UserName = "Admin", Email = "email@hotmail.com" };
                    user01.Email = "ministeriodesalud@hotmail.com";
                    user01.EmailConfirmed = true;

                    var result01 = userManager.CreateAsync(user01, "qwerty");
                    do { } while (!result01.IsCompleted);
                    result01 = userManager.AddToRoleAsync(user01, "Admin");
                    do { } while (!result01.IsCompleted);
                }


            }
        }
    }
}
