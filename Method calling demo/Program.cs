class Program
{
    static void Main()
    {
        string a1 = ("HOW ARE YOU ??");
        Console.WriteLine(a1);

        //Bool(false);
        Bool(true);

        string name = "main";
        Console.WriteLine(name);//--main

        AKASH(ref name); 
        Console.WriteLine(name);//-- with using ref keyword use the called method in calling 
                                // - otherwise it shows the main insted of 'AKASH'.


        int a = 10; int b = 20; int add, sub, mul, div;
        Operation( a,  b, out add,out  sub,out  mul,out div);
        {
            Console.WriteLine($"Additon is ={add}\n Subtraction is = {sub}\n multiplication is = {mul}\n Division is ={div}");   
        }
;
        Console.ReadLine();
    }

    static string a(string name)
    {
        return "akash  " + name;
    }
    static void Bool(bool b)
    {
        if (!b)
        {
            return;
        }
        Console.WriteLine("Execute code from bool method");
    }
    static void AKASH(ref string name)// use ref key before the datatype and use in calling use (ref table name )=(ref akash)
    {
        name = "AKASH";
    }
    static void Operation(int a, int b, out int add, out int sub, out int mul, out int div)
    {
        add = a + b;
        sub = a - b;
        mul = a * b;
        div = a / b;
    }


}