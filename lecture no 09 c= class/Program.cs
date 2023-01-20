#region class theory 
// class is custom complex type -- custumisable 
// class contains members like fiiled, method, constructor ,indexer, distructor, propertier
//class is a blue print
//class is a reference type
// class object : runtime entity of class 

#endregion

using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        Console.WriteLine("main start ");

        student s1 = new student();// make object of that class to acess the members
        s1.firstname = "aniket  ";
        s1.lastname = "pantawane";
        s1.fullname();

        student s2 = new student();// s1 is reference variable of type student who is pointing to object to student object
        s2.firstname = "Vishal  ";
        s2.lastname = "chimkar";
        s2.fullname();

        student s3 = new student() { firstname = "prashant  ", lastname = "Murmure" };// object initilizer method
        s3.fullname();


        student s4 = new student() { firstname = "mayuri", lastname = "deshpande", Email = "mayuri@gmail.com", mobilenum = 123456789 };
        s4.details();

        student s5 = new student() { firstname = "Shriaknt", lastname = "gadhave", Email = "shree@gmail.com", mobilenum = 9876543210 };
        s5.details();
        Console.WriteLine();

        s1.fullname();
        Console.WriteLine();

        s1.details();

        student s6 = new student()
        { firstname = "nagesh", lastname = "patil", Email = "nagoba@gmail.com", mobilenum = 9876543210 };
        s6.details();

        Console.WriteLine("main end");

        Console.ReadLine();
    }
}
class student // this is a class with complex type 
{
    public string firstname;
    public string lastname;
    public string Email;
    public long mobilenum;
    public void fullname()
    {
        Console.WriteLine($"fullname :- {firstname}{lastname}");
    }
    public void details()
    {
        Console.WriteLine($"*********** details************\n firstnamee:-{firstname}\n lastname:- {lastname}\n Email :- {Email} \n mobilenumber :- {mobilenum}\n");

        fullname();
    }


}