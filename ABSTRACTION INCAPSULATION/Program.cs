/*
 Abstraction
    -	What to show outside of class or assembly
    -	Showing necessary data to the world it is abstraction
    -	What?
    -	Design phase

Encapsulation
    -	How to hide from outside class or assembly 
    -	Hiding irrelevant data from the world
    -	How?
    -	Implementation phase 

Abstraction is achieved with the help of encapsulation 
   In coding we implement abstraction, encapsulation 
    -	Using access specifiers 
    -	Using abstract class or interface
*/

class progaram
{
    static void Main()
    {
        //student s1 = new student();
        //s1.firstname = "Vishal";
        //s1.lastname = "Chimkar";
        //s1.print();

        //student s1 = new student("Vishal","chimkar");
        //s1.print();
        //----- another Object
        //student s2 = new student("", "");
        //if (s2.IsValidData())
        //{
        //    s1.print();
        //}
        //else
        //{
        //    Console.WriteLine("please check data");
        //}

        //student s3 = new student("", "");// check
        //s3.print();

        student s4 = new student("", "");//anikrt
        s4.print();


        Console.ReadLine();
    }
}
class student
{
    //public string firstname;
    //public string lastname;


    private string firstname;
    private string lastname;
    public student(string fn, string ln)
    {
        firstname= fn;
        lastname= ln;
        //Console.WriteLine($"{firstname} {lastname}");
    }

    private bool IsValidData()
    {
        return !string.IsNullOrEmpty(firstname)
              && !string.IsNullOrEmpty(lastname);
    }
    public void print()
    {
        if (IsValidData())
        {
            Console.WriteLine($"{firstname} {lastname}");
        }
        else
        {
            Console.WriteLine("Please check data");
        }

    }

}