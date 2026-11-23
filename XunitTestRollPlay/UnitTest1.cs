using Microsoft.EntityFrameworkCore;
using RollPlayREST.Datas;
using RollPlayREST.Models;
using RollPlayREST.Repositories;

namespace XunitTestRollPlay
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add_DiceGame()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<RollPlayDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new RollPlayDbContext(options);
            var repository = new DiceGameRepository(context);

            var game = new DiceGame
            {
                Id = 1,
                Players = new List<User>(),
                NumberOfDice = new List<Dice>()
            };

            // Act
            var addedGame = repository.Add(game);

            // Assert
            Assert.NotNull(addedGame);
            Assert.Equal(game.Id, addedGame.Id);
            Assert.Single(context.DiceGame);
        }
    }
}
