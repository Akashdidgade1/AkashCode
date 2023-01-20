
/* --------------- DELIGATE -------
 * - typesafe function Pointer
 * - function pointer means deligate can point to a function 
 * - type safe means deligate signature and signature should be same 
 *    USE-
 *    1) using deligate we can pass method as parameter
 *    2) using deligate we can implement callback Function
 *    3) using deligate we can imlement lossely coupled architecture
 *
 *SINGLE CAST DELEGATE
 * - deligate pointing to a single method
 * MULTICAST DELIGATE
 * -deligate pointing to multiple method

 */
delegate void sampledelegate();// this way we can declare the delegate
delegate void sampledelegate1();
class program
{
    static void Main()
    {
        /*      customer c = new customer();
           *//*   c.PrintA();*//*

              sampledelegate D1 = new sampledelegate(c.PrintA);
              D1();// calling / invoking deligate

              c.PrintB(D1);*/

        /*   sampledelegate D1 = new sampledelegate(Print1);
           sampledelegate D2 = new sampledelegate(Print2);
           sampledelegate D3 = new sampledelegate(Print3);

           sampledelegate d = D1 + D2 + D3;
           d();*/

        // wee can use compound asiignment operator
        /*   sampledelegate d = new sampledelegate(Print1);
           d += new sampledelegate(Print2);
           d += new sampledelegate(Print3);
           d();*/

        sampledelegate d = (Print1);
        d += (Print2);
        d += (Print3);
        d();

        Delegate[] delegates = d.GetInvocationList();
        for (int i = 0; i < delegates.Length; i++)
        {
            try
            {
                delegates[i].DynamicInvoke();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        sampledelegate1 d2 = (Print1);
        d2 += (Print2);
        d2 += (Print3);
        d(); 
        Console.ReadLine();
    }
    static void Print1()
    {
        Console.WriteLine("Print1 called");
    }
    static void Print2()
    {
            throw new Exception("general exeption ");
        
      
        Console.WriteLine("Print2 called");
    }
    static void Print3()
    {
        Console.WriteLine("Print3 called");
    }
}
class customer
{
    public void PrintA()
    {
        Console.WriteLine("Print a");
    }
    /*  public void PrintB(PrintA a) // it is not possible without deligate
      {
          Console.WriteLine("Print B");
      }*/

    public void PrintB(sampledelegate b) // it is not possible without deligate
    {
        b();
    }
    public void PrintC(sampledelegate1 c)
    {
        c();
    }
}