using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        printA(10);//10
        printA();//137-- put default
        printA(450);// parameter value id :- 450
        printb(10, 20);
        printb(); // here b is optional 
        printb(60);
        printb(10, 50);
        printc(b: 20);


    }
    static void printA(int num = 137)
    {
        Console.WriteLine($"parameter value id :- {num}");
    }
    static void printb(int a = 50, int b = 60, int c = 50)
    {
        Console.WriteLine($"{a} + {b}+ {c} = {a + b + c}");

    }
    static void printc([Optional] int a, int b)
    {
        Console.WriteLine($"{a} + {b}= {a + b}");

    }


}