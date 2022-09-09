using System.ComponentModel.DataAnnotations;

namespace CursoWebApi6.Models.DatabaseModel
{
    public class Categoria : EntityBase
    {
        [Required,StringLength(100)]
      public string Name {get;set;} = string.Empty;


    public ICollection<Course> Courses {get;set;} = new List<Course>();

    }

   
}