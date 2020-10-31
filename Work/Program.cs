using System;
using System.Runtime.CompilerServices;
using System.Text;


namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            

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
