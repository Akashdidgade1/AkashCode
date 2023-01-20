public delegate bool DiscountCriteria(student student);
public class Institute
{
    public string Name { get; set; }
    public const int fees = 40000;
    student[] students;

    public Institute(string Name, student[] students)
    {

        // Name=this.Name;
        this.Name = Name;
        this.students = students;

    }
    public void InstituteDetails()
    {
        Console.WriteLine($"Institute name : {Name}");
    }
    public void AllStudent()
    {
        if (students != null && students.Length > 0)
        {
            Console.WriteLine($" Total Student : {students.Length}");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"RollNumber : {students[i].Rollnumber}" +
                    $"  Name : {students[i].Name}" +
                    $"  City : {students[i].city}");
            }
        }
        else
        {
            Console.WriteLine($"No Student in {Name} Institute");
        }
    }

    public void DiscountedStudents(DiscountCriteria del)
    {
        if (students != null && students.Length > 0)
        {
            Console.WriteLine("All discounted students List !!");

            for (int i = 0; i < students.Length; i++)
            {
                // if (students[i].city == " Mumbai")
                if (del(students[i]))
                {
                    Console.WriteLine($"Rollnumber = {students[i].Rollnumber}" +
                        $"  Name : {students[i].Name}" + $"  City : {students[i].city}");
                }
            }
        }
        else
        {
            Console.WriteLine($"No Student in {Name} Institute For Discount");
        }
    }
}