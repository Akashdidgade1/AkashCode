class Program
{
    static void Main()
    {
        Console.WriteLine($" Please Enter a Digit ");
        int a = int.Parse(Console.ReadLine());
        //if (a == 10)
        //{
        //    Console.WriteLine($" You Entered : {a}= Ten");
        //}
        //else if (a == 20)
        //{
        //    Console.WriteLine($"You Enter {a} = Twenty");
        //}
        //else if  (a == 30)
        //{
        //    Console.WriteLine($"You Enter {a} = Thirty");
        //}
        //else
        //{
        //    Console.WriteLine($" " +
        //        $"Not Ten Twenty thirty");
        //}
        //string b = (a == 10) ? "ten" : "not ten";
        //Console.WriteLine(b);
        // switch (a)
        //{

        //    case 10:
        //        Console.WriteLine("ten");
        //        break;

        //        case 20:
        //        Console.WriteLine("Twenty");
        //        break;
        //        case 30:
        //        Console.WriteLine("Thirty");
        //        break;
        //        default: Console.WriteLine("Not Ten Twenty and Thirty");
        //        break;

        //        Console.ReadLine();
        //}

        if (a%2==0)
        {
            Console.WriteLine($"{a} is a even no");
        }
        else
        {
            Console.WriteLine($"{a} is a Odd num");
        }
       
    }
}