using System;
using System.Runtime.CompilerServices;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
        }
        static void StaticExampleType()
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
