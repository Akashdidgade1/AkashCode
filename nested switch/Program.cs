string Pinput = "";
string Binput = "";
string choice1 = "";
string choice = "";
do
{
    Console.WriteLine("What do you want?");
    Console.WriteLine($"Pizza,\n Biryani");
    choice = Console.ReadLine().ToUpper();
    switch (choice)
    {
        case "PIZZA":
            Console.WriteLine("You Ordered Pizza");
            Console.WriteLine("Which Pizza You Wnat: small \n Medium \n Large");
            Pinput = Console.ReadLine().ToUpper();

            switch (Pinput)
            {
                case "SMALL":
                    Console.WriteLine("You order small size Pizza");
                    break;

                case "MEDIUM":
                    Console.WriteLine("You order Medium size Pizza");
                    break;
                case "LARGE":
                    Console.WriteLine("You order Large size Pizza");
                    break;
                default:
                    Console.WriteLine("Sorry You Chooes wrong Item");
                    break;
            }
            break;

        case "BIRYANI":
            Console.WriteLine("You Ordered Biryani");
            Console.WriteLine("Which Biryani You Wnat: Mutton \n Chicken");
            Binput = Console.ReadLine().ToUpper();
            switch (Binput)
            {
                case "MUTTON":
                    Console.WriteLine("You order Mutton Biryani");
                    break;

                case "CHICKEN":
                    Console.WriteLine("You order Chicken Biryani");
                    break;
                default:
                    Console.WriteLine("Sorry You Chooes wrong Item");
                    break;
            }
            break;
        default:
            Console.WriteLine("Sorry You Chooes wrong Item");
            break;
    }
    Console.WriteLine("Anything alse");
    choice1 = Console.ReadLine().ToUpper();
    Console.WriteLine("What do you want?");
    Console.WriteLine($"Pizza,\n Biryani");
    choice = Console.ReadLine().ToUpper();
} while (choice == "Y" || choice == "YES");


Console.WriteLine("******Thank You Visit Again**********");
Console.ReadLine();