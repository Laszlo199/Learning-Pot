using BusinessLogicLayer.Interfaces.IServices;
using BusinessLogicLayer.Services;
using DataAccessLayer;
using DataAccessLayer.Interfaces.IRepositories;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.MinimalAPIs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Configuration.AddUserSecrets<Program>();

//Register Repos and Services
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

//Register Database
builder.Services.AddDbContext<WebShopDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlOptions => sqlOptions.MigrationsAssembly("DataAccessLayer")));


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

//Minimal APIs
app.MapOrderEndPoints();

app.Run();
