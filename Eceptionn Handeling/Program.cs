class progrm
{
    static void Main()
    {
        try
        {
            division();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in outer Block !!");
        }


        Console.ReadLine();
    }
    static void division()
    {
        string Choice = string.Empty;
        do
        {
            try
            {
                int n;
                Console.WriteLine("Please Wnter A Numerator");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    string input = string.Empty;
                    int d;

                    Console.WriteLine("Please Wnter A Denominator");
                    if (int.TryParse(Console.ReadLine(), out d))
                    {
                        if (d < 100)
                        {
                            int Division = n / d;
                            Console.WriteLine($"Division is {n} / {d} = {Division}");
                        }
                        else
                        {
                            Console.WriteLine("Denomenator can not be zero !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Plases enter a valid  denomenator !!");
                    }

                }
                else
                {
                    Console.WriteLine("Plese enter a valid Numerator !!");
                }

                /*     Console.WriteLine("Please Wnter A Denominator");
                     int j = Convert.ToInt32(Console.ReadLine());

                     int div = i / j;

                     Console.WriteLine($"Division {i} / {j} = {div}");*/
            }
            catch (studentexeption ex) // here we all the detatils / stacktrace/
            {
                /* Console.WriteLine(ex.GetType().Name);
                 Console.WriteLine(ex.Message);*/
                Console.WriteLine("plese check error content in log file");
                File.AppendAllText(@"C:\Users\Akash Dighade\source\repos\BackEnd\CSharp\AKASH'S\Eceptionn Handeling\bin\Debug\net6.0\data\logs.txt'.' ", ex.Message);
                Console.WriteLine("plese check error content in log file");

            }


            Choice = Console.ReadLine().ToUpper();
        } while (Choice == "Y" || Choice == "YES");
        Console.WriteLine("Thank you visit Again !!");
    }

    // --- FANALLY ----
    /*- IThreadPoolWorkItem GIVES GAURATEE IT WILL GET IN ANY SCINARIO 


    through and through new keyword are use in catch block 
     through keyword are give originally eception info to outer catch block 
    also we can use  new kyword to throw the coustomisable execption 

    ----------------------------------------------------------------------

    if you want to make an new eception class just like student class need to
    inherate th  student class with the Exception class.
     */
    class studentexeption : Exception
    {
        public studentexeption(String message):base(message)
        {


        }

    }
}