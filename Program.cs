using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rico!");


            List<PersonClass> thePerson = new List<PersonClass>();
            thePerson.Add(new PersonClass(){ FirstName="Samuel", LastName = "Eto'o", County = CountyEnum.AnneArrundel, Age = 39});
            thePerson.Add(new PersonClass(){ FirstName="Diego", LastName = "Milito", County = CountyEnum.Baltimore, Age = 41});
            thePerson.Add(new PersonClass(){ FirstName="Dejan", LastName = "Stankovic", County = CountyEnum.Wicomio, Age = 20});
            thePerson.Add(new PersonClass(){ FirstName="Julio", LastName = "Ceasar", County = CountyEnum.Talbot, Age = 25});

            // now the sort the name of person by ascending order in our list using LINQ expressioon and covert the result to a list

            List<PersonClass> results = thePerson.OrderBy( p => p.FirstName).ToList();

            List<string> resultX = thePerson.Where(p => p.Age <= 28)
            .OrderBy(p => p.FirstName)
            .Select(p => p.FirstName)
            .ToList();


            foreach(PersonClass x in results){

                Console.WriteLine($"{x.FirstName} is ({x.Age} years) and hes's from {x.County} County.");
            }

            foreach(string x in resultX){

                Console.WriteLine($"People Below 28 years old {x}");
            }


            














        }

        
            
        


        

































    }
}
