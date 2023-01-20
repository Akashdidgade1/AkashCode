class program
{
    static void Main()
    {
        //student s = new student();
        #region
        //// setting values / assingnig values/ write
        //// s.Rollnumber = 1;

        //s.setrollno(10);


        //s.setname("mahesh");// if name is nukk then while display it should be display no name  
        //s.setpassamrk(30);

        //Console.WriteLine($"Roll number is {s.getrollno()} name {s.getname()} and passmark {s.getpassmark()}");

        // setting values / assingnig values/ write
        // s.Rollnumber = 1;

        #endregion

        student s = new student();
        s.rollnumber=10;
        s.city = "pune";


        s.name=("mahesh");// if name is nukk then while display it should be display no name  
       // s.passmark;

        Console.WriteLine($"Roll number is {s.rollnumber} name {s.name} and passmark {s.passmark}"
            + $"city is {s.city}");


        Console.ReadLine();
    }
}
class student
{
    #region m1
    //private int _rollnumber;
    //private string _name;
    //private int _passmark = 40;

    //public int getrollno()
    //{
    //    return _rollnumber;
    //}
    //public void setrollno(int rn)
    //{
    //    if (rn > 0)
    //    {
    //        this._rollnumber = rn;

    //    }
    //    else
    //    {
    //        Console.WriteLine("rollno can not be negative");
    //    }

    //}
    //public void setname(string name)
    //{
    //    _name = name;
    //}
    //public string getname()
    //{
    //    return string.IsNullOrEmpty(_name) ? "No Name" : _name;
    //}
    //public int getpassmark()
    //{
    //    {
    //        return _passmark;
    //    }
    //}
    #endregion

    private int _rollnumber;
    private string _name;
    private int _passmark = 40;

    public int rollnumber
    {
        get
        {
            return _rollnumber;
        }
        set
        {
            if (value > 0)
            {
                _rollnumber = value;
            }
            else
            {
                Console.WriteLine("the no is not be negative");
            }


        }


    }

    public string name
    {
        get
        {
            return string.IsNullOrEmpty(_name) ? "no name" : _name;
        }
        set
        {
            _name= value;
        }

    }

    public int passmark
    {
        get
        {
            return _passmark;
        }
    }

    private string _city;
    public string  city
    {
        get { return _city; }
        set { _city= value; }
    }

    // if i want to write auto implemeneted properties to modify in future
    public string email { get; set; }
}