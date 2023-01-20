class Program
{
    static void Main()
    {
      for(int i = 0; i <= 40; i += 2)
        {
            if (i == 20 || i==22)
            {
                //break;
                continue;
            }
            Console.WriteLine(i);
        }




        Console.ReadLine();

    }
}