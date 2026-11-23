using Microsoft.EntityFrameworkCore;
using RollPlayREST.Datas;
using RollPlayREST.Models;
using RollPlayREST.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException();

// DbContext
builder.Services.AddDbContext<RollPlayDbContext>(
    options => options.UseSqlServer(connectionString)
);

builder.Services.AddScoped(typeof(IRepository<Dice>), typeof(DiceRepository));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
