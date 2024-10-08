﻿using Microsoft.EntityFrameworkCore;
using onatrix_assignment.Models;
using Umbraco_Onatrix_Azure.Models;

namespace Umbraco_Onatrix_Azure.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<ContactFormEntry> ContactFormEntries { get; set; }
    public DbSet<WeModel> WeHelpModels { get; set; }

    public DbSet<QuestionModel> QuestionModels { get; set; }
}
