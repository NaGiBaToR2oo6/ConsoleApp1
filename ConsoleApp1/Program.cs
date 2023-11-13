using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Begin1()
        {
            Console.WriteLine("введите 2 числа для сложения:");
            string tmp = Console.ReadLine();
            int b = Int32.Parse(tmp);
            tmp = Console.ReadLine();
            int c = Convert.ToInt32(tmp);
            int sum = b + c;
            Console.WriteLine("Сумма двух чисел = " + sum);
        }


        static void Begin2()
        {
            Console.WriteLine("Введите сторону квадрата:");
            string a = Console.ReadLine(); ;
            int b = Int32.Parse(a);
            int c = b * 4;
            Console.WriteLine("Площадь квадрата = " + c);

        }

        static void Begin3()
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = Int32.Parse(a);
            int d = Int32.Parse(b);
            int S = c * d;
            int P = 2 * (c + d);
            Console.WriteLine("Площадь прямоугольника = " + S);
            Console.WriteLine("Периметр прямоугольника = " + P);
        }

        static void Begin22()
        {

            Console.WriteLine("Введите 2 переменных");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = "";
            c = b;
            b = a;
            a = c;
            Console.WriteLine(a + " " + b);
            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine($"{a} {b}");
        }

        static void Main(string[] args)
        {
            //тип_переменной имя;
            //тип_переменной имя = значение;
            //тип_переменной: string (строка), int (целый тип), double (вещественный), bool (логический тип со значениями  true/false)            

            //Begin1();
            //Begin2();
            //Begin3();
            Begin22();

            int a = 1, b=2;
            //== - сравнение
            //> < больше, меньше
            //>= <=
            // != не равно

            // && -логическое и
            // || 
            
            if( a == b)
            {
                //
            }
            else if( a> b )
            {

            }
            else
            {

            }








        }
    }
}
