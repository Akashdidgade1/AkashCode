/*   we can use object type but we will get some problem with use of object type 
 *   1) No Type safe
 *   2) there are chances of boxing and unboxing operation// its not a good practice 
 *   c# intoduce Generics 
 *   generics allow us to design method 
 
 */

class program
{
    static void Main()
    {/*
        calculator c= new calculator();
        bool b1 = c.AreEqual(10,20);
        Console.WriteLine(b1);

        b1=c.AreEqual("ABC","ABC");
        Console.WriteLine(b1);

        b1 = c.AreEqual(10.5f, 10.5f);
        Console.WriteLine(b1);


        b1 = c.AreEqual(10,"vishal");
        Console.WriteLine(b1);*/
        /*
                calculator c = new calculator();
                bool b1 = c.AreEqual<int>(10, 10);
                Console.WriteLine(b1);

                b1 = c.AreEqual<string>("akash", "akash");
                Console.WriteLine(b1);

                c.Add<string>("A", "b");
                c.Add<int>(10, 20); // this is Generic type add method*/
        // lets create object of generic class
        student<string, int, string> s = new student<string, int, string>();
        s.PrintA("Hello");
        s.PrintT4(10);

        string result = s.PrintB("Vishal");
        Console.WriteLine(result);

         
        Console.ReadLine();
    }

}
class calculator
{
    /*    public bool AreEqual(int a , int b )
        {
            return a.Equals(b);
        }
        public bool AreEqual(string a, string b)
        {
            return a.Equals(b);
        }
        public bool AreEqual(object a, object b)
        {
            return a.Equals(b);
        }*/

    public bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }
    public void Add<T>(T a, T b)// here we can use dynamic keyword 
    {
        dynamic n1 = a;
        dynamic n2 = b;
        Console.WriteLine(n1 + n2);
    }
}

class student<T1, T2, T3>
{
    public void PrintA(T1 a)
    {
        Console.WriteLine(a);
    }
    public T3 PrintB(T1 b)
    {
        dynamic result = $"Welcome ,{b}";
        return result;
    }
    public void PrintT4(T2 a)
    {
        Console.WriteLine($" You age is {a}");
    } 
}