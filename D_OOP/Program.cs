using System;
using System.Collections.Generic;

namespace D_OOP
{
    class Program
    //контейнер метода, с которого начинается программа
    {
        static void Swap(int a, int bb)
        {
            Console.WriteLine($"Original a={a}, b={bb}");
            int tmp = a;
            a = bb;
            bb = tmp;
            Console.WriteLine($"Swaped a={a}, b={bb}");
        }
        static void SwapReal(ref int a, ref int bb)
        {
            Console.WriteLine($"Original a={a}, b={bb}");
            int tmp = a;
            a = bb;
            bb = tmp;
            Console.WriteLine($"Swaped a={a}, b={bb}");
        }
        static void Do(object obj)
        {
            //не знаем какой тип
            //небезопасно работать
            //лучше List
            //от него наследуются все типы
            //проверка типа, с помощью is
            //например тип PointRef
            bool isPointRef = obj is PointRef;
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.X);
            }
            else
            {
                //do something
            }
            //проверка c помощью as
            PointRef pr1 = obj as PointRef;
            //если не obj, то будет содержать null
            //здесь сразу кастуют
            if(pr1 != null)
            {
                Console.WriteLine(pr1.X);
            }


        }
        static void Main(string[] args)
        {

            int x5 = 1;
            object obj = x5; //boxing
            //происходит процесс упаковки 
            //obj это reference type;
            //значение x переносится в кучу
            //а в стеке у нас obj, который ссылается на кучу

            //когда obj кастуем обратно,
            //unboxing
            int y = (int)obj;
            //теперь y=обычный value type
            //Дженерики =int в List<int>, можно указать тип для списка
            double pi=3.14;
            object obj1 = pi;
            int number = (int)(double)obj1; ///получим исключение, если нет(double)
            Console.WriteLine(obj1);
            //Проблемы, что никто не знает, какой тип лежит в object

            




            ///ЭКЗМЕПЛЯРЫ ССЫЛОЧНЫХ ТИПОВ
            ///ССЫЛКИ НИКУДА НЕ УКАЗЫВАЮТ
            ///НУЛЕВАЯ ССЫЛКА
            ///
            //БУДЕТ ОШИБКА
            //PointRef c5=null;
            //Console.WriteLine(c5.X); //NullReferenceException
                                     //ссылка не указывает на экземпляр 
                                     //мы не выделили память, куда указывает ссылка


            //ПОД структура сразу выделяется память

            //PointVal pv=null;
            //Console.WriteLine(pv.X);

            //valuetype/ который присваивает null=?
            PointVal? pv=null;
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv.Value.X);
                Console.WriteLine(pv2.X);
            }
            else
            {
                ///
            }

            PointVal pv3 = pv.GetValueOrDefault();
            //если null, то состояние по умолчанию
            //X,Y=0




            ////новое задание 
            List<int> list = new List<int>();
            //вызвали экземпляр листа 
            // по сути мы скопировали ссылку
            //и когда будет изменение в numbers
            //они же будут и в list
            AddNumbers(list);
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            //Swap
            int a = 1;
            int bb = 7;
            Swap(a, bb);
            Console.WriteLine($"Swaped a={a}, b={bb}");
            //а они не поменялись местами
            //потому что передали value type 
            //в качестве аргументов

            //как передать value type(int)
            //по ссылке
            //Как же их реально поменять местами
            //в методе надо использовать слова ref
            SwapReal(ref a, ref bb);
            Console.WriteLine($"Swaped a={a}, b={bb}");
            //функция принимает аргуметы по ссылке

            ///НО ЧАЩЕ ВМЕСТО СТРУКТУР ИСПОЛЬЗУЕМ КЛАССФ
            ///ПОЭТОМУ НЕОБХОДИМОСТИ В ref НЕТ!

            Console.ReadLine();


            //ЗЛАЯ СТРУКТУРА
            //В структуре создаётся поле типа PointRef(ссылочного)
            EvilSt st1 = new EvilSt();
            st1.Pointref = new PointRef();//{ X=1, Y=2} можно так
            st1.Pointref.X = 1;
            st1.Pointref.Y = 2;
            EvilSt st2 = st1;
            Console.WriteLine($"st1.Pointref.X={st1.Pointref.X}, st1.Pointref.Y={st1.Pointref.Y}");
            Console.WriteLine($"st2.Pointref.X={st2.Pointref.X}, st1.Pointref.Y={st2.Pointref.Y}");

            st2.Pointref.X = 40;
            st2.Pointref.Y = 45;

            Console.WriteLine($"st1.Pointref.X={st1.Pointref.X}, st1.Pointref.Y={st1.Pointref.Y}");
            Console.WriteLine($"st2.Pointref.X={st2.Pointref.X}, st1.Pointref.Y={st2.Pointref.Y}");
            //везде 40 и 45. работают как ссылки



            //РАЗНИЦА МЕЖДУ КЛАССОМ И СТРУКТУРОЙ В КОПИРОВАНИЕ

            //создаём экземпляр структуры
            PointVal k; //Point a = new Pointval();
            k.X = 3;
            k.Y = 5;

            PointVal b = k;
            b.X = 7;
            b.Y = 10; //два абсолютно разных экземпляра, отдельно выделена память
            k.LogValues(); // 3 qnd 5
            k.LogValues(); // 7 and 10
            ///
            Console.WriteLine("After structs");

            //экземпляр класса
            PointRef f = new PointRef(); 
            f.X = 3; 
            f.Y = 5;

            PointRef  d = f;
            d.X = 7; //после копирования обе переменные имеют одну ссылку
            d.Y = 10; // мы меняем значение и для f
            f.LogValues(); // 7 and 10
            d.LogValues();// 7 and 10




            //переменная класса Character=c
            //создали экземляр типа Character
            Character c = new Character();
            c.Hit(10);
            //Console.WriteLine(c.Health);


            //МИНУСЫ открытых методов и данных
            //например Health>=0, (можно ограничить в методе)
            c.Hit(120);
            //Console.WriteLine(c.Health);
            ///но никто не мешает записать
            //c.Health = -20;
            //поэтому лучше Health быть private

            //СВОЙСТВА
            //позволяют установить модификатор доступа отдельно
            //чтение / запись
            //открыли чтение 
            Console.WriteLine(c.Health);

            Calculator calc = new Calculator();
            double square1 = calc.CalcTriangleSquare(5, 1);
            double square2 = calc.CalcTriangleSquare(10.0, 6.0, 7.0);
            double square3 = calc.CalcTriangleSquare(10, 6, 7);
            Console.WriteLine($"Square1 = {square1}, Square2 = {square2}, Square3 = {square3}");

            double average=calc.Average(new int[] {1,2,3,4});
            double average2 = calc.Average2( 1, 2, 3, 4 );

            Console.WriteLine(average);
            Console.WriteLine(average2);

            /***************************************/
            //именованные аргументы==улучшить читабельность
            //по сути предворяем их именами
            ProgramStatic.CalcTriangleSquare(first: 10, second: 5, third: 6);

            //OUT применение
            Console.WriteLine("Enter a number, please.");
            ///TryDo
            bool wasParsed = int.TryParse(Console.ReadLine(), out int result);
            if (wasParsed)
            Console.WriteLine($"Полученное число = {result}");
            //наш метод с OUT
            bool tryDivide = calc.TryDivide(20, 40, out double result2);
            if (tryDivide)
            {
                Console.WriteLine($"Результат деления = {result2}");
            }

            //СТАТИК
            //Применимо к методам
            ProgramStatic.CalcTriangleSquare(first: 10, second: 5, third: 6);
            double result3 = ProgramStatic.Average2_1(1, 2, 3);
            Console.WriteLine(result3);
            //к свойствам
            //к полям == 
            //работать с ними нужно статически=не создавая экземпляр класса

            //но мы по прежнему можем создавать экземляр
            ProgramStatic stat = new ProgramStatic();
            //можем запретить создание сделав, сам класс ProgramStatic 
            //статическим
            //создали статическое поле в классе Character
            //public static int Speed = 70;
            //но экземпляры класса Character никак не влияют на статический Speed
            Character s1 = new Character();
            Character s2 = new Character();
            Console.WriteLine($"s1.Speed = {s1.PrintSpeed()}, s2.Speed = {s2.PrintSpeed()}");
            s1.IncreaseSpeed(); //вызываем на экземпляре s1, повышение скорости
            //свойства у каждого экземпляра свои
            //а поля шерятся между экземплярами и всегда равны(для статичесикх)
            Console.WriteLine($"s1.Speed = {s1.PrintSpeed()}, s2.Speed = {s2.PrintSpeed()}");
            //поэтому поменялись оба значения экзмепляров

            //ГЛАВНОЕ ПОД СТАТИЧЕСКИЕ ЧЛЕНЫ ПАМЯТЬ ВЫДЕЛЯЕТСЯ ОДИН РАЗ
            //С НИМИ МЫ РАБОТАЕМ НА УРОВНЕ КЛАССА

            //опицональные параметры =вместо перегрузок
            //обязаны идти в конце
            //не можем присвоить динамичсекие вычесления(Методы)
            //уже подразумевает в радианах=false
            ProgramStatic.CalcTriangleSquare(2, 5, 30);



        }
        
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            //List это класс
        }
    } 
}
