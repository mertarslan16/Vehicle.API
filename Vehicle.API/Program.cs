using Microsoft.EntityFrameworkCore;
using Vehicle.API.Helpers;
using Vehicle.API.Repository;
using Vehicle.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IService, Service>();
builder.Services.AddDbContext<VehicleContext>( options => options.UseInMemoryDatabase(databaseName:"VehicleDB"));
var app = builder.Build();
using(var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    DataJob.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
