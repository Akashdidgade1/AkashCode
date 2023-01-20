using System.Diagnostics.Metrics;
using static student;

class Program
{
    #region
    //    Static keyword

    //-	Single copy

    //-	We can make static member if that member is not object specific
    //-	Static members we cannot access using object
    //-We access static members using type/ class name

    //Static class

    //-We cannot create object of static class
    //-We can write only static members inside static class
    #endregion
    static void Main()
    {
        student.coursename = "dot Net";
        student s1 = new student() { firstname = "aniket ", lastname = "pantawane", /*coursename="Dot Net"*/ };
        s1.Details();
        Console.WriteLine();


        student s2 = new student();
        s2.firstname = "vikul ";
        s2.lastname = "rathod";
        // s2.coursename = "Dot Net" ;
        s2.Details();
        Console.WriteLine();


        student.print();

        country.name = "india";
        Console.WriteLine(country.name);

        Console.ReadLine();

    }


}
class student
{

    public string firstname;
    public string lastname;
    public static string coursename;

    public void Details()
    {

        Console.WriteLine($"********* Details ********\n  " +
            $"firstname :- {firstname}\n  " +
            $"lastname :- {lastname} \n  " +
            $"course name :- {coursename}"
           );
    }
    public static void @print()
    {
        Console.WriteLine("hii akash !!");
    }
    public static class country
    {
        public static string name;

    }


}
