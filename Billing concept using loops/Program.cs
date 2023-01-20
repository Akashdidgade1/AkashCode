class Program
{
    static void Main()
    {
        Console.WriteLine("---------------Todays Menu-----------");
        Console.WriteLine("Wada Pav \n Samosa\n Tea \n Coffee");
        int totalbill = 0;
        string choice = "";
        int totalsamosa=0,totalwadapav=0,totaltea=0,totalcoffee=0;

        do
        {
         
        Console.WriteLine("What would you like to take?");
        string order = Console.ReadLine();
        
       
            switch (order.ToUpper())
            {
                case "wada pav":
                    Console.WriteLine("How many Wada Pav You Want ? ");
                    int tw =int.Parse(Console.ReadLine());
                    totalwadapav += tw;
                    break;

                case "SAMOSA":
                    Console.WriteLine("How many SAMOSA You Want ? ");
                    int ts = int.Parse(Console.ReadLine());
                    totalsamosa += ts;
                    break;

                case "TEA":
                    Console.WriteLine("How many TEA You Want ? ");
                    int tt = int.Parse(Console.ReadLine());
                    totaltea += tt;
                    break;

                case "COFFEE":
                    Console.WriteLine("How many COFFEE You Want ? ");
                    int tc = int.Parse(Console.ReadLine());
                    totalcoffee += tc;
                    break;

                default:
                    Console.WriteLine("You Ordered :- Nothing ");
                    break;


            }

            Console.WriteLine("Do you Want To Continue ?");
            choice = Console.ReadLine().ToUpper();


        } while (choice == "Y" || choice == "Yes");

        if (totalsamosa > 0 || totalwadapav > 0 || totaltea > 0 || totalcoffee > 0)
        {
            Console.WriteLine("------Bill Receipt------");
        }

        if (totalwadapav > 0)
        {
            Console.WriteLine($" wadapav {totalwadapav} * 20= {totalwadapav*20}");
            totalbill += totalwadapav * 20;
        }
        if (totalsamosa > 0)
        {
            Console.WriteLine($" Samosa {totalsamosa} * 15 = {totalsamosa * 15}");
            totalbill += totalsamosa * 15;
        }
        if (totaltea > 0)
        {
            Console.WriteLine($" Tea {totaltea} * 10 = {totaltea * 10}");
            totalbill += totaltea * 10;
        }
        if (totalcoffee > 0)
        {
            Console.WriteLine($" wadapav {totalcoffee} * 15 = {totalcoffee * 15}");
            totalbill += totalcoffee * 15;
        }
        if (totalbill > 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Your Total Bill Amount = {totalbill}");
        }
        else
        {
            Console.WriteLine("No Bill");
        }

        Console.WriteLine("-------****--------");
        Console.WriteLine("Thank You Visit Again !!");
        Console.ReadLine();
    }

}