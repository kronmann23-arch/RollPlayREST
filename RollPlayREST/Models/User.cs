namespace RollPlayREST.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<DiceGame> GamesParticipated;

        public override string ToString()
        {
            return $"Id: {Id} Username: {Username} Password: {Password}";
        }
    }
}
