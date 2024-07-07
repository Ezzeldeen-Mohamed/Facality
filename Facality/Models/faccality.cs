using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facality.Models
{
    public class faccality
    {
        [Key]
        public int FacalityId { get; set; }
        public string FacalityName { get; set; }
        public int Facalityphone {  get; set; }
        public string Facalityaddress { get; set; }

        public int sudentid { get; set; }
        [ForeignKey("sudentid")]
        public Student student { get; set; }
    }
}
