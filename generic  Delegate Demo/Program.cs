
/*
   
 Lambda expression
-	It simplifies anonymous method 

To create delegate instance
-	Using a separate method
-	Using anonymous method
-	Using lambda expression

Generic delegates
Action delegate
-	action delegate is a generic delegate which has T as input parameter and void as return type
-	there are 16 overloads

Predicate delegate
-	predicate delegate is a generic delegate which has T as input parameter and bool as return type  

Func delegate
-	func delegate is a generic delegate which has T as input parameter and T as return type
-	it has 17 overloads 
*/
class Program
{
    static void Main()
    {

        Action<string> d1 = s => Console.WriteLine($" Hello {s}");
        d1("vishal");

        Action<string, string> d2 = (fn, ln) => Console.WriteLine($" Hello {fn}  {ln}");
        d2("Vishal", "Chimkar");
        // for additon Program with action delegate
        Action<int, int> d3 = (a, b) => Console.WriteLine($"Multiplication of {a} X {b}  = {a * b} ");
        d3(10, 50);//500 

        Predicate<string> d4 = s => s.Equals("Vishal");// having only one parameter
        bool b = d4("Vishal");
        Console.WriteLine(b);
        // check the int parameter in Predicate
        Predicate<int> d5 = s => s.Equals(10);
        b = d5(10);
        Console.WriteLine(b);
        // having return type
        Func<string, string> d6 = s => s;
        string result = d6("Vishal");
        Console.WriteLine(result);
        //whenever you saw the func generic  delegates that time last t type is an out parameter
        //Here int at the last so in is output parameter
        Func<int, int, int> d7 = (a, b) => a + b;// Go es to with lambda expression
        int output = d7(10, 20);
        Console.WriteLine(output);

        Console.ReadLine();
    }
}