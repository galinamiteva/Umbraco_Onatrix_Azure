using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Umbraco_Onatrix_Azure.Models;
[Table("Question")]
public class QuestionModel
{

    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    [Required]
    [EmailAddress]
   
    public DateTime Date { get; set; } = DateTime.Now;
    public string Email { get; set; } = null!;
    public string Message { get; set; } = null!;
}
