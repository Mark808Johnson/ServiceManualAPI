using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using EtteplanMORE.ServiceManual.ApplicationCore.Services;
using EtteplanMORE.ServiceManual.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ServiceManualContext>(options =>
{
//options.UseSqlServer(builder.Configuration
//.GetConnectionString("ServiceManualConnection"),
//x => x.MigrationsAssembly("EtteplanMORE.ServiceManual.Infrastructure"));

    options.UseSqlServer("server=localhost;database=ServiceManual;trusted_connection=true", 
        x => x.MigrationsAssembly("EtteplanMORE.ServiceManual.Infrastructure"));

}); 

builder.Services.AddScoped<IFactoryDeviceService, FactoryDeviceService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();