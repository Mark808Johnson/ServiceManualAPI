using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using EtteplanMORE.ServiceManual.Infrastructure.Services;
using EtteplanMORE.ServiceManual.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    // Display enums as strings in swagger/postman for greater clarity
    .AddJsonOptions(options =>
    {
    options.JsonSerializerOptions.Converters.Add(new
        JsonStringEnumConverter());
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ServiceManualContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServiceManualConnection"),
    x => x.MigrationsAssembly("EtteplanMORE.ServiceManual.Infrastructure"));
}); 

builder.Services.AddScoped<IFactoryDeviceService, FactoryDeviceService>();
builder.Services.AddScoped<IMaintenanceTaskService, MaintenanceTaskService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();