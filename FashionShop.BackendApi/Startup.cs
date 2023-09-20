using eShopSolution.Application.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ShopFahion.Utilities.Constants;
using ShopFashion.Application.Catalog.Products;
using ShopFashion.Application.Common;
using ShopFashion.Application.System.Users;
using ShopFashion.Data.EF;
using ShopFashion.Data.Entities;

namespace FashionShop.BackendApi;

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
        services.AddDbContext<EShopDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));
        services.AddControllers();
        //Declare DI
        services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<EShopDbContext>()
                .AddDefaultTokenProviders();
        services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
        services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
        services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IStorageService, FileStorageService>();
        services.AddTransient<IPublicProductService, PublicProductService>();
        services.AddTransient<IManageProductService, ManageProductService>();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger ShopFashion", Version = "v1" });
        });
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
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger ShopFashion V1");
        });
    }
}
