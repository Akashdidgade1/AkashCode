/*----------PARTIAL CLASS DEMO---------
 * using partial keyward we can split into the 
 */
class program
{
    static void Main()
    {
        student s1 = new student();
        s1.Rollnumber= 1;
        s1.name = "akash";
        s1.Age= 28;
        Console.WriteLine($"RollNumber is {s1.Rollnumber} name : {s1.name}  &  age : {s1.Age}");
        s1.InsertstudenttoDB();
        s1.Print();
        s1.PrintA();

        Console.ReadLine();
    }
}
