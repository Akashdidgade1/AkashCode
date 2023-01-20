class Program

{
 static void Main()
    {
        int v1 = 10;
        int v2 = v1;
        bool b1 = v1 == v2;
        Console.WriteLine($"v1==v2{b1}");

        b1 = v1 != v2;
        Console.WriteLine($"v1 != v2 {b1} "); //!= is not equal to

        // > less than eaual to
        v2 = 10;
        b1 = v2 <=v1 ;
        Console.WriteLine($"v1 <v2 {b1} ");

        
        b1 = v2 >= v1;
        Console.WriteLine($"v1 >=v2 {b1} ");

        // combine two condition at same time
        v1 = 10;
        v2 = 20;
        int v3 = 30;
        b1 = v1 < v2 && v2 < v3; // && and operator ,combine more
        Console.WriteLine($"{v1}<{v2}&&{v2}<{v3}={b1}");

        b1 = v1 < v2 && v2 > v3; 
        Console.WriteLine($" {v1} < {v2} && {v2} > {v3} = {b1} ");

        b1 = v1 < v2 || v2 > v3;// || this is an or operator (pipe operator)
        Console.WriteLine($" {v1} < {v2} || {v2} > {v3} = {b1} ");

        b1 = v1 < v2 || v2 > v3|| v1==v3;// in or conditon if one condtn satified and other are false still it gives o\p true
        Console.WriteLine($" {v1} < {v2}||{v2} > {v3} || {v1}=={v3}   = {b1} ");

        b1 = v1 < v2 ||( v2 < v3 && v1 == v3);
        Console.WriteLine($" {v1} < {v2}||({v2} > {v3} && {v1}=={v3})   = {b1} ");

        // We Have Some Mathematical Expression like(+ - * / %)

        int a = 10, b = 2;
        Console.WriteLine($"{a} + {b} = {a+b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");// dividend function in division
        Console.WriteLine($"{a} % {b} = {a % b}");// reminder function 

        // Compound Assignment Operator(+=,*=)

        Console.WriteLine(a);
        //a = a + 5;
        a += 5;
        Console.WriteLine(a);//15
        a *= 5;
        Console.WriteLine(a);//15*5=75

        // Some Unary Operator(++,--) These are increment /Decrement Operator

        a++;// a= a+1             // Increment
        Console.WriteLine(a);

        a--;// a= a-1              // Decremment
        Console.WriteLine(a);
        Console.WriteLine($"-a is{-a}");

        b1 = true;
        Console.WriteLine(b1);
        Console.WriteLine(!b1);//!= true o/p false


        Console.ReadLine();

    }









}