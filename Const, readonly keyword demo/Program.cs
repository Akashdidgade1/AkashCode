/*---------THOERY--------------
 * --CONST KEYWORD
1) if we want to keep one value throughout the application that time we can use CONST keyword;
2) it is mandatory ti initialize value for const field at the time of declaration ;
   public const string coursr_name="Dot_Net";
3) we canot change values of const field anywhere in program ;
4) by default const field act like static field means we need to acees const field using class name;

--READONLY KEYWORD
1) keep same value throughout the session use readonly keyword
2) it is not mandatory to assign value for readonly field at the time of declaration ;
3) we can  change the value of readonly only one in constructor, no where else;
4) by defaul tit is not static 
 
 */


using static System.Console;
class program
{
    static void Main()
    {
       // WriteLine(student.course_name);
        student s1 = new student();
        s1.firstname = "Vaibhav";
        s1.lastname = "Nayak";
       // s1.course_name = "Dot_Net";

        s1.print();
//------------------------------------
       //student.course_name = "Java";  
        student s2 = new student();
        s2.firstname = "Aniket";
        s2.lastname = "Pantawane";
       // s2.course_name = "Dot_Net";

        s2.print();

        ReadLine();
    }
}
// to understand the cons and readonly we create class student
class student
{
    public string firstname;
    public string lastname;
    // public static string course_name = "Dot_Net";
    // public const string course_name = "Dot_Net";
    // public readonly string course_name = "Dot_Net";
    public readonly string course_name;

    public student()// we can change name of redonly only by using constructor
    {
        course_name = "java";
    }

    public void print()
    {
        WriteLine($"{course_name} : {firstname} {lastname}");
    }

}