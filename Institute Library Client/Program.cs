delegate void delegate1();
delegate void delegate2(string s1, string s2);
delegate int delegate3(string s);
class program
{
    static void Main()
    {
        /*  delegate1 d1 = delegate ()
          {
              Console.WriteLine("Delegate1");
          };
          d1();
          delegate2 d2 = delegate (string s1, string s2)
          {
              Console.WriteLine($"{s1} {s2}");
          };
          d2("anil","Rathod");

          delegate3 d3 = delegate (string s)
          {
              Console.WriteLine("Delegate3");

          };
          int result = d3("Om");
          Console.WriteLine(result);*/
        /*
                student[] students = new student[]
                {
                         new student(){Rollnumber =1 , Name= "Vishal", city = "Pune"},
                         new student(){Rollnumber =2 , Name= "Mahesh", city = "Mumbai"},
                         new student(){Rollnumber =3 , Name= "Shital", city = "Pune"},
                         new student(){Rollnumber =4 , Name= "Snehal", city = "Mumbai"},
                         new student(){Rollnumber =5 , Name= "Akash", city = "Satara"},
                };
                Institute seed = new Institute("Seed Infotech", students);
                seed.InstituteDetails();
                seed.AllStudent();
                // seed.DiscountedStudents();
                // DiscountCriteria del = seedDicsountcriteria;
                DiscountCriteria del = delegate (student s)
                {
                    return s.Name.StartsWith("s");
                };
                seed.DiscountedStudents(del);*/
        Console.WriteLine("-----------------------------------------");
        student[] students1 = new student[]
        {
                 new student(){Rollnumber =1 , Name= "Rakesh", city = "Pune"},
                 new student(){Rollnumber =2 , Name= "Vikas", city = "Mumbai"},
                 new student(){Rollnumber =3 , Name= "Yogesh", city = "Pune"},
        };
        Institute I1 = new Institute("Cdac", students1);
        I1.InstituteDetails();
        I1.AllStudent();
        //I1.DiscountedStudents();
        //DiscountCriteria del1 = cdacDicsountcriteria;
        /*  DiscountCriteria del1 = delegate (student s)
          {
              return s.city.Equals("Pune");
          };
          I1.DiscountedStudents(del1);*/
        DiscountCriteria del1 = s => s.city.Equals("Pune");
        I1.DiscountedStudents(del1);

        //DiscountCriteria del1 = s => s.city.Equals("Pune");
        I1.DiscountedStudents(s => s.city.Equals("Pune")); 

        /*I1.DiscountedStudents(s => s.Name.StartsWith("Y"));*/


        Console.ReadLine();
    }
    static bool seedDicsountcriteria(student s)
    {
        return s.Name.StartsWith("S");
    }
    static bool cdacDicsountcriteria(student s)
    {
        return s.city.Equals("Pune");
    }

}