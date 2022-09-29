
using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.EntityFrameworkCore.Internal;
using OilPrice_CESIProject;
using OilPriceAPI.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        CreateDbIfNotExists(host);

        host.Run();
    }

    private static void CreateDbIfNotExists(IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<ApiModelContext>();
                // DbInitializer.Initialize(context);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred creating the DB.");
            }
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<StartUp>();
            });
}
        // var builder = WebApplication.CreateBuilder(args);
        // builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ApiModelContext>(opt =>
        //     opt.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultDB"]));

        // // Add services to the container.
        //
        // builder.Services.AddControllers();
        // // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        // builder.Services.AddEndpointsApiExplorer();
        // builder.Services.AddSwaggerGen();
        //
        // var app = builder.Build();
        //
        // // Configure the HTTP request pipeline.
        // if (app.Environment.IsDevelopment())
        // {
        //     app.UseSwagger();
        //     app.UseSwaggerUI();
        // }
        //
        // app.UseHttpsRedirection();
        //
        // app.UseAuthorization();
        //
        // app.MapControllers();
        // var toto = new DataBaseInstance(builder.Configuration);
        // if (DataBaseInstance.CheckDatabaseExists())
        // {
        //     toto.CreateDataBase();
        // }


