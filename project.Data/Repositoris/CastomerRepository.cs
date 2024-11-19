using new_progect;
using new_progect.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Data.Repositoris
{
    public class CastomerRepository
    {
        private readonly DataContext _context;
        public IEnumerable<Castomer> Get()
        {
            return _context.Castomer;

        }

       
        public ActionResult<Castomer> GetById(string id)
        {
            var castomer = _context.Castomer.Find(x => x.id == id);
            
        }

        
        public Castomer Post([FromBody] Castomer value)
        {
            _context.Castomer.Add(new Castomer { id = value.id, day = value.day, Name = value.Name });
            return value;
        }

       
        public IActionResult Put(string id, [FromBody] Castomer value)
        {
            var index = _context.Castomer.FindIndex(e => e.id == id);
            
    }
}
    }

