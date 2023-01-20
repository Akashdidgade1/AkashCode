class Program
{
    static void Main()
    {
        string Firstname = "   akash     ";
        Console.WriteLine(Firstname);
        Console.WriteLine($".ToUpper = {Firstname.ToUpper()}");
        Console.WriteLine($".ToLower = {Firstname.ToLower()}");
        Console.WriteLine($"Lenght = {Firstname.Length}");
        Console.WriteLine($" Trim = {Firstname.Trim()}");
        Console.WriteLine($" Trim = {Firstname.TrimStart()} ..");
        Console.WriteLine($" Trim = {Firstname.TrimEnd()}.");

        Firstname = "\\Anil\\";
        Console.WriteLine(Firstname);


        Firstname = "akash \n dighade";
        Console.WriteLine(Firstname);

        Firstname = "akash \t dighade";
        Console.WriteLine(Firstname);

        Firstname = "akash";
         string lastname = "dighade";
        string Fullname = Firstname + lastname;
        Console.WriteLine( Fullname );

        string Fullname1 = string.Concat( lastname, " ", Firstname);
        Console.WriteLine(Fullname1);

        string Fullname2 = string.Join(" ", Firstname, lastname);
        Console.WriteLine(Fullname2);

        string Fullname3 = string.Format($" your name is {Firstname} and Lastname is {lastname}");
        Console.WriteLine(Fullname3);

        Console.ReadLine();


    }
}