using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void NestedFor()
        {
            //посчитать все пары чисел, которые в сумме=0
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    if (atI + atJ == 0) Console.WriteLine($"Pair ({atI};{atJ}). Indexes:({i};{j})");
                }
            }

        }
        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //нет итератора= сразу значения, от нулевого индекса до последнего
            foreach (int val in numbers)
            {
                Console.WriteLine(val + " ");
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            //8 6 4 2
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

        }
        static void Hm1()
        {
            Console.WriteLine("Enter the first number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double second = double.Parse(Console.ReadLine());
            double maximum = first >= second ? first : second;
            Console.WriteLine($"Максимальное число:{maximum}");
        }
        static void ElseIf()
        {
            Console.WriteLine("Введите свой данные по шаблону: фамилия,имя,возраст,вес,рост");
            string data = Console.ReadLine();
            string[] splitData = data.Split(',');
            //ИМТ = вес(кг) / (рост(м) * рост(м));
            double height = double.Parse(splitData[4]);
            double weight = double.Parse(splitData[3]);
            double bmi = weight / (height * height);
            bool isTooLow = bmi <= 18.5;
            bool isNormal = bmi > 18.5 && bmi < 25;
            bool isAboveNormal = bmi >= 25 && bmi <= 30;
            bool isTooFat = bmi > 30;

            int age = 20;
            string description = age > 18 ? "You can drink!" : "Too young for that";
            Console.WriteLine(description);

            bool isFat = isAboveNormal || isTooFat;

            if (isFat)
            {
                Console.WriteLine("Lose some weight!!!");
            }
            else
            {
                Console.WriteLine("You are pretty fit");
            }
            if (!isFat)
            {
                Console.WriteLine("You are pretty fit");
            }
            else
            {
                Console.WriteLine("Lose some weight!!!");
            }

            if (isTooLow)
            {
                Console.WriteLine("Not enough weight");
            }
            else if (isNormal)
            {
                Console.WriteLine("Pretty good!");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Careful!");
            }
            else
            {
                Console.WriteLine("Danger!!!");
            }
            //combine
            if (isFat || isTooFat)
            {
                Console.WriteLine("Let's train");
            }
        }
    }
}
