namespace Akash
{
    class program
    {

        static void Main()
        {
            #region  object ,gettype or typeof
            ////object b1 = true;
            //// boolen wants in string formate
            ////Console.WriteLine(b1.ToString());
            //bool b1= false;
            //Type bt1 =b1.GetType();
            //Console.WriteLine(bt1.GetType());
            //Console.WriteLine(bt1.Name);
            //Console.WriteLine($" names gives {bt1.FullName}");
            //Console.WriteLine("  \n ");

            Type s = typeof(student);
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.Name);
            Console.WriteLine(s.FullName);

            /* to call another method from student namespace 
            */

            // s = typeof(student);
            //Console.WriteLine(s.GetType());//

            //Console.ReadLine();


            ////Type t1 = b1.GetType();
            ////Console.WriteLine(t1.FullName);
            ////Console.WriteLine(t1.GetType().FullName);
            ////Console.WriteLine("------");

            ////string p = "visahl";
            ////Type t2 = p.GetType();
            ////Console.WriteLine(t2.GetType().Name);
            ////Console.WriteLine("------");
            //int a = 10;
            //Console.WriteLine(a.ToString());










            ////student O2 = new student("vishal", "chimkar");
            ////Console.WriteLine(O2.ToString());

            ////student s2 = new student("Akash", "Dighade");
            ////Console.WriteLine(s2.ToString());

            ////student s3 = new student("akshay", "chauhan");
            ////Console.WriteLine(s3.ToString());// rajesh student
            ////Type s = s3.GetType();
            ////Console.WriteLine(s.GetType().Name);

            ////Type ts1 = typeof(student);
            ////Console.WriteLine(ts1.Name);
            ////Console.WriteLine(ts1.FullName);
            ///--






            ////student s4 = new student(10, 20);
            ////Console.WriteLine(s4.ToString());

            #endregion
            #region Equals to 
            /* .Equals to is use for the comparison purpose 

             */

            ////int i = 10;
            ////int j = i;
            ////if (i!=j)
            ////{
            ////    Console.WriteLine("Both are Equal");
            ////}
            ////else { Console.WriteLine("not same"); }

            ////if (i.Equals(j))
            ////{
            ////    Console.WriteLine("Both are Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("not same");
            ////}
            //////----------------------------------------------------------

            ////student s1 = new student ("Akash","Dighade");
            ////// student s2 = s1;
            ////student s2 = new student("Akash","Dighade");
            ////if (s1.Equals(s2))
            ////{
            ////    Console.WriteLine("Both are Equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("not same");
            ////}
            //#endregion

            //#region .getHash code 

            ///*            to get an stack no allotment to that perticular string
            //            to retrive this we are use gethash code
            //           to check the hashcode for values
            //            we need to override this methodto maintain unique hashcode for commplex type object
            //*/

            //int I = 10;
            //Console.WriteLine(I.GetHashCode());

            //string namee = "vishal";
            //Console.WriteLine(namee.GetHashCode());
            //string name = "vishal";
            //Console.WriteLine(name.GetHashCode());






            ///* int a = 10, b = 10;
            // bool b1 = a == b;*/
            // Console.WriteLine(b1);
            // //-----------
            // b1 = a.Equals(b);
            // Console.WriteLine(b1);
            // //-----------
            // b1 = a.GetHashCode() == b1.GetHashCode();
            // Console.WriteLine(b1);


            //student o = new student("akash", "dighade");
            //student o1 = new student("akash", "dighade");





            #endregion
            Console.ReadLine();
        }


    }
}
namespace Akash // student class in akash namespace  to retrive the data from this name space we need to mension that use namespace 
{
    class student
    {
        string firstname;
        string lastname;


        public student(string fn, string ln)

        {
            Console.WriteLine($"{fn} {ln}");
        }
        public void print(Type type)
        {

        }
        public override string ToString()
        {
            return firstname + " " + lastname;
        }
        //public student (int A , int B)
        //{
        //    Console.WriteLine(a,b);
        //}
        //public override string ToString()
        //{
        //    return A + " " + B;
        //}


        public override bool Equals(object? obj)
        {
            student s = (student)obj;
            return this.firstname.Equals(s.firstname) && this.lastname.Equals(s.lastname);
        }
        public override int GetHashCode()
        {
            return this.firstname.GetHashCode() ^ this.lastname.GetHashCode();
        }
    }
}