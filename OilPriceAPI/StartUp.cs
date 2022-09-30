using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Data;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace OilPrice_CESIProject;

public class StartUp
{
    public StartUp(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<OilPriceContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDB")));
        
        services.AddDatabaseDeveloperPageExceptionFilter();
        services.AddMvc();
    
        services.AddControllersWithViews();
    }
    
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        
        app.UseFileServer();
        
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
}