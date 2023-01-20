class program
{
    // METHOD - it is nothing but block of queries / Logical code
    // resusibility --  once we creatae the metod we can call it multiple of times 
    // Maintainability - we can changes the logic in one time after no need to changes where we already use this method 
    // 

    static void Main()
    {
        Console.WriteLine("Main start here");

        Print();               // once void get into static error went off

        num();                  // we get output num method called but not print returns value
                        // to return the values first creat object of that datatype and called using cw tab tab
        int I = num();
        Console.WriteLine(I);

        PrintA("Vishal","Chimkar");// here we need to specify the argument ie. string argument for multiple argument use comma to seperated 


        string s = S(10); // here we pass the argument which is 10 if it is string thrn we give orgumnt "Vishal"
        Console.WriteLine(s);

        Console.WriteLine("Main End here");

        Console.ReadLine();

    }
    // method does not having return type and no paramretr
    static void Print()
    {
        Console.WriteLine("Print method called");
    }

    // method has return type and having no parameter
    static int num()// here we use the int and we can use any datatype ie. string , long, float,double,string arrey
    {
        Console.WriteLine("num method called !!");
        return 10 ;
    }

    // method has no type and having  parameter
    static void PrintA(string A, string B)// here we  need to specify the type of parameter and names of the parameter
    {
        Console.WriteLine($"PrintA method called !! \n Your first name is {A} and last name is {B}");
    }

    // method has return type and having parameter
    static string S(int a)
    {
        Console.WriteLine("method s called with parameterised");
        return "akash";
    }


}