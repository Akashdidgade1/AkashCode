class Program
{
    static void Main(string[] args)
    {

        printsum(new int[] { 10, 20, 30 });

        //printsum(10, 20, 30);


        int[] b = null;
        printsum(b); 
        
        printsum(null);

        printsum(10, 20, 30, 40);//  by using params keyward we can directly put arrey values into aurgument without declaring arrey syntax


        Console.ReadLine();
        // we can use parameterised method name in main method and insert a arrey in it 

    }
   
    static void printsum(params int[] num)
    {
        if (num!= null && num.Length>0) 
        { 
            int sum = 0;    
            for(int i =0;i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"the Sum is {sum}");

        }
        else
        {
            Console.WriteLine("the arrey is empty");
        }
    }


}