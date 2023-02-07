using AspnetRunBasics.Data;
using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Repositories;
using WebApiCrawl.Repositories.Interfaces;
using WebApiCrawler.Extensions.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(WebsiteProfile));
builder.Services.AddControllersWithViews();

#region database services

// add database dependecy
var connectionString = builder.Configuration.GetConnectionString("CrawlerConnection");
builder.Services.AddDbContext<CrawlerDbContext>(option =>
    option.UseSqlServer(connectionString));

#endregion

#region project services

// add repository dependecy
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
