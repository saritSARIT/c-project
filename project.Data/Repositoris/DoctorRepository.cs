using new_progect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Data.Repositoris
{
    public class DoctorRepository
    {
        private readonly DataContext _context;
        

        
        public IEnumerable<Doctor> Get()
        {
            return _context.Doctor;

        }

        
        public ActionResult<Doctor> GetById(string id)
        {
            var Doctor = _context.Doctor.Find(x => x.id == id);
            
        }

        
        public Doctor Post([FromBody] Doctor value)
        {
            _context.Doctor.Add(new Doctor { id = value.id, day = value.day, Name = value.Name });
            return value;
        }

        
        public IActionResult Put(string id, [FromBody] Doctor value)
        {
            var index = _context.Castomer.FindIndex(e => e.id == id);
           
        }
    }
}
   
