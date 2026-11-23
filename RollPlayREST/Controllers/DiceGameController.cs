using Microsoft.AspNetCore.Mvc;
using RollPlayREST.Models;
using RollPlayREST.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RollPlayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceGameController : ControllerBase
    {
        private readonly DiceGameRepository _repository;
        public DiceGameController(DiceGameRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<DiceGameController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DiceGameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DiceGameController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpPost]
        public ActionResult<DiceGame> Post([FromBody] DiceGame value)
        {
            try
            {
                _repository.Add(value);
               
                return Created($"api/DiceGame/{value.Id}", value);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);

                
            }
        }

        // PUT api/<DiceGameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DiceGameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
