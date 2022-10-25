using BartapStatistics.Data.Mappings;
using BartapStatistics.Domain;
using Microsoft.EntityFrameworkCore;

namespace BartapStatistics.Data.Contexts;

public class PersonContext : DbContext
{
    public DbSet<Person> Persons { get; internal set; }

    public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonMapping());

        base.OnModelCreating(modelBuilder);
    }
}