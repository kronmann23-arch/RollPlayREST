namespace RollPlayREST.Models
{
    public class Dice
    {
        public int Id { get; set; }
        public int Sides { get; set; }

        public override string ToString()
        {
            return $"Number of sides: {Sides}";
        }
    }
}
