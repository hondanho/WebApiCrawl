using AspnetRunBasics.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region database services

// add database dependecy
builder.Services.AddDbContext<CrawlDbContext>(c =>
    c.UseSqlServer(Configuration.GetSection("AspnetRunConnection")));

#endregion

#region project services

// add repository dependecy
builder.Services.AddScoped<I, ProductRepository>();
services.AddScoped<ICartRepository, CartRepository>();
services.AddScoped<IOrderRepository, OrderRepository>();
services.AddScoped<IContactRepository, ContactRepository>();

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
