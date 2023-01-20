class Program
{
    static void Main()
    {
        #region String Conversion
        //int a = 10;
        //int b = 20;
        //Console.WriteLine(a + b);



        //string num1 = a.ToString();
        //string num2 = b.ToString();
        //Console.WriteLine(num2 + num1);
        //Console.WriteLine(num1 + num2);
        #endregion
        //------------------------------------------------------------------------------------------------------//
        //Type Conversion
        short v1 = 10;
        int v2 = v1; // short to int easy  conversion
        Console.WriteLine(v2);

        short v3 = (short)v2;
        Console.WriteLine(v3);

        float v4 = v2;
        Console.WriteLine( v4);

        int v5 =(int)v4;
        Console.WriteLine(v5);

        string v6 = "1000";
        int v7 = Convert.ToInt32(v6);
        Console.WriteLine($"v7 :- {1000}");

        //v6 = "abc";
        //int v8=int.Parse(v6);
        //Console.WriteLine(v8);// format error
        v6 = "abc";
        int v8;
      bool satus = int.TryParse(v6, out v8);
        Console.WriteLine(v8);

        string v9 = "true";
        bool v10 = bool.Parse(v9);
        Console.WriteLine(v10);






        Console.ReadLine();
    }

}