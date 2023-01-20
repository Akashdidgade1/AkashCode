class Program
{
    static void Main()
    {
        #region
        //Cineama_customer c = new Cineama_customer();
        //c.ShowTimming();

        //Cineama_customer c1 = new Silver_customer();
        //c1.ShowTimming();
        #endregion
        customer c = new Silver_Customer();
        c.PrintTicket();

        customer c2 = new VIP_Customer();
        c2.PrintTicket();

        Console.ReadLine();
    }
}

/*class Cineama_customer
{
    public void ShowTimming()
    {
        Console.WriteLine("All show for Today");
    }
    public void SaveCustomerDetails()
    {
        Console.WriteLine("Customer data saved");
    }
}
class Food
{
    public void FoodOrder()
    {
        Console.WriteLine("Ordered Food !!");
    }
    public void SaveCustomerDetails()
    {
        Console.WriteLine("Customer data saved");
    }
}
//class Silver_customer : Cineama_customer ,Food
class Silver_customer : Cineama_customer
{

}*/

 abstract class customer
{
    public abstract void PrintTicket();
}
class Silver_Customer: customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Silver Customer Ticket"); ;
    }

}
class Gold_Customer : customer
{
    public override void PrintTicket()
    {
        Console.WriteLine("Gold Customer Ticket"); ;
    }

}
class VIP_Customer: Silver_Customer, Gold_Customer
{

}


