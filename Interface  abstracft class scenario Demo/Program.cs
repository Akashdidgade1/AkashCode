class program
{
    static void Main()
    {

        Console.ReadLine();
    }
}
interface IA
{
    void PrintA();
}
interface IB : IA
{
    void PrintB();
}

abstract class A : IB
{
    public abstract void PrintA();
    public abstract void PrintB();


}
class B
{

}
class c : B, IA, IB
{
    void IA.PrintA()
    {
        throw new NotImplementedException();
    }

    void IB.PrintB()
    {
        throw new NotImplementedException();
    }
}
