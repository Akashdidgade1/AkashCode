partial class student :   
{
    public int Rollnumber { get; set; }

    public string name { get; set; }
    public void PrintA()
    {
        Console.WriteLine("PrintA()");
    }

}
interface IA
{
    void Print();
}
class A { };
class B { };
