class program
{
    static void Main()
    {
        customer c1= new SiverCustomer();
        c1.ShowTimimg();
        int result = c1.TicketAmount();
        Console.WriteLine($"silver Ticket Amount : {result}");
        c1.PrintTicket();

        customer c2 = new GoldCustomer();
        c2.ShowTimimg();
        result = c2.TicketAmount();
        Console.WriteLine($"Gold Ticket Amount : {result}");
        //customer c2 = new GoldCustomer();
        c2.PrintTicket();

        customer c3= new GoldCustomer();
        result= c3.TicketAmount(true);
        Console.WriteLine($"GoldCustomer Ticket Amont : {result}");  


        Console.ReadLine();
    }

}
