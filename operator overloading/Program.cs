class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        if (a == b)
        {
            Console.WriteLine("a and b are Equal");

        }
        else
        {
            Console.WriteLine("a and b are  Not Equal");
        }

        string s = "akash";
        string s1 = s;
        if (s == s1)
        {
            Console.WriteLine("s and s1 are Equal");

        }
        else
        {
            Console.WriteLine("s and s1 are  Not Equal");
        }



        Fullname f = new Fullname("vishal", "chimkar");
        Fullname f1 = f;
        Fullname f3 = new Fullname("vishal", "chimkar");
        Fullname f2 = new Fullname("vishal", "chimkar");
        if (f == f2)
        {
            Console.WriteLine("f and f2 are Equal");

        }
        else
        {
            Console.WriteLine("f and f2 are  Not Equal");
        }


        Console.ReadLine();

    }


}
class Fullname
{
    public string firstname;
    public string lastname;

    public Fullname(string fn, string ln)
    {
        firstname = fn; lastname = ln;
    }
    public static bool operator==(Fullname fn, Fullname ln)
    {

        return fn.firstname == ln.firstname && fn.lastname == ln.lastname;
    }
    public static bool operator !=(Fullname fn, Fullname ln)
    {

        return fn.firstname != ln.firstname && fn.lastname ! = ln.lastname;
    }



}