string result = Get();
Console.WriteLine(result);

string Get()
{
    string result = string.Empty;
    try
    {
        result = "try";
       // return result;
        // return "try";
    }
    catch
    {
        result = "Catch";
        return result;
        // return "catch ";
    }
    finally
    {
        Console.WriteLine("finally");
       // result= "Finally";
        //return "finally";
    }
    return result;
    Console.ReadLine();
}