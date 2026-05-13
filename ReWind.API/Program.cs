using Microsoft.EntityFrameworkCore;
using ReWind.Application.Queries.Parks.GetAllParks;
using ReWind.Core.IRepositories;
using ReWind.Infrastructure.Persistance;
using ReWind.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ReWindDBContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IParksRepository, ParksRepository>();
builder.Services.AddScoped<IWastesRepository, WastesRepository>();


builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<GetAllParksQuery>());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();