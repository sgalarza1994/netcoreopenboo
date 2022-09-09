using System;
using System.Collection;
namespace CursoWebApi6
{
public interface IStudentService 
{
  IEnumerable<Student> GetStudentsWithCourse();
  IEnumerable<Student> GetStudentsWitnNoCourse();
}
public class StudentService : IStudentService
{

}


}

