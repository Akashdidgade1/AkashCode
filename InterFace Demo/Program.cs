class program
{
    static void Main()
    {
        //ICustomer c1 =new ICustomer(); -- we cant create Object of an Interface class
        ICustomer c1 = new Silver_Customer();
        c1.Print();
        c1.SaveCustomerDetatils();

        ICustomer c2 = new Gold_Customer();
        c2.Print();
        c2.SaveCustomerDetatils();

        IFood f = new Silver_Customer();
        f.Orders();

        IFood f1 = new Gold_Customer();
        f1.Orders();

        Console.ReadLine();
    }
}
interface ICustomer
{
    public string Firstname { get; set; }
    void Print();

    void SaveCustomerDetatils();

    public void printFIrstname()
    { 
        Console.WriteLine("printFIrstname");
    }
}
interface IFood
{
 
     void Orders();

    void SaveCustomerDetatils();
}
class Silver_Customer : ICustomer,IFood
{
    // to implement the property in silver coustomer
    private  string _Firstname;
    public string Firstname
    {
        get { return _Firstname; }
        set { _Firstname = value; }
    }
    public void Print()
    {
        Console.WriteLine("Silver Customer ");
    }
    public void Orders()
    {
        Console.WriteLine("Sivler Food Order");
    }

    public void SaveCustomerDetatils()
    {
        Console.WriteLine("Silver Customer SaveCustomerDetatils() "); 
    }
}
class Gold_Customer : ICustomer ,IFood
{
    private string _Firstname;
    public string Firstname
    {
        get { return _Firstname; }
        set { _Firstname = value; }
    }
    public void Print()
    {
        Console.WriteLine("Gold Customer ");
    }
    public void Orders()
    {
        Console.WriteLine("Gold Food Order");
    }
    public void SaveCustomerDetatils()
    {
        Console.WriteLine("Gold Customer SaveCustomerDetatils() ");
    }
}
//class VIPCustomer: Silver_Customer,Gold_Customer
class VIPCustomer: Silver_Customer,Gold_Customer
{

}