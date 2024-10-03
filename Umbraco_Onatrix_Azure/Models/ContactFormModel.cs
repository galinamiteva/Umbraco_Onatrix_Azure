namespace Umbraco_Onatrix_Azure.Models;

public class ContactFormModel
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string Dropdown { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public DateTime Date { get; set; }
    //public string Message { get; set; } = null!;

}
