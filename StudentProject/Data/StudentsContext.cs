using Microsoft.EntityFrameworkCore;
using StudentProject.Models;
public class StudentsContext : DbContext
{
    public StudentsContext(DbContextOptions<StudentsContext> options):base(options)
    {

    }
    public DbSet<Studentone>Students{get;set;}
}