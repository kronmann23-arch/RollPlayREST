using Microsoft.EntityFrameworkCore;
using RollPlayREST.Datas;
using RollPlayREST.Models;
using RollPlayREST.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException();

// DbContext
builder.Services.AddDbContext<RollPlayDbContext>(
    options => options.UseSqlServer(connectionString)
);

builder.Services.AddScoped(typeof(IRepository<Dice>), typeof(DiceRepository));
builder.Services.AddScoped(typeof(IRepository<DiceGame>), typeof(DiceGameRepository));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
    //app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
 