using Microsoft.EntityFrameworkCore;
using onatrix_assignment.Models;
using Umbraco_Onatrix_Azure.Models;

namespace Umbraco_Onatrix_Azure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ContactFormEntry> ContactFormEntries { get; set; }
    public DbSet<WeModel> WeHelpModels { get; set; }
}
