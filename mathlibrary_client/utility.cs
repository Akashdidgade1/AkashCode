

public class utility
{
    public int getotp(int numofdigit)
    {
        Random rand = new Random();
        return rand.Next(1000, 9999);

    }
}

