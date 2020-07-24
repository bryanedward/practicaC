using System;
using classes;

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
            var instant = new BankAccount("edward",10000);
                Console.WriteLine($"nombre de la cuenta bancariae es {instant.Owner} , {instant.Number}");
                instant.MakeDispost(0, DateTime.Now, "Friend paid me back");
        }
    }
}
