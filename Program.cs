using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
          // Задача №1

                        double a = 16.80;
                        double b = 12.40;
                        Console.WriteLine(Math.Sqrt(a*b));


                        // Задача №2



                        double A = 1.40;                    
                        double B = -5.50;
                        double C = 0.60;

                        double ac = A - C;
                        Console.WriteLine(ac);

                        double bc = C-B;
                        Console.WriteLine(bc);

                        Console.WriteLine(ac+bc);

                        // Задача №3

                        double x1 = -6.20;
                        double x2 = 2.10;
                        double y1 = 5.20;
                        double y2 = 9.80;
                        Console.WriteLine(Math.Sqrt((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))));

                        // Задача №4

                        string a1 = "41";

                        Console.WriteLine( Strings.StrReverse(a1));

                        // Задача №5

                        int N = 10985;

                        Console.WriteLine(N/60);

                        // Задача №6

                        int sunday = 0;
                        int monday = 1;
                        int tuesday = 2;
                        int wednesday = 3;
                        int thursday = 4;
                        int friday = 5;
                        int saturday = 6;
                        int k = 202;

                        int week = k/7;
                        int weekDef = 7 * week;
                        int weekDay = k - weekDef;


                        Console.WriteLine(weekDay);
        }
    }
}
