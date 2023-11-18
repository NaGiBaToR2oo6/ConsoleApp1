using System;

namespace ConsoleApp2
{
    class Program
    {
        static string Zadanie(int a)
        {

            string result = "";
            int unit = a % 10;
            int tens = a % 100;
            if (unit == 1 & tens != 11)
            {
                result = $"{a} рубль";
            }
            else if (unit > 1 & unit < 5 & tens != 12)

            {
                result = $"{a} рубля";
            }
            else
            {

                result = $"{a} рублей";

            }
            return result;
        }
            static void Main(string[] args)
        {

            Console.WriteLine(Zadanie(19));
            Console.WriteLine(Zadanie(13));

           

        }
    }
}
