﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Umbraco_Onatrix_Azure.Models;

[Table("WeHelp")]
public class WeModel
{
   
    [Key]
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public DateTime Date { get; set; } = DateTime.Now;

}
