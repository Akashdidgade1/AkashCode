class Program
{
    static void Main()
    {
        Person p = new Person();
        p.PrintA();
        p.PrintB();

        /*     Personv1 p1= new Personv1();
             p1.PrintB();*/

        /*PersonHelper.PrintB();*/
        string name = "Vishal";
        name.PrintB();/* here we make an public static method and in PrintB method 
                        we pass the string as parameter suffix with this keyword*/

        string Input = name.Reverse();
        Console.WriteLine($"{name} <=>{Input}");

        Console.WriteLine("Please Enter a name __");
        string result = Console.ReadLine();
        Input = result.Reverse();

        Console.WriteLine($"{result} <=> {Input}");

        Console.ReadLine();
    }
}
public sealed class Person
{
    public void PrintA()
    {
        Console.WriteLine("PrintA()");
    }

}
/*class Personv1 //: Person
{
    public void PrintB()
    {
        Console.WriteLine("PrintB()");
    }
}*/
// without inheriting the class can we add the printb method for this we need to write the extension method
//to this signature of the Extension method Public(it can use anywhere) static (nood not to make an object)
public static class PersonHelper
{
    public static void PrintB(this Person p)// make this method as extension method
    {
        Console.WriteLine("PrintB()");
    }
    public static void PrintB(this string p)// make this method as extension method for string 
    {
        Console.WriteLine("PrintB()");
    }
    public static string Reverse(this string s)
    {
        string result = string.Empty;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            result += s[i];
        }
        return result;
    }
}