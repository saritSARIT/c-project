using new_progect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Data.Repositoris
{
    public class TurnRepository
    {
        private readonly DataContext _context;
        

        
        public IEnumerable<Turn> Get()
        {
            return _context.Turn;

        }
        
        public ActionResult<Turn> GetById(string id)
        {
            var Turn = _context.Turn.Find(x => x.id == id);
            
        }

        
        public Turn Post([FromBody] Turn value)
        {
            _context.Turn.Add(new Turn { CastomerName = value.CastomerName, DoctorName = value.DoctorName, day = value.day, Time = value.Time });
            return value;
        }

        
        public IActionResult Put(string id, [FromBody] Turn value)
        {
            var Turn = _context.Turn.Find(x => x.id == id);
            
        }

      
        public IActionResult Delete(string id)
        {
            var index = _context.Turn.FindIndex(e => e.Id == id);
           
        }
    }
}

