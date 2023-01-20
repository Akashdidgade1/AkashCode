#region theory
/*
 Encapsulation 
    1) encapsulation is one of the four fundamental OOP concept 
    the other three are Inheritance , polymorphism, and Abstraction

    2) encapsulation in c# is a mechanism of wrapping the data (variable)
    and code acting on the data(method or properties)together as a single unit.

    3) in encapsulation the variable of class will be hiden from their classes,
    and can be access only through the method or properties of their current class.
    therefore , it is also known as DATA HIDING

    4) in a different way , encapsulation is a productive shield that
    prevent the data from being access by the code outside this shield.

    5) Encapsulation is the prodedure of encapsulating data and functionn into 
    a single unit (called class)
    
 TO ACHIVE ENCAPSULATION IN C#
    (0)- declare the variable of a class as private.
    (0)- provide oublic setter and getter methods or properties to modify and 
         view the table variable 

BENEFIT OF ENCAPSULATION 
    (0)- the field of a class can be made reaad -only  or write-only 
    (0)- A class can have control over what is stored in its fields.

WHY WE NEED ENCAPSULATION
       The need of encapsulation is to protect or prevent code (data)
       from accidental corruptiom due to the silly liitle errors the we 
       are all to prone to make

 */
#endregion End of theory

#region methods from learning never End
namespace Encapsulation
{
    class program
    {
        class person
        {
            private string name;
            private int age;

            public void setname(string name)
            {
                if (string.IsNullOrEmpty(name) == true)
                {
                    Console.WriteLine(" Name is required !!");
                }
                else
                {
                    this.name = name;
                }
            }
            public void getname()
            {
                if (string.IsNullOrEmpty(this.name) == true)
                {

                }
                else
                {
                    Console.WriteLine("Your name is :-" + this.name);
                }

            }
            public void setAge(int age)
            {
                if (age <= 0)
                {
                    Console.WriteLine("wronge age you Input !!");
                }
                else
                {
                    this.age = age;
                }

            }
            public void getAge()
            {
                if (age >= 0)
                {

                }
                else
                {
                    Console.WriteLine("Your age is :-" + this.age);
                }

            }
        }
        static void Main()
        {

            person p = new person();
            p.setname("adil");
            p.getname();
            p.setAge(-10);
            p.getAge();

            Console.ReadLine();
        }
    }
}

#endregion


class program
{
    class person
    {
        private string firstname;
        private int age;



        public void setname(string firstname)
        {
            if (string.IsNullOrEmpty(firstname) == true)
            {
                Console.WriteLine("invalid name");
            }
            else
            {
                this.firstname = firstname;
            }
        }
        public void getname()
        {
            if (string.IsNullOrEmpty(firstname) == true)
            {

            }
            else
            {
                Console.WriteLine($"your name is {this.firstname}");
            }
        }
        public void setage(int age)
        {
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("invalid age");
            }
        }
        public void getage()
        {
            if (age >= 0)
            {
                Console.WriteLine("Your age is :- " + this.age);
            }
            else
            {

            }

        }
    }
    static void Main()
    {

        person p = new person();
        Console.WriteLine("Please Enter Your Name");
        p.setname(Console.ReadLine().ToUpper());
        p.getname();
        Console.WriteLine("Please Enter Your Age");
        p.setage(int.Parse(Console.ReadLine()));
        p.getage();


        // Console.WriteLine("thanks for correct info");

        Console.ReadLine();
    }
}

