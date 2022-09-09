
using System.ComponentModel.DataAnnotations;
namespace CursoWebApi6.Models.DatabaseModel
{
public class Chapters : EntityBase
{
  
  [Required]
  public string Listado {get;set;} =string.Empty;

  public int CourseId {get;set;}
  public virtual Course Course {get;set;} = new Course();
}
}

