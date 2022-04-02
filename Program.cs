using System;

namespace New_Week1_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string name = "Olatunji";
            float a = 3.5f;
            double b = 3.56;
            long c = 1234567890123456789;
            char d = 'c'; // char can only hold a single character be it numeric or alphabet
            dynamic e = 29;
            Nullable<int>f = null;
            var g = e;
            var anonymous = new { number, name, a, b, c };


            float x = number; // This is an implicit data type conversion
            int y = Convert.ToInt32(a);// This is an exlicit data type conversion using the convert function
            

            Console.WriteLine(number);
            Console.WriteLine(f);
            Console.WriteLine(name);
            Console.WriteLine(a+d*e);
            Console.WriteLine(c%b);
            Console.WriteLine(anonymous.name);
            
        }
    }
}
