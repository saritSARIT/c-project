using Microsoft.AspNetCore.Mvc;
using new_progect.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace new_progect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastomerController : ControllerBase
    {
        private readonly DataContext _context;
        public CastomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Castomer> Get()
        {
            return _context.Castomer;

        }

        [HttpGet("{id}")]
        public ActionResult<Castomer> GetById(string id)
        {
            var castomer = _context.Castomer.Find(x => x.id == id);
            if (castomer != null)
            {
                return Ok(castomer);
            }
            return NotFound();
        }

        [HttpPost]
        public Castomer Post([FromBody] Castomer value)
        {
            _context.Castomer.Add(new Castomer { id = value.id, day = value.day, Name = value.Name });
            return value;
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Castomer value)
        {
            var index = _context.Castomer.FindIndex(e => e.id == id);
            if (index >= 0)
            {
                _context.Castomer[index].day = value.day;
                _context.Castomer[index].Name= value.Name;
                return Ok(_context.Castomer[index]);
            }
            return NotFound();
        }
    }
}

