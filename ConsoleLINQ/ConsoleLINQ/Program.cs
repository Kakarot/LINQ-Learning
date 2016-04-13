using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>()
            {
                new Student("Harry", "Potter"),
                new Student("Hermoine", "Granger"),
                new Student("Ron", "Weasley"),
                new Student("Harry", "DoppleGanger")
             
            };

            Console.WriteLine("Demonstrate indexing into first element of a list like an array:");
            Console.WriteLine(listOfStudents[0].ToString());
            Console.WriteLine();

            Console.WriteLine("Demonstrate LINQ without lambda, similar to SQL:");
            var listOfHarry = from student in listOfStudents
                              where student.FirstName == "Harry"
                              select student;

            foreach(var h in listOfHarry)
            {
                System.Console.WriteLine(h.ToString());
            }
            Console.WriteLine();


            Console.WriteLine("Demonstrate LINQ with Lambda:");
            
           /*
            * Notes: Lambdas are basically anonymous functions
            * The first value is the parameter you are passing into
            * the anonymous function.
            * The parameter is a single element from the list.
            * So the parameters type is of the type that the list stores.
            */
            var listOfHarryLambda = listOfStudents
                .Where(x => x.FirstName == "Harry"); //x is an instance of student

            foreach(var h in listOfHarryLambda)
            {
                System.Console.WriteLine(h); //also demonstrates implicit ToString() call
            }
            Console.WriteLine();
        }
    }
}
