using Microsoft.EntityFrameworkCore;
using RollPlayREST.Models;

namespace RollPlayREST.Datas
{
    public class RollPlayDbContext : DbContext
    {
        public DbSet<RollPlayREST.Models.DiceGame> DiceGame { get; set; } = default!;
        public RollPlayDbContext(DbContextOptions<RollPlayDbContext> options) : base(options)
        {

        }

        public DbSet<Dice> Dices { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}