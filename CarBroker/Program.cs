using FluentValidation.AspNetCore;
using FluentValidation;
using CarBroker.BL.Interfaces;
using CarBroker.BL.Services;
using CarBroker.DL.Interfaces;
using CarBroker.DL.Repositories;
using CarBroker.HealthChecks;


namespace CarBroker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<ICarRepository, CarRepository>();
            builder.Services.AddSingleton<IManufacturerRepository, ManufacturerRepository>();

            builder.Services.AddSingleton<ICarService, CarService>();
            builder.Services.AddSingleton<IManufacturerService, ManufacturerService>();
            builder.Services.AddSingleton<IShopService, ShopService>();

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.MapHealthChecks("/healthz");

            app.Run();
        }
    }
}