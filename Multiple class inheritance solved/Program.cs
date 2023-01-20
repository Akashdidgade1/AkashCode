class Program
{
    static void Main()
    {
        VIP_Customer vip = new VIP_Customer();
        ((ISiver_Customer)vip).PrintTicket();
        ((IGold_Customer)vip).PrintTicket(); 

        Console.ReadLine();
    }
}



abstract class customer
{
    public abstract void PrintTicket();
}
interface ISiver_Customer
{
    void S();
    void PrintTicket();
}
class Silver_Customer : customer, ISiver_Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket"); ;
    }

    void ISiver_Customer.S()
    {
        Console.WriteLine("Silver Customer Ticket"); ;
    }
}
interface IGold_Customer
{
    void G();
    void PrintTicket();
}
class Gold_Customer : customer, IGold_Customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket"); ;
    }

    void IGold_Customer.G()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
}
class VIP_Customer : ISiver_Customer , IGold_Customer
{
    Silver_Customer sc= new Silver_Customer();
    Gold_Customer  gc = new Gold_Customer();
    void ISiver_Customer.PrintTicket()
    {
        sc.PrintTicket();
    }

    void IGold_Customer.PrintTicket()
    {
        gc.PrintTicket();
    }

    void ISiver_Customer.S()
    {
         
    }

    void IGold_Customer.G()
    {
        Console.WriteLine("Gold Customer Ticket");
    }
}






