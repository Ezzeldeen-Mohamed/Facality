using System.ComponentModel.DataAnnotations;

namespace Facality.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int Studentphone { get; set; }
        public string StudentName { get; set; } 
        public string gender { get; set;}
        public DateTime Birthday { get; set;} 

        public List<faccality> faccalities { get; set; }
    }
}
