


using CursoWebApi6.Models.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace CursoWebApi6.Database 
{
public class UniversityDb:DbContext 
{
 public UniversityDb(DbContextOptions<UniversityDb> options)
 :base(options)
 {
    
 }
 public DbSet<User>? Users {get;set;}
 public DbSet<Course>? Courses {get;set;}
 public DbSet<Categoria>? Categorias {get;set;}
 public DbSet<Student>? Students {get;set;}

  public DbSet<Chapters>? Chapters {get;set;}
}
}
