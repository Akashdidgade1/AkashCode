class program
{

    static void Main()
    {
        /*int v1 = 10;
        char v2 = 's';
        double v3= 10.5;
        float v4 = 10.5f;*/

        /*   object v1 = 10; // this is not TYPESAFE
            v1 = "vishal";
           object v2 = "s";
           object v3 = 10.5;
           object v4 = 10.5f;

           object v5 = new student();// to call this object type--
           v5.print();// showing error*/

        /*object v1 = new { firstname = "anil", lastname = "rathod" };
        Console.WriteLine(v1.firstname);//error*/

        //------------------------VAR-----------------

        /*     var v1 = "vishal";
             Console.WriteLine(v1.GetType().Name);// this is a typesafe
             var v2 = 's';
             var v3 = 10.5;
             var v4 = 10.5f;
             var v6 = 10;
             Console.WriteLine(v6.GetType().Name);

             var v5 = new { firstname = "anil", lastname = "rathod" };

             Console.WriteLine(v5.lastname);// with using var it get show not error so var also a base type 
             var v7 = new student();
                 v7.print();*/

        //-------------------DYNAMIC KEYWORD-----------------
        // dynamic not showing the wrror while compile time its show whi le runtime 
        dynamic v1 = "vishal";
        Console.WriteLine(v1.GetType().Name);// this is a typesafe// var and dymic code are same //check at runtime in dynamic //
        dynamic v2 = 's';
        dynamic v3 = 10.5;
        dynamic v4 = 10.5f;
        dynamic v6 = 10;
        Console.WriteLine(v6.GetType().Name);

        dynamic v5 = new { firstname = "anil", lastname = "rathod" };

        Console.WriteLine(v5.lastname);// with using var it get show not error so var also a base type 
        dynamic v7 = new student();
        v7.print(); 



    Console.ReadLine();

    }


}
class student
{
    public void print()
    {
        Console.WriteLine("welcome to my home");


    }

}