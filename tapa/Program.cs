class Program
{
    static void Main()
    {



        //    string Firstname = "Akash";
        //    string Lastname = "Dighade";

        //    Console.WriteLine($" first name in lower = {Firstname.ToLower()}");
        //    string Fullname = string.Format($"full name = {Firstname}   {Lastname}");
        //    Console.WriteLine(Fullname);

        //    Console.WriteLine($"Fullname = {Lastname} , {Firstname}");
        //    Console.ReadLine();
        //}
        Console.WriteLine($"Please Enter a Number");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($" You Entered {input}");
        //if (input == 10)
        //{
        //    Console.WriteLine("Ten");
        //}
        //else
        //{
        //    Console.WriteLine("Not Ten");
        //}
        //Console.ReadLine();

        //string result = (input ==10)?"ten": "not ten";    // ternary operator syntax (condtion ? if : else)
        //Console.WriteLine(result);
        #region if else ladder
        //if (input == 10)
        //{
        //    Console.WriteLine("ten");
        //}
        //else if (input == 20)
        //{
        //    Console.WriteLine(" Twenty");
        //}
        //else if (input == 30)
        //{
        //    Console.WriteLine("Thirty");
        //}
        //else
        //{
        //    Console.WriteLine("Not 10 20 or 30");
        //}
        #endregion

        switch (input)
        {
            case 10:
                Console.WriteLine("ten");
                break;
            case 20:
                Console.WriteLine("twenty");
                break;
            case 30:
                Console.WriteLine("Thirty"); ;
                break;
            default:
                Console.WriteLine("not 10 20 or 30");
                break;
        }

        

   
    }
}