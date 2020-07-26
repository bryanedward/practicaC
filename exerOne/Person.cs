

using System;
using System.Collections.Generic;
using System.Linq;
using classes;
using static System.Console;

public class Person
{
    public string FirstName{ 
        get; 
        private set;}
    public string LastName{ 
        get; 
        private set; }
    public string MiddleName
    {
        get;
    } = "";
    public Person(string FirstName, string LastName, string MiddleName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.MiddleName = MiddleName;
    }
    public override string ToString() => $" mi nombre es {FirstName}  {LastName} y {MiddleName}";    
    public string mostrar() =>  ToString().ToUpper();

    private void ejercicioOne()
    {
        var account = new BankAccount("edward", 10000);
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);
    }
    private void Example()
    {
        var phrase = "the quick brown fox jumps over the lazy dog";
        var wordLength = from word in phrase.Split(' ')
                         select word.Length;
        var average = wordLength.Average();
        WriteLine($"{wordLength.Average():F2}");
    }

    private void ejercicioTwo()
    {
        string s = null;
        bool hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
        Console.WriteLine(hasMore);
    }
    private void ejercicioThree()
    {
        try
        {
            int sbr = 3;
            Console.WriteLine(nameof(sbr));
        }
        catch (Exception e) when (LogException(e))
        {
            WriteLine("www");
        }
    }

    private static bool LogException(Exception e)
    {
        Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
        Console.WriteLine($"\tMessage: {e.Message}");
        return false;
    }

    public void listItem()
    {
        var messages = new Dictionary<int, string>
        {
            [404] = "Page not Found",
            [302] = "Page moved, but left a forwarding address.",
            [500] = "The web server can't come out to play today."
        };

        Console.WriteLine(messages[302]);
    }    
}