using AspnetRunBasics.Data;
using System.Configuration;
using WebApiCrawl.Repositories;
using WebApiCrawl.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region database services

// add database dependecy
builder.Services.AddDbContext<CrawlDbContext>(c =>
    c.(Configuration.GetSection("AspnetRunConnection")));

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
