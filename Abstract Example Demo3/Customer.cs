public abstract class customer
{
    public customer()
    {
        Console.WriteLine("********* Welcome To ABHIRUCHI *********");
    }
    public void ShowTimimg()
    {
        Console.WriteLine("All Shows For Today");
    }
    public abstract int TicketAmount();// we cant write body here

    public abstract void PrintTicket();

    public abstract int TicketAmount(bool isVIP);
}
public class SiverCustomer : customer
{
    public override int TicketAmount()
    {
        return 150;
    }
    public override void PrintTicket()
    {
        Console.WriteLine("Silver customer ticket Printed ");
    }
    public override int TicketAmount(bool isVIP)
    {
        if (isVIP)
        {
            return 150 - (150 / 10);
        }
        else
        {
            return 150;
        }
    }
}
public class GoldCustomer : customer
{
    public override int TicketAmount()
    {
        return 250;
    }
    public override void PrintTicket()
    {
        Console.WriteLine("Gold customer ticket Printed");
    }
    public override int TicketAmount(bool isVIP)
    {
        if (isVIP)
        {
            return 250 - (250 / 10);
        }
        else
        {
            return 250;
        }
    }
}
public abstract class  Enquiry : customer
{

}
