
using System.ComponentModel.DataAnnotations;
namespace CursoWebApi6.Models.DatabaseModel
{
public class Student : EntityBase
{
    [Required,StringLength(50)]
    public string Name {get;set;}  = "";

    [Required,StringLength(100)]
    public string LastName {get;set;}  = "";

    [Required]
    public DateTime Dob {get;set;}

    public ICollection<Course> Courses {get;set;} = new List<Course>();
}
}

