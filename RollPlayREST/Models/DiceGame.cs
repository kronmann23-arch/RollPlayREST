namespace RollPlayREST.Models
{
    public class DiceGame
    {
        public int Id { get; set; }
        public List<User> Players { get; set; }
        public List<Dice> NumberOfDice { get; set; }
    }
}
