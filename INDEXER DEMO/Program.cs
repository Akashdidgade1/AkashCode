class program
{
    static void Main()
    {

        //string[] names = new string[] { "vishal", "mahesh", "dipak" };
        //string n = names[2];
        //Console.WriteLine(n);

        //// can i replace the name vishal as akash
        //names[0] = "Akash";// assign here vishal as akash
        //n = names[0];
        //Console.WriteLine(n);// changes Happend

         Student[] student = new Student[]
        {
            new Student(){RollNumber= 101,Name="Vishal",city="Pune"},
            new Student(){RollNumber= 102,Name="Akash",city="Nagpur"},
            new Student(){RollNumber= 103,Name="Shital",city="Pune"},
            new Student(){RollNumber= 104,Name="Mahesh",city="Mumbai"},
        };

        Institute i = new Institute(student);
        string name = i[104];// reading value
        Console.WriteLine(name);//vishal

        i[104] = "Priyanka"; //setting value
        name = i[104];
        Console.WriteLine(name);

        Student s = i["Vishal"];
        Console.WriteLine($"{s.RollNumber} : {s.Name} : {s.city}");

        Console.ReadLine();
    }
}
class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public string city { get; set; }
}
class Institute
{
    public string InstituteName { get; set; }
    private Student[] _students;
    public Institute(Student[] students)
    {
        _students = students;
    }
    public string this[int rn]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    return _students[i].Name;
                }
            }
            return $"Student not Found as {rn}";
        }
        set
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].RollNumber == rn)
                {
                    _students[i].Name = value;
                }
            }
                
        }
    }
    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    return _students[i];
                }

            }
            return null;
        }
    }
}