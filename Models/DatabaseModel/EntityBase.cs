
using System;
using System.ComponentModel.DataAnnotations;
namespace CursoWebApi6.Models.DatabaseModel
{
public class EntityBase 
{
  [Key]
    public int Id {get;set;}

    public string CreatedBy {get;set;} = string.Empty;
    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public string UpdateBy {get;set;} = string.Empty;
    public DateTime UpdateAt {get;set;} = DateTime.Now;

     public string DeleteBy {get;set;} = string.Empty;
    public DateTime DeleteAt {get;set;} = DateTime.Now;

    public bool IsDeleted {get;set;} = false;
}
}

