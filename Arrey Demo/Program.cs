class Program

{// Arrey is a Collection of similar data-type, Arrey size is fixed,It cannot Grow Automatically
    //Arrey is typesafe
    static void Main(string[] args)
    {
        #region single arrey
        //int[] Akash = new int[3] { 1, 2, 3 };
        //for (int i = 0; i <= 2; i++)
        //{
        //    Console.WriteLine(Akash[i]);
        //}

        //string[] car = new string[5] { "tata", "mahindra", "bmw", "audi", "volvo" };
        //Console.WriteLine(car.Length);

        //for(int i=0; i <=4; i++)
        //{
        //    Console.WriteLine(car[i]);
        //}
        #endregion

        //string[][] candidate=new string[4][4] { "akash","ramesh","ganesh","vishal"}{"math","english","marathi","hindi" }
        int[][] caps= new int[3][];
        for (int i=0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{i} {j}");
            }
        }

        Console.ReadLine();
    }
}