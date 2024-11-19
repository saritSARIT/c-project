using new_progect.Entitis;
using System.Reflection;

namespace new_progect
{
    public class DataContext
    {
        public List<Doctor> Doctor { get; set; }
        public List<Castomer> Castomer { get; set; }
        public List<Turn> Turn { get; set; }
        public DataContext()
        {
        List<Doctor> Doctor = new List<Doctor> 
             {
            new Doctor  { id = "022684740" , day = "06/11/24" , Name = "chaim" },
            new Doctor  { id = "327869863" , day = "07/11/24" , Name = "moshe" }
             };

        List<Castomer> Castomer = new List<Castomer>
            {
            new Castomer { id = "122684740", day = "06/11/24", Name = "kobi" },
            new Castomer { id = "827869863", day = "07/11/24", Name = "yoel" }
            };
        List<Turn> Turn = new List<Turn>
             {
            new Turn {CastomerName="kobi" ,DoctorName="chaim",day="06/11/24",Time="4:45"},
            new Turn {CastomerName="yoel" ,DoctorName="moshe",day="07/11/24",Time="4:35"}
             };
        }
    }
}
