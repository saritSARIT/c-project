using Microsoft.AspNetCore.Mvc;
using new_progect.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace new_progect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DataContext _context;
        public DoctorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _context.Doctor;

        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> GetById(string id)
        {
            var Doctor = _context.Doctor.Find(x => x.id == id);
            if (Doctor != null)
            {
                return Ok(Doctor);
            }
            return NotFound();
        }

        [HttpPost]
        public Doctor Post([FromBody] Doctor value)
        {
            _context.Doctor.Add(new Doctor { id = value.id, day = value.day, Name = value.Name });
            return value;
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Doctor value)
        {
            var index = _context.Castomer.FindIndex(e => e.id == id);
            if (index >= 0)
            {
                _context.Doctor[index].day = value.day;
                _context.Doctor[index].Name = value.Name;
                return Ok(_context.Doctor[index]);
            }
            return NotFound();
        }
    }
}

