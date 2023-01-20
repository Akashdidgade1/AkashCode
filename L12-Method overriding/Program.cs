 class Program
{
    static void Main()
    {
        Person p1 = new Person("Akshay","Shinde"); // this callled Persomn class// same object p1 have changes thair Properties ie. Polymorphism 
        p1.fullname();

        p1 = new Empolyee("akash", "dighade");
        p1.fullname();                         // this callled Employee class

        p1 = new Permenent_Empolyee("Vikul ", "Rathod");
        p1.fullname();                            // this callled Permenent_Empolyee class

        Console.ReadLine();
    }

}
class Person
{
    public string Firstname;
    public string Lastname;

    public Person (string fn, string ln)
    {
        Firstname = fn; Lastname = ln;
    }
    public virtual  void fullname()
    {
        Console.WriteLine($"full name : {Firstname}  {Lastname} ");
    }


}
class Empolyee:Person
{
    public Empolyee(string fn,string ln):base(fn, ln) 
    {

    }
    public override void fullname()
    {
        Console.WriteLine($"full name : {Firstname}  {Lastname} :  learner");
    }


}
class Permenent_Empolyee : Empolyee
{
    public Permenent_Empolyee(string fn, string ln) : base(fn, ln)
    {

    }
    public override void fullname()
    {
        Console.WriteLine($"full name : {Firstname}  {Lastname} :  Permenent Employee");
    }


} 