using System;



namespace HelloWorld
{
    class SignIn
    {
        static void age()
        {
            int YOB = Convert.ToInt32(Console.ReadLine());    // convert string sang int        
            int age = 2022 - YOB;
            Console.WriteLine("Your age is: " + age);           // in ra chu + bien
        }
        static void userName2(string fname)         // in 1 string thay doi + 1 string co dinh
        {
            Console.WriteLine(" hello " + fname );
        }
        int compared(int a, int b)
        {

            if (a == b) return 0;
            else return 1;
            int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("opening.system ");       // in ra man hinh. write ko xuong hang, writeline xuong hang
            Console.WriteLine("Enter your userName:");
            string userName = Console.ReadLine();       // nhap tu ban phim
            userName2(userName);
            Console.WriteLine("Enter your YOB: ");
            age();                                       //goi ham age
            const string hi = "hello";                  // ghim chu hello vao bien hi va khong thay doi bien hi nua
            Console.WriteLine(true);
        }

    }
    /*
    class DoTheMath
    {
        static void Main(string[] args)
        {
            
        }
    }
    */
}