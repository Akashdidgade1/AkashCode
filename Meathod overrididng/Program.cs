class Program
{
    static void Main()
    {
        //A a1 = new A(); a1.Print();//A
        //B b1 = new B(); b1.Print();//B
        //C c1 = new C(); c1.Print();//c
        A a1 = new B(); a1.Print();//B
        A a2= new C(); a2.Print();//A 
        B b1 = new C(); b1.Print();//B      
        A Aa2 = new D(); Aa2.Print();
        Console.ReadLine();
    }

}
class A
{
    public virtual void Print()
    {
        Console.WriteLine(" called A");
    }

}
class B:A
{
    //public new void Print()
    //{
    //    Console.WriteLine("B");
    //}
    public override void Print()
    {
        Console.WriteLine(" called B");
    }

}
class C:B
{
    public override void Print()
    {
        Console.WriteLine(" called C");
    }

}
class D : C
{
    public override void Print()
    {
        Console.WriteLine(" called D");
    }

}
