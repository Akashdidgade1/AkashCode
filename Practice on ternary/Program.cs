class Program
{
    static void Main()
    {
        //Console.WriteLine($"Please Enter Your Number");
        //string a = Convert.ToString(Console.ReadLine());
        //Console.WriteLine($"hii \n {a} Good Morning !! \n {a} How Are You ?");

        //string b = Convert.ToString(Console.ReadLine());
        //Console.WriteLine($" same here!!\n {a} \n can tou tell me your Age ?? ");

        //String c = Console.ReadLine();
        //Console.WriteLine($" {c} yor are Younger than me");
        //Console.ReadLine();//


        Console.WriteLine($"Please Enter First Number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Please Enter Second Number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Please Enter Third Number");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine($" {a} is greater than {b} and {c}");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"{b} is greater than {a} and {c}");
        }
        else if (c > a && c > b) ;
        {
            Console.WriteLine($"{c} is greater than {a} or {b}");
        }
        else
        {
            Console.WriteLine();
        }

        Console.ReadLine();




    }
}