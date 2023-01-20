using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        string FirstName = "Akash";
        string lastName = "Dighade";

        Console.WriteLine($"{FirstName} {lastName}");

        Console.WriteLine(FirstName.ToUpper());
        Console.WriteLine(lastName.ToLower());
        //Console.WriteLine(FirstName.Reverse());
        Console.WriteLine(FirstName.Length);

        FirstName = "  Akash   ";
        Console.WriteLine(FirstName.TrimStart());
        Console.WriteLine(FirstName.TrimEnd());

        FirstName = "\"Akash\"";
        Console.WriteLine(FirstName);

        FirstName = "\\Akash\\" ;
        Console.WriteLine(FirstName);

        FirstName = "Akash \n Dighade";
        Console.WriteLine(FirstName);

        Console.ReadLine();

        string filepath = "C:\\Program Files\\Internet Explorer";
        Console.WriteLine(filepath);



    }
}