using System;

namespace HomeTask_Algorithm_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int inputValue = int.Parse(Console.ReadLine());

            IsNumberSimple(inputValue);
            Console.ReadKey();




            if (IsNumberSimple(inputValue))
            {
                Console.WriteLine("является простым числом");
            }
            else
                Console.WriteLine("не является простым числом");


        }

        public static bool IsNumberSimple(int inputValue)
        {
            if (inputValue == 1)
                return true;
            long number = 2;
            int d = 0;

            while (number <= inputValue)
            {
                if (inputValue % number == 0)
                {
                    d++;
                    number++;
                    return false;
                }
                return true;

            }
            return d == 0;

        }
    }

}

