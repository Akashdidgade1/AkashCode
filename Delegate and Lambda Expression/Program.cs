using System.Runtime.CompilerServices;

delegate void del1();
delegate void del2(String name);
delegate string del3(string fn, string ln);
class Program
{
    static void Main()
    {
        // PrintA();
        /*  del1 d1 = new del1(PrintA);// object of delegate
          d1();*/
        /*    del1 d2 = PrintA;
            d2 += PrintB;
            d2 += PrintC;
            d2();*/
        /*   del1 D = delegate ()// anonymus method -- with no name to the method
           {
               Console.WriteLine("PrintA");
           };
           D();*/

        /*     del1 D = () =>//=> this is a goes to symbol equals to and greater than 
             {
              Console.WriteLine("Printa");
             };*/
        del1 D = () => Console.WriteLine("Printa");
        D();
        /*    del2 D1 = delegate (string name) { Console.WriteLine($"hello {name}"); };
            D1("vishal");*/

        del2 D1 = name => Console.WriteLine($"hello {name}");
        D1("vishal");

        del3 d2 = (fname, lname) => fname + " " + lname;
        string result = d2("Akshay", "shinde");
        Console.WriteLine(result);


        Console.ReadLine();
    }
    static void PrintA()
    {
        Console.WriteLine("PrintA");
    }
    /*  static void PrintB()
      {
          Console.WriteLine("PrintB");
      }
      static void PrintC()
      {
          Console.WriteLine("PrintC");
      }*/

}