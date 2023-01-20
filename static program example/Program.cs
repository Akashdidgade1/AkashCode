class Program
{
    static void Main()
    {
        
        // pie  value is remains standerd which is 3.14f
        // so to these we can make it static
        circle.pie = 3.14f;
        circle c1 = new circle();   
        c1.Radius= 5;
        //c1.pie = 3.14f;

        c1.Area();


        circle c2 = new circle();
        c2.Radius = 10;
        //c2.pie = 3.14f;
        c2.Area();


        Console.ReadLine();
    }

}
class circle
{
    public int Radius;
    public static float pie;


    public void Area()
    {
        Console.WriteLine($"Area of Circle having radius {Radius} is : {pie*Radius*Radius} cm^2");
    }
}