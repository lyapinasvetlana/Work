using System;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        static void HM1()
        {
            Console.WriteLine("Hi, tell me your name,please");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Enter some number,please");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("And another one");
            double num2 = double.Parse(Console.ReadLine());
            num1 = num1 - num2;
            num2 = num1 + num2;
            num1 = num2 - num1;
            Console.WriteLine($"We change thier places: first={num1},second={num2}");
            //Запросить у пользователя целое число. 
            //Вывести количество цифр числа. 
            //Например, в числе 156 - 3 цифры.
            Console.WriteLine("Enter some integer number");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error! Enter integer number");
            }
            //int number = int.Parse(Console.ReadLine());
            string length = $"{number}";
            int len = length.Length;
            Console.WriteLine($"The length of this nummber:{len}");

            //HOMEWORK2
            //Запросить у пользователя длины трёх сторон треугольника.
            //Длины могут быть представлены дробными значениями.
            Console.WriteLine("Enter the length of 3 sides of triangle");

            double first;
            while (!double.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Error! Enter a number");
            }
            double second;
            while (!double.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Error! Enter a number");
            }
            double third;
            while (!double.TryParse(Console.ReadLine(), out third))
            {
                Console.WriteLine("Error! Enter a number");
            }
            bool compare = first < (third + second) && third < (first + second) && second < (first + third);

            while (!compare)
            {
                Console.WriteLine("Error! Enter acceptable number for triangle");
                Console.WriteLine("Enter the length of 3 sides of triangle");
                first = double.Parse(Console.ReadLine());
                second = double.Parse(Console.ReadLine());
                third = double.Parse(Console.ReadLine());
            }
            double perimeter = (first + second + third) / 2;
            double geron = Math.Sqrt(perimeter * (perimeter - first) * (perimeter - second) * (perimeter - third));
            Console.WriteLine($"The area of the triangle is {geron}");
            ////HM3
            Console.WriteLine("Введите свой данные по шаблону: фамилия,имя,возраст,вес,рост");
            string data = Console.ReadLine();
            string[] splitData = data.Split(',');
            //ИМТ = вес(кг) / (рост(м) * рост(м));
            double height = double.Parse(splitData[4]);
            double weight = double.Parse(splitData[3]);
            double bmi = weight / (height * height);
            double age = double.Parse(splitData[2]);
            string surname = splitData[0];
            string name1 = splitData[1];
            Console.WriteLine(@$"Your profile:
Full Name: {surname}, {name1}
Age: {age}
Weight: {weight}
Height: {height}
Body Mass Index: {bmi}");


        }
        static void BasicDateAndTime()
        {
            //процессор не работает напрямую с этим типом
            //он не примитивный
            DateTime now = DateTime.Now;
            //преобразование в разные форматы методами
            Console.WriteLine(now.ToString());
            Console.WriteLine($"It's {now.Date},{now.Hour}:{now.Minute}");
            DateTime dt = new DateTime(2016, 2, 28);
            DateTime dt2020 = new DateTime(2020, 11, 1);
            Console.WriteLine(dt); //показывает полночь, если не указать
            DateTime newdt = dt.AddDays(1);//добавляет +1 день
            Console.WriteLine(newdt);

            DateTime date1 = new DateTime(1996, 6, 3, 22, 15, 0);
            DateTime date2 = new DateTime(1996, 12, 6, 13, 2, 0);
            DateTime date3 = new DateTime(1996, 10, 12, 8, 42, 0);

            // diff1 gets 185 days, 14 hours, and 47 minutes.
            TimeSpan diff1 = date2.Subtract(date1);
            Console.WriteLine(diff1);
            // date4 gets 4/9/1996 5:55:00 PM.
            DateTime date4 = date3.Subtract(diff1);
            Console.WriteLine(date4);
            // diff2 gets 55 days 4 hours and 20 minutes.
            TimeSpan diff2 = date2 - date3;

            // date5 gets 4/9/1996 5:55:00 PM.
            DateTime date5 = date1 - diff2;
            TimeSpan ts = now.Subtract(dt);
            ts = now - dt;
            Console.WriteLine(ts.TotalDays); //части дней float

        }
        static void BasicMassive()
        {
            //массив набор экземпляров определенного типа
            int[] a1 = new int[10]; //выделили память од этот массив(40 байтов)
            //значения пока пустые от 0 до 9;
            int[] a2;
            a2 = new int[5];
            int[] a3 = new int[5] { 1, 4, -3, 2, 1 };
            int[] a4 = { 7, 2, -3, 2, 1 };
            Console.WriteLine(a4[0]);
            int number = a4[4];
            Console.WriteLine(number);
            //перезаписываем значение
            a4[4] = 6;
            Console.WriteLine(a4[4]);
            Console.WriteLine(a4.Length); //длина массива
            Console.WriteLine(a4[a4.Length - 1]); //чтобы не ошибиться

            string str1 = "abcdefgh";
            char first = str1[0]; //получаем новый экземпляр, не меняем старый!!!
            char last = str1[str1.Length - 1];
            Console.WriteLine(first + "" + last);
            //str1[0] = 'z'; строки защищены от такой модификации
        }
        static void Mathematics()
        {
            //возвращает long=int*int
            long multi = Math.BigMul(5, 6);
            Console.WriteLine(multi);
            //7^2
            Console.WriteLine(Math.Pow(7, 2));
            //корень
            Console.WriteLine(Math.Sqrt(8));
            //округление
            Console.WriteLine(Math.Round(1.5)); //2, по умолчанию ToEven
            Console.WriteLine(Math.Round(2.5)); //2, к ближайшему чётному числу
            Console.WriteLine(Math.Round(1.4)); //1
            //перегрузка метода, режим округления    
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); //3
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); //2, к чётному
        }
        static void Comments()
        {
            // single-line comment
            /*
             * Multi-line comment
             * 
             */  
        }
        static void CastingAndParsing()
        {
            //1 байт=8битов
            byte b = 3; //0000 0011 =8,битов
            int i = b; // 32 бита=0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 64 бита ... 0011

            float f = i; //3.0 
            Console.WriteLine(f);
            //явное преведение
            b = (byte)i; //до 256 байт, поэтому можно представить
            Console.WriteLine(b);
            i = (int)f;
            f = 3.1f;
            i = (int)f; //не даёт приводить широкие типы к узким/с точкой в целочисленные
            Console.WriteLine(i);
            string str = "1";
            // i=(int)str; нельзя
            i = int.Parse(str);
            Console.WriteLine(i);
            str = $"{i}";

            int x = 5;
            double result = (double)x / 2; //явное преведение
            Console.WriteLine(result);

        }
        static void WorkConsole()
        {
            Console.WriteLine("Tell me your name");
            string name = Console.ReadLine();
            string sentence = $"Your name is {name}";
            Console.WriteLine("Tell me your age");
            string age1 = Console.ReadLine();
            int age = int.Parse(age1); //также к float, double
            string sentence2 = $" your age is {int.Parse(age1)}";
            Console.WriteLine(sentence + "and" + sentence2);
            Console.ReadLine();
            //чтобы отчистить консоль
            Console.Clear();
            //установить цвет
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Write("New Style "); //,без корретки
            Console.Write("New Style\n");
        }
        static void ComparingString()
        {
            string str1 = "abcde";
            string str2 = "abcde";
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);
            //тоже сравнение 
            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual);

            string s1 = "Strasse";
            string s2 = "Straße";

            areEqual = string.Equals(s1, s2, StringComparison.Ordinal);//работает быстрее
            Console.WriteLine(areEqual); //false, сравнивает байтовую репрезентацию символа

            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture);
            Console.WriteLine(areEqual); //true учитывает специфику алфавита

            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual); //true, лучше использовать(будет брать культуру из операционной системы)
            //сначала надо установить, ту культуру в рамках которой сравнивать 2 строки
        }
        static void StringFormat()
        {
            //форматирование строк
            string name = "Jonh";
            int age = 30;
            //0 and 1 = placeholder
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            //интерполирование строк
            string str2 = $"My name is {name} and I'm {age}";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            //string str2 = "My name is " + name + " and I'm " + age;
            //новая строка, но в разных операционках каретка переводится по-разному
            string str3 = "My name is \nJonh";
            //табуляция
            string str4 = "I'm \t30";
            //новая строка
            str3 = $"My name is {Environment.NewLine}Jonh";
            Console.WriteLine(str3);
            //чтобы использовать кавычки(экранирование)
            string str5 = "I'm Jonh and I'm a \"good\" programmer";
            Console.WriteLine(str5);
            //экранирование слэша
            string str6 = "C:\\tmp\\test_file.txt";
            Console.WriteLine(str6);
            str6 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str6);

            double answer = 42.00008;
            //d вывод целых чисел используем для int
            //string result = string.Format("{0:d}",answer);
            //string result2 = string.Format("{0:d4}", answer);
            //Console.WriteLine(result);//42
            //Console.WriteLine(result2);//0042

            string result = string.Format("{0:f}", answer);
            string result2 = string.Format("{0:f4}", answer);//округление в большую сторону
            Console.WriteLine(result);//42,00
            Console.WriteLine(result2);//42,0001

            Console.OutputEncoding = Encoding.UTF8;
            double money = 8.5;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C3}", money);
            Console.WriteLine(result);
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(result2);
            result = $"{money:C2}";
            Console.WriteLine(result);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(money.ToString("C2"));

        }
        static void StringBuilder()
        {
            //работает быстрее при сложении более 7 строк
            StringBuilder sb = new StringBuilder();
            //чтобы наполнить строчками вызываем экземплярные методы
            sb.Append("My "); //модифицирует строчку, не нужно возвращать
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            //добавить+каретка на новую строку
            sb.AppendLine("!");
            sb.Append("Hello");
            //превращаем в строку
            string str = sb.ToString();
            Console.WriteLine(str);
        }
        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "John");
            //Join позволяет указать разделитель, отличие от Concat
            nameConcat = string.Join(" ", "My", "name", "is", "John");
            //но Contact работает быстрее
            nameConcat = "My " + "name " + "is " + "Jonh";
            //индекс, с которого вставлена подстрока
            string newName = nameConcat.Insert(0, "By the way, ");
            //методы инстанции не изменяют её саму(значение неизменяемо)
            //поэтому надо содать или новое, или презаписать
            Console.WriteLine(nameConcat);
            Console.WriteLine(newName);
            //удаляет подстроку с (опреденного индекса, количество символов удаляем)
            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat);
            //заменяем один символ на другой
            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced);

            string data = "12;28;90;60";
            //получим массив типа string, указываем разделитель
            string[] splitData = data.Split(';');
            //обращаемся по индексу
            string first = splitData[0];
            Console.WriteLine(first); //будет записано 12
            //теперь возвращает массив char
            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]);
            Console.WriteLine(nameConcat[0]); //тот же вывод/можно напрямую
            //преобразование регистров
            string lower = nameConcat.ToLower();
            Console.WriteLine(lower); //все маленькие

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper); //все большие
            //обрезаем символы слева и справа ПРОБЕЛЫ
            string jonh = " My name is John ";
            Console.WriteLine(jonh.Trim());
        }
        static void NullEmptyWhiteSpaced()
        {
            string str = string.Empty; // same as ""

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = "b";
            string nullStr = null; //отсутствие экземпляра(в памяти)=ничего
            //nullStr.Contains('a'); //будет ошибка
            //как определить состояние
            Console.WriteLine("IsNullorEmpty");
            //null можно передавть внутри метода
            bool IsNullorEmpty = string.IsNullOrEmpty(nullStr);
            Console.WriteLine(IsNullorEmpty); //true

            IsNullorEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(IsNullorEmpty); //false

            IsNullorEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(IsNullorEmpty); //false

            IsNullorEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(IsNullorEmpty); //true

            Console.WriteLine("IsNullorWhiteSpaced"); //+whitespaced
            bool IsNullorWhiteSpaced = string.IsNullOrWhiteSpace(nullStr);
            Console.WriteLine(IsNullorWhiteSpaced); //true

            IsNullorWhiteSpaced = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(IsNullorWhiteSpaced); //true

            IsNullorWhiteSpaced = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(IsNullorWhiteSpaced); //false

            IsNullorWhiteSpaced = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(IsNullorWhiteSpaced); //true
        }
        static void QuaryingBasicStringAPI()
        {
            //API как работаем с типом, его методы, аргументы методов
            //какие свойства, что возвращают== программный интерфейс
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains('E');
            Console.WriteLine(containsA);
            Console.WriteLine(containsE);

            bool endWithAbra = name.EndsWith("abra"); //2перегрузки с char and string 
            Console.WriteLine(endWithAbra);
            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra);
            //найти индекс символа в строке
            int indexOfA = name.IndexOf('a', 1); //перегрузка поиск с первого элемента
            Console.WriteLine(indexOfA);
            int lastIndexOfR = name.LastIndexOf('r');
            Console.WriteLine(lastIndexOfR);

            Console.WriteLine(name.Length);
            //взятие подстроки (начиная с индекса до последнего)
            string substr = name.Substring(5);
            string substr2 = name.Substring(0, 3);
            Console.WriteLine(substr);
            Console.WriteLine(substr2);

        }
        static void StaticInstanceMembers()
        {
            string name = "abra"; //мы вызваем методы к тип
            bool containsA = name.Contains('a'); //методы вызываем на экземпляре != статические
            //определены внутри типа string/ name=экземпляр
            Console.WriteLine(containsA); //метод WL на типе Console статический
            string abc = string.Concat("a", "b", "c"); //статический
            //этот метод вызывается на самом типе string, мы не вызываем его на экземпляре
            //а возвращает он экземпляр типа string/ который записан в abc
            Console.WriteLine(abc);
            Console.WriteLine(int.MinValue);//также  статический вызывается на типе

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr);
            Console.WriteLine(x);

        }
        static void BoolOperator()
        {
            int x = 1;
            int y = 2;
            bool areequal = x == y;
            Console.WriteLine(areequal);
            bool result = x > y;
            Console.WriteLine(result);
            result = x >= y;
            Console.WriteLine(result);
            result = x < y;
            Console.WriteLine(result);
            result = x <= y;
            Console.WriteLine(result);
            result = x != y;
            Console.WriteLine(result);

        }
        static void Operation()
        {
            int x = 1;
            int y = 2;
            int z = x + y;
            int k = x - y;
            int a = z + k - y;
            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(a);
            int b = z * 2;
            int c = k / 2;
            Console.WriteLine(b);
            Console.WriteLine(c);
            a = 4 % 2;
            b = 5 % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = 3;
            a = a * a;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
        }
        static void IncrementDecrement() 
        {
            int x = 1;
            x = 1 + x;
            Console.WriteLine(x);
            x++;
            ++x;
            Console.WriteLine(x);
            x--;
            --x;
            x = x - 1;
            Console.WriteLine("increments");
            Console.WriteLine($"Last x state is {x}");
            int j = x++; //сначала инициализирует j, потом x
            Console.WriteLine(x);
            Console.WriteLine(j);
            j = ++x; //сначала x, потом j
            Console.WriteLine(x);
            Console.WriteLine(j);

            x += 2; //x=x+2
            x -= 2; //x=x-2
        }
        static void Overflow()
        {  //checked
            { 
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            x = x + 1;
            Console.WriteLine(x);
            x = x - 1;
            Console.WriteLine(x);
            }
            //обнаружиить переполнение
        }

        static void Areas_scope()
        {
            var number1 = 1;
            Console.WriteLine(number1);
            {
                var number2 = 2;
                Console.WriteLine(number1);
                Console.WriteLine(number2);
                {
                    var number3 = 3;
                    Console.WriteLine(number1);
                    Console.WriteLine(number2);
                    Console.WriteLine(number3);
                }
            }

        }
        static void Literals()
        {
            int x = 0b11;
            int y = 0b1001;
            int m = 0b1000_0001;
            Console.WriteLine(x + " " + m);
            x = 0x1F; //16-ричная
            y = 0xFF0D;
            m = 0x1FAB_30EF;
            Console.WriteLine(4.5e2); //4.5*10^2
            Console.WriteLine(3.1E-1); //3.1*10^-1
            Console.WriteLine('\x78'); //символьные литералы 16-ричная
            Console.WriteLine('\u0078'); //юникод
        }
        static void Variables()
        {
            int a = 2;
            string b = "VAsiliy";
            Console.WriteLine(b);
            Console.WriteLine(a);
        }

     }
}
