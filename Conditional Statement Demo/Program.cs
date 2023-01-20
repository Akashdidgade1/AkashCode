// Condiyional Statement
//We use to control flow of program or Applicaton
//if
// if Else
// ternary Operator(?:)
//simplifies if else statement
// If else if statement(if else cahin/ if else if ladder)
// Use This When you want to write more than 2 to three queries
// to Alternate this We Have Switch Statement
class Program
{
    static void Main() 
    {
        Console.WriteLine("Please Enter A Number");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"You Entered: {input}");
        //if (input==10)                               // if i entered 10 then it shows the ten
        //{
        //    Console.WriteLine("Ten");
        //}
        //else
        //{
        //    Console.WriteLine("Not Ten");
        //}
        //// TERNARY STATEMENT (? "true me kya chahiye":"false me kya chahiye";)

        //string result = (input==10) ? "Ten" : "Not Ten" ;
        //Console.WriteLine(result);

        //if (input == 10)
        //{                             
        //    Console.WriteLine("Ten");
        //}
        //else if (input == 20)
        //{
        //    Console.WriteLine("Twenty");
        //}
        //else if (input == 30)
        //{
        //    Console.WriteLine("Thirty");
        //}
        //else
        //{
        //    Console.WriteLine("NOt 10 20 or 30");
        //}

        //-----------------------------------------------
        // SWITCH STATEMENT
        switch (input)
        {       case 5: 
                case 10:
                Console.WriteLine("Five or Ten");
                break;

                case 20:
                Console.WriteLine("Twenty");
                break;

                 case 30:
                Console.WriteLine("Thirty");
                break;


                default :
                Console.WriteLine(" You Have To Enter  10 20 or 30");
                break;
        }

        if (input % 2 == 0)
        {
            Console.WriteLine($"{input} is a Even Number"); 
        }
        else
        {
            Console.WriteLine($"{input} is a Odd Number");
        }

        Console.ReadLine();
    }

}