class Program
{
    static void Main()
    {

        #region Logical operator
        int p = 10;
        int q = p;
        bool b = (p == q);
        Console.WriteLine(b);

        b = (p != q);
        Console.WriteLine($" p != q :- {b}");

        bool b1 = (p == q);
        Console.WriteLine($" p == q :- {b}");

        q = 20;
        b1=(p <= q);
        Console.WriteLine($" p is Less than q :- {b1}");

        b1 = (p >= q);
        Console.WriteLine($" p is Greater than q :- {b1}");


        p = 10;
        q = 20;
        int r = 30;
        int s = 50;
        b1 = (p<q && q >r && r<s);
        Console.WriteLine(b1);

        b1 = (p > q || q > r||r<s);
        Console.WriteLine(b1);
        #endregion
        int a = 10; int b2 = 2;
        Console.WriteLine($"{a} + {b2} = {a+b2}");   
        Console.WriteLine($"{a} - {b2} = {a-b2}");
        Console.WriteLine($"{a} * {b2} = {a * b2}");
        Console.WriteLine($"{a} / {b2} = {a / b2}");
        Console.WriteLine($"{a} % {b2} = {a % b2}");

        // compond Opeartor 
        // Here we can combine the mathmatical operator like
        a = 10;
        Console.WriteLine(a-=5);
        a = 10;
        Console.WriteLine(a /= 5);
        a = 10;
        Console.WriteLine(a *= 5);

        a = 20;
    
            Console.WriteLine($" ++a {++a} ");

        a = 20;
        Console.WriteLine(--a);

        a = 20;
        Console.WriteLine($" a++ {a++} ");

        a = 20;
        Console.WriteLine(a--);

        bool b3 = true;
        Console.WriteLine(b3);

        b3 = true;
        Console.WriteLine(!b3);





        Console.ReadLine();
    }

}