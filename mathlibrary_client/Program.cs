/*using library1;
using library2;*/

//global using l2=library2;
//using l1=library1;// Alias to library 
//using l2 = library2;
//using library2.libraryv2;

class program
{
    static void Main()
    {

        // calculator c1 = new calculator();
        // to acess this project we need to refer this
        // after add the project referrence lets check this command its work or not

        /* library1.calculator c2 = new library1.calculator();// error fet vanished just by typing  using library2; at the top
         int res = c2.Add(10, 20);
         Console.WriteLine(res);

         library2.calculator c1 = new library2.calculator();// error fet vanished just by typing  using library1; at the top
         int result =c1.sub(10,20);
         Console.WriteLine(result);*/

        /* here Also we can provide the alisas to the namespce using l1=library1
         */
         l2.calculator c2 = new l2.calculator();// error fet vanished just by typing  using library2; at the top
            int res = c2.Add(10, 20);
            Console.WriteLine(res);

            l4.calculator c1 = new l4.calculator();// error fet vanished just by typing  using library1; at the top
            int result =c1.sub(10,20);
            Console.WriteLine(result);

        utility u = new utility();
        int output=u.getotp(1);
        Console.WriteLine(output);

        l3.A a1 = new l3.A();
        a1.print();


       // A a1 = new A();
        
        Console.ReadLine();
    }
}