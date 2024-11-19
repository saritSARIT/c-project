using Microsoft.AspNetCore.Mvc;
using new_progect.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace new_progect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private readonly DataContext _context;
        public TurnController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return _context.Turn;

        }
        [HttpGet("{id}")]
        public ActionResult<Turn> GetById(string id)
        {
            var Turn = _context.Turn.Find(x => x.id == id);
            if (Turn != null)
            {
                return Ok(Turn);
            }
            return NotFound();
        }

        [HttpPost]
        public Turn Post([FromBody] Turn value)
        {
            _context.Turn.Add(new Turn { CastomerName = value.CastomerName , DoctorName = value.DoctorName , day = value.day, Time = value.Time });
            return value;
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Turn value)
        {
            var Turn = _context.Turn.Find(x => x.id == id);
            if (Turn != null)
            {
                Turn.CastomerName = value.CastomerName;
                Turn.DoctorName = value.DoctorName;
                Turn.day = value.day;
                Turn.Time = value.Time;
                return Ok(Turn);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var index = _context.Turn.FindIndex(e => e.Id == id);
            if (index >= 0)
            {
                _context.Turn.RemoveAt(index);
                return NoContent();
            }
            return NotFound();
        }
    }
}
