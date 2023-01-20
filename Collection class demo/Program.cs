using System.Collections;
using System.Globalization;

class Program
{
    static void Main()
    {

        ArrayList num = new ArrayList(3);
        num.Add(10);
        num.Add(20);
        num.Add(30);

        foreach (int i in num)
        {
            Console.Write($"{i}  ");
        }
        Console.WriteLine();
        num.Add((40));// we add this in arrey at the last
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();// new line
        ICollection temp = new ArrayList() { 50, 60 };
        num.AddRange(temp);
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }//10,20,30,40,50,60,
        Console.WriteLine();

        /*num.Add(15);
        foreach (int i in num)
        {
            Console.Write($"{i}  ");
        }*/ //10,20,30,40,50,60, 15 this 15 at the last we want atbetween 10 and 20
        /* to add 15 in  between 10,20 we have num.Insert(0,5)
         */
        Console.WriteLine();

        num.Insert(0, 15);// with num.Insert(,) add 15 at 0 th Index
        foreach (int i in num)
        {
            Console.Write($"{i}  ");
        } //10,20,30,40,50,60, 15 
        /* if i want add multiple numbers in a so make areey of that add 
         * 
         * 
         */
        Console.WriteLine();

        /* ICollection temp1 = new ArrayList { 15, 20, 30 };
         num.InsertRange(5, temp1);
         foreach (int i in num)
         {
             Console.Write($"{i} ");
         }
         Console.WriteLine();*/

        Console.WriteLine($" no Of Items in arrey : {num.Count}");
        Console.WriteLine();
        num.Remove(15);
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }//10 20 30 40 50 60
        Console.WriteLine();
        // to remove the index no we can use arreylist name.RemoveAt()<--pass the index no 
        num.RemoveAt(1);// it remove the index no.ie.20
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }//10 30 40 50 60 
        Console.WriteLine();
        num.RemoveRange(1, 2);// it remove the Range ie(1,3) start from 1 index after 2 term.
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }//10 30 40 50 60 
        Console.WriteLine();
        ICollection arr = new ArrayList() { 10, 20, 30 };
        num.AddRange(arr);
        foreach (int i in num)
        {
            Console.Write($"{i} ");
        }//10 30 40 50 60 ,10, 20, 30 
        Console.WriteLine();
        bool b = num.Contains(10);
        Console.WriteLine($"Does this no Present in the current arrey :- {b}");
        int a = 20;
        b = num.Contains(a);
        Console.WriteLine($"Does this {a} Present in the current arrey :- {b}");
        Console.WriteLine("-----------------------");
/*        // to remove the all the items in the arrey use clear command */
        num.Clear();
        Console.WriteLine($" no of items in arrey {num.Count}");//0
        Console.WriteLine("-----------------------");


        Console.ReadLine();

    }
}