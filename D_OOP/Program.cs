using System;

namespace D_OOP
{
    class Program
    //контейнер метода, с которого начинается программа
    {
        static void Main(string[] args)
        {
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
            Character notChangeSpeed = new Character();
            

        }
    } 
}
