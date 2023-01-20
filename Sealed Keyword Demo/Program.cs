class program
{
    static void Main()
    {
        Person p = new Person();
        p.Print();

        Employee e = new Employee();
        e.Print();

        PermenantEmployee PE= new PermenantEmployee();
        PE.PrintA();

        Console.ReadLine();
    }
}
public  class Person
{
    public virtual void Print()
    {
        Console.WriteLine("person");
    }
    public void PrintA()
    {
        Console.WriteLine("person PA");
    }

}
public class Employee : Person
{
    //public sealed override void Print()
    public  override void Print()
    {
        Console.WriteLine("Employee");
    }
}
public class PermenantEmployee : Employee
{
    public override void Print()
    {
        Console.WriteLine("PermenantEmployee");
    }
}