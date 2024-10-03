
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace onatrix_assignment.Models
{


    [Table("ContactFormEntries")]
    public class ContactFormEntry
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;        
        public string Phone { get; set; } = null!;
        public string Dropdown { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}