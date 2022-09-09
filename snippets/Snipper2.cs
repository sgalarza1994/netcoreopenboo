using System;
using System.Collections.Generic;
using System.Linq;

namespace  CursoWebApi6
{
    public class Student 
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;

        public int Grade {get;set;}

        public bool Certified {get;set;}
    }
   public class Snipper2
    {
        public static IEnumerable<T> GetPage<T>(IEnumerable<T> collection, int pageNumber, int resultPage)
        {

            int startIndex = (pageNumber - 1) * resultPage;

            return collection.Skip(startIndex).Take(resultPage);


        }
        //variables
        public static void LinVariables()
        {
             int[] numbes = {1,2,3,4,5,6,7,8,9,10};

             var aboveAverga = from number in numbes
                               let averga = numbes.Average()
                               let nSquare = Math.Pow(number,2)
                               where nSquare > averga
                               select number;

            foreach( int nube in aboveAverga)
            {
                Console.WriteLine("Query: {0} Square {1}",numbes,Math.Pow(nube,2));
            }
        }
    
        //Zio

        public static void ZipLinq()
        {
             int[] numbes = {1,2,3,4,5};
             string[] stringNumbes  = {"One","two","three","four","five"};

             IEnumerable<string> zipNumbers = numbes.Zip(stringNumbes,(number,word)=> number+"="+word);

        }


        //Repeat && Range 
        public static void RepeatRange()
        {
            //Generate una colection from 1 -1000
            var fist1000 = Enumerable.Range(0,1000);

            var aboveAverga = from number in fist1000 select number;

            //Repeat

            var fiveXs = Enumerable.Repeat("X",5); // XXXXX


        }

     public static void StudenLinq()
     {
        var classRomm = new List<Student>
        {
            new Student 
            {
                Id = 1,
                Name  = "Steveb",
                Grade  = 90,
                Certified = true
            },
             new Student 
            {
                Id = 2,
                Name  = "Steveb 2",
                Grade  = 90,
                Certified = true
            },
             new Student 
            {
                Id = 3,
                Name  = "Steveb 3",
                Grade  = 90,
                Certified = true
            }
        };


         
     }
    
    }
}

 