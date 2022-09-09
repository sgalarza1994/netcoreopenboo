using System.ComponentModel.DataAnnotations;

namespace CursoWebApi6.Models.DatabaseModel
{
    public class Course : EntityBase
    {
        [Required,StringLength(50)]
        public string Name {get;set;} = string.Empty;
        [Required,StringLength(280)]
        public string ShortDescription {get;set;} =string.Empty;
        
                [Required,StringLength(500)]
        public string Description {get;set;} =string.Empty;
        [Required]
        public Level Level {get;set;} = Level.Basic;

        [Required]
        public ICollection<Categoria> Categorias {get;set;}=new List<Categoria>();
        public ICollection<Course> Courses {get;set;}=new List<Course>();
    
        public Chapters Index {get;set;} = new Chapters();
    }

    public enum Level 
    {
        Basic,
        Medium,
        Hard,
        Advanced,
        Expert
    }
}