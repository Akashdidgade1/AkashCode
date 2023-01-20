class Program
{
    static void Main()
    {
        string n1 = "Mahesh";
        string n2 = "sartaj";
        string n3 = "shyam";
        string n4 = "shakil";
        // string [] names;//arrey initilizer
        //string[] names = new string[5];// number de
        string[] names = new string[] {"mahesh","sartaj","shyam","shakil"};// string character, not int, nor bool
        Console.WriteLine(names[3]);
        Console.WriteLine(names[2]);
        Console.WriteLine($"{names[1]}\n" );
        //Console.WriteLine(names[4]);// index out of range Eception

        for(int i = 0; i <= names.Length-1; i++)
        {
            Console.WriteLine($"{names[i]}");
        }                                              // single diamentional arrey

        int[] number = new int[] { 1,2,3,4,55, 77, 98 ,102 ,5,6,7,8,9};
        for (int i = 0; i < number.Length; i++)
        {
           if (number[i] % 2 == 0)
            {
                Console.WriteLine($"{number[i]} : even");
            }
            else
            {
                Console.WriteLine($"{number[i]} : odd");
            }
         }
       




        Console.ReadLine();
    }

}
