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

        static void HomeWork3()
        {
            ////HM1
            ////Числа фибоначчи описываются следующей последовательностью: 1, 1, 2, 3, 5, 8, 13, 21...
            ////Первые два числа - единицы.Все последующие числа вычисляются как сумма двух предыдущих.
            //// Задание: запросить у пользователя кол-во чисел Фибоначчи, которое он хотел 
            ////бы сгенерировать(вычислить), и, собственно, произвести генерацию(вычисление). 
            ////В процессе генерации записывать числа в массив.После генерации вывести вычисленные числа.
            Console.WriteLine("Введите количество чисел Фибоначчи");
            int numbers = int.Parse(Console.ReadLine());
            int[] spisok = new int[numbers];
            for (int i = 0; i < spisok.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    spisok[i] = 1;
                }
                else
                {
                    spisok[i] = spisok[i - 1] + spisok[i - 2];
                }
            }
            string result = string.Join(", ", spisok);
            Console.WriteLine($"Ваши числа Фиббоначи: {result}");

            ////HM2
            ////Запросить у пользователя не более 10 целых чисел. Пользователь может прекратить приём чисел, введя 0.
            ////После прекращения приёма целых чисел(это происходит в случае если было введено 10 чисел
            ////, либо пользователь ввёл 0, чтобы не вводить все 10) подсчитать среднее значение введённых целых чисел и вывести на консоль.
            Console.WriteLine("Введите по очереди не более 10 чисел. Для прекращения приёма нажмите 0");
            int num;
            int sum = 0;
            double average = 0;
            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    average = (double)sum / i;
                    break;
                }
                else if (i == 9)
                {
                    sum = sum + num;
                    average = (double)sum / (i + 1);
                }
                else
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine($"Среднее значение равно {average}");
            ////
            ////Факториалом числа является произведение этого числа на все предшествующие этому числу числа (кроме 0).
            ////Факториал в математике записывается через восклицательный знак. Например 5! = 5*4*3*2*1 = 120. Особые случаи: 0! = 1. 1! = 1.
            /////Задача: запросить у пользователя число, факториал которого необходимо вычислить и произвести вычисление.
            /////Затем вывести результат вычисления. Восклицательный знак запрашивать не надо, кроме того, в C# такой операции нет. 
            /////Для вычисления факториала надо производить перемножение.

            Console.WriteLine("Введите  число для вычисления факториала");
            long factorial = 1;
            int numbers3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers3; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Факториал равен {factorial}");

            //Предположим, что логин\пароль для входа в систему: johnsilver\qwerty.
            ///Запросить у пользователя логин и пароль. Дать пользователю только три попытки для ввода корректной пары логин\пароль.
            ///Если пользователь произвёл корректный ввод, вывести на консоль: "Enter the System" и прекратить запрос логина\пароля
            ///Если пользователь ошибся трижды -вывести "The number of available tries have been exceeded" и прекратить запрос пары логин\пароль.
            Console.WriteLine("Введите логин для входа");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (login == "johnsilver" && password == "qwerty")
                {
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("The number of available tries have been exceeded");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверный пароль!");
                    Console.WriteLine("Введите логин для входа");
                    login = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    password = Console.ReadLine();
                }
            }

        }
        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }
        static void FixingBags()
        {
            //f9=точка остоновки
            //f5=start debugging(до следующей точки остановки)
            Console.WriteLine("Calculate the square");
            Console.WriteLine("Enter the first side");
            double a = GetDouble();
            //f10 с обходом, f11 c заходом;(внутрь функции)


            Console.WriteLine("Enter the second side");
            double b = GetDouble();

            Console.WriteLine("Enter the third side");
            double c = GetDouble();

            double p = (a + b + c) / 2;
            double sqr = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Square:{sqr}");
            Console.ReadLine();
        }
        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    //выбросили исключения
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.WriteLine();
            //работает быстрее, чем if/else
            int wedYears = int.Parse(Console.ReadLine());
            string name = string.Empty;

            //свич на чём-то
            switch (wedYears)
            {
                case 5:
                    name = "Деревянная";
                    break;
                case 10:
                    name = "Оловянная";
                    break;
                case 15:
                    name = "Хрустальная";
                    break;
                case 20:
                    name = "Фарфоровая";
                    break;
                case 25:
                    name = "Серебряная";
                    break;
                case 30:
                    name = "Жемчужная";
                    break;
                default:
                    name = "Нет такого юбилея!";
                    break;
            }
            Console.WriteLine(name);
        }
        static void BreakContinue()
        {
            int[] numbers1 = { 0, 3, 2, 3, 4, 1, 6, 8, 7, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers1.Length; i++)
            {

                Console.WriteLine($"Number={numbers1[i]}");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers1[i] == j)
                        break;
                    Console.Write($" {letters[j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (counter == 3)
                    break;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes:({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                        break;


                }
            }

            Console.WriteLine();
            //четные числа, нечётные переходит к следующей итерации
            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                    continue;
                Console.WriteLine(n);
            }


        }
        static void DoWhile()
        {
            int age = 0;
            //не зайдём, если false
            while (age < 18)
            {
                Console.WriteLine("What's your age?");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Get in!!!");
            //нет гарантии захода, а надо!
            age = 30;
            do
            {
                Console.WriteLine("What's your age?");
                age = int.Parse(Console.ReadLine());
            }
            while (age < 18);
            //условия прроверяются после исполнения цикла
            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i] + " ");
                i++;

            }

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
