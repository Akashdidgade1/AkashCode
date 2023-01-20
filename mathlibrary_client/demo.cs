public class x : P
{
    void printX()
    {
        P p = new P();
        printP();
    }
}
public class y
{
    public void printY()
    {
        P p = new P();
        p.printP();
    }
}