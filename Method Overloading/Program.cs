class Program
{
    static void Main()
    {
        calculator c=new calculator();
        c.add(10,20,30);
        c.add(10, 20);
        c.add(10);
        c.add("Vishal");
        c.add("Vishal",10);
        c.add(10,"Vishal");
        c.add(10);

        Console.ReadLine(); 
    }

}
class calculator
{
    public void add(out int a)
    {
        a = 10;
        Console.WriteLine(a);
    }
    public void add(int a, int b)
    {
        Console.WriteLine(a+b);
    }
    public void add(int a, int b ,int c)
    {
        Console.WriteLine(a + b +c);
    }
  

    public void add(string a)
    {
        Console.WriteLine(a);
    }
    public void add( int a)
    {
        Console.WriteLine(a);
    }
 
    public void add(string a, int b)
    {
        Console.WriteLine(a,b);
    }
    public void add(int a, string b)
    {
        Console.WriteLine( b,a);
    }
    



}