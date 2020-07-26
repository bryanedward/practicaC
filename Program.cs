using System;


namespace myAppC
{
    class Program
    {
        static void GetData()
        {
            Console.WriteLine("Hello World!");
        }

        static void SecondData()
        {
            Console.WriteLine("the data is" + DateTime.Now);
        }

        static void Main(string[] args)
        {
            // Person   person = new Person{ FirstName = "ed", LastName  = "br"};
            Person person = new Person("maria","fernanda", "como");
            person.listItem();
            // WriteLine($"es un gusto {person.mostrar()}");
            // WriteLine($"metodo de sobreescribe la clase persona {person}");
            // pr.Example();
        }
        
    }
}
