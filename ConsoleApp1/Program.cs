using System;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Begin1()
        {
            Console.WriteLine("Введите 2 числа для сложения:");
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

        static void Begin5()
        {
            Console.WriteLine("Введите длину ребра куба");
            string a = Console.ReadLine();
            double b = Convert.ToDouble(a);
            double V = Math.Pow(b, 3);
            double S = Math.Pow(b, 2) * 6;
            Console.WriteLine("Обьём куба = " + V);
            Console.WriteLine("Площадь поверхности = " + S);
        }

        static void Begin7()
        {
            Console.WriteLine("Введите радиус");
            string a = Console.ReadLine();
            double R = Convert.ToDouble(a);
            double L = 2 * Math.PI * R;
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Длина окружности = " + L);
            Console.WriteLine("Площадь круга = " + S);
        }

        static void Begin9()
        {
            Console.WriteLine("Введите 2 числа");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double c = Convert.ToDouble(a);
            double d = Convert.ToDouble(b);
            double e = Math.Sqrt(c * d);
            Console.WriteLine("Среднее геометрическое = " + e);


        }

        static void Begin10()
        {
            Console.WriteLine("Введите 2 числа");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double c = Convert.ToDouble(a);
            double d = Convert.ToDouble(b);
            double summ = c + d;
            double diff = c - d;
            double prod = Math.Pow(c, 2) * Math.Pow(d, 2);
            double quo = Math.Pow(c, 2) / Math.Pow(d, 2);
            Console.WriteLine("Сумма квадратов = " + summ);
            Console.WriteLine("Разность квадратов = " + diff);
            Console.WriteLine("Произведение квадратов = " + prod);
            Console.WriteLine("Частное квадратов = " + quo);

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

        static void if2()
        {
            Console.WriteLine("Введите число");
            int a = Int32.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine(a + 1);
            }
            else
            {
                Console.WriteLine(a - 2);
            }
        }

        static void if4()
        {
            Console.WriteLine("Введите 3 числа");

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int i = 0;

            if (a > 0) ++i;
            if (b > 0) ++i;
            if (c > 0) ++i;
            Console.WriteLine("Количество положительных чисел" + i);
        }

        static void if7()
        {
            Console.WriteLine("Введите 2 числа");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Второе число меньше");
            }
            else if (b > a)
            {
                Console.WriteLine("Первое число меньше");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
        }

        static void if9()
        {
            Console.WriteLine("Введите 2 числа");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double A = 0;
            double B = 0;
            if (c > d)
            {
                A = d;
                B = c;
                Console.WriteLine("Число A= " + A);
                Console.WriteLine("Число B= " + B);
            }
            else if (c < d)
            {
                A = c;
                B = d;
                Console.WriteLine("Число A = " + A);
                Console.WriteLine("Число B = " + B);
            }
            else
            {
                Console.WriteLine("Числа равны ");
            }
        }

        static void Main(string[] args)
        {

         


        }
    }
}

