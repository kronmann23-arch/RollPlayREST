using RollPlayREST.Datas;
using RollPlayREST.Models;

namespace RollPlayREST.Repositories
{
    public class DiceGameRepository:IRepository<DiceGame>
    {
       private readonly RollPlayDbContext _context;
        public DiceGameRepository(RollPlayDbContext context)
        {
            _context = context;
        }
        public DiceGame Get(int id) 
        {
            throw new NotImplementedException();
        }
        public IEnumerable<DiceGame> GetAll()
        {
            throw new NotImplementedException();
        }
        public DiceGame Add(DiceGame o)
        {
            _context.DiceGame.Add(o);
            _context.SaveChanges();
            return o;
        }
        public DiceGame Update(int id, DiceGame o)
        {
            throw new NotImplementedException();
        }
        public DiceGame Remove(int id)
        {
            throw new NotImplementedException();
        }
    
    }
}
