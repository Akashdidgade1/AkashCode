class Program
{
    static void Main()
    {
        // Person p1= new Person();
        // Employee e1 = new Employee();
        // Person p2= new Employee();

        //Employee e1 = new Employee();// this called only non parameterised constructor 
        //Employee e1 = new Employee("Good Morning..!"); -- tihis called only the string constructor

        Employee e1 = new Employee("Good Morning..!",1000);// --   to call the string + int parameterise constructorgive second parameter use , ie 1000

        e1.Print(); 




        Console.ReadLine();
    }

}
class mammels
{
    public mammels()
    {
        Console.WriteLine("mammels() called");
    }
}
class Person //: mammels
{

    public string name = "person field caleed()";
    //public Person()

    //{
    //    Console.WriteLine("person method () callled ");
    //}
    public  Person(string message)
    {
        Console.WriteLine($"person method  parameterised (string message) callled : {message}");
    }
    public Person(int num)
    {
        Console.WriteLine($"person method  parameterised ( int num) callled :{num} ");
    }
    public virtual void Print()
    {
        Console.WriteLine(name);
    }

}
class Employee : Person
{
    public string name = "Empolyee field called";
    //public Employee()
    //{
    //    Console.WriteLine(" employee method () callled ");
    //}
    public Employee(string message) :base(message) 
    {
        Console.WriteLine(" employee parameterise method () callled ");

    }
    public Employee(string message, int num) : base(num)
    {
        Console.WriteLine("Employee  parameterised (string message, int num) callled ");
    }
    public override void Print()
    {
        //Console.WriteLine(name);// name = employee
        //Console.WriteLine(this.name);// use this. -- eployee
        Console.WriteLine(name);// use base. -- to acess persons field
    }

}