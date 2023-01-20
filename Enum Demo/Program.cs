using System.Reflection;

class program
{
    static void Main()
    {
        Student s = new Student();
        s.Firstname = "Akash";// set / write / intialise/ argument
        s.Lastname = "Dighade";
        s.Gender = 1;

        Console.WriteLine($"Firstname :-  {s.Firstname} \n Lastname :- {s.Lastname} \n" +
            $" Gender : {GetGender(s.Gender)}");

        //--------------**------------**-------
        // lets Make another object S1
        Student s1 = new Student();
        s1.Firstname = "Shital";
        s1.Lastname = "Pantawane";
        s1.Gender = (int)Gender.female;

        Console.WriteLine($"Firstname :-  {s1.Firstname} \n Lastname :- {s1.Lastname} \n" +
            $" Gender : {GetGender(s1.Gender)}");

        //Subject.
        Type t = Enum.GetUnderlyingType(typeof(Subject)); // underline type of enum is int we can modify it or customise it 
        Console.WriteLine(t);

        string[] names = Enum.GetNames(typeof(Subject));
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"{names[i]}  ");
        }

        int[] values = (int[]) Enum.GetValues(typeof(Subject));
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }


        Console.ReadLine();
    }
    static string GetGender(int Gender)
    {
        switch (Gender)
        {
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Unknown";
        }
    }
}

// Documentation 
//  Male-1 ; Female-2 ; 
class Student
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    //  public string Gender { get; set; }  

    public int Gender { get; set; }

}
enum Gender
{
    male, female, unknown
}
enum Subject : byte  // We can modify the type of Enum //- Integral type we can chnge into these like byte , short not Double , long
{
    Marathi, HIndi, English, Mathematics, Chemistry, Physics
}