public class P
{
    public void printP()
    {
        Console.WriteLine("P");
    }
}
public class Q:P
{
    private void printQ()
    {
        P p = new P();
        printP();
        base.printP();
    }

}