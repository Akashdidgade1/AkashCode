class Program
{
    #region SWAP TO DIGIT
    //static void Main()
    //{
    //    Console.WriteLine("Please Enter first number");
    //    int a = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Please Enter second number");
    //    int b = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine($"first no:-{a}\n second no:-{b}");

    //    //int c = a;
    //    //a = b;
    //    //b = c;

    //    a = a + b;
    //    b = a - b;
    //    a = a - b;

    //    Console.WriteLine($"first no is:-{a}\n second no :- {b}");

    //    Console.ReadLine();


    //}
#endregion

    static void Main()
    {
        Console.WriteLine("Please enter a Number");
        int num = Convert.ToInt32(Console.ReadLine());
        isPrime(num);
    }
    static void isPrime(int num)
    {
        bool IsPrime = false;
        for (int i = 2; i <= num/2; i++)
        {
            if (num % i == 0)
                IsPrime = true;
            break;
        }
        if (IsPrime)
        {
            Console.WriteLine($"{num} is a not prime Prime no");
        }
        else
        {
            Console.WriteLine($"{num} is" +
                $" a Prime no");

        }
    }
}