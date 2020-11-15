using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public abstract class Shape
    {
        //экземпляр НЕЛЬЗЯ СОЗДАТЬ У АБСТРАКТНОГО КЛАССА
        //virtual могут имееть реализацию
        //и их мы можем переопределять или не переопределять

        //когда делаем КЛАСС abstract
        //Мы можем определять и виртуальный методы внутри


        //объявление конструктора
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }

        //КОНТРАКТ = просто описание сигнатуры
        //НАСЛЕДУЮЩИЕ КЛАССЫ ГАРАНТИРОВАНО !!!!
        //переопределяют определенные методы
        //Делается с помошью абстрактных МЕТОДОВ


        //чтобы объявить члены абстрактными, нужно это добавить
        //в сам КЛАСС
        public abstract void Draw();
        //абстрактные методы не имееют фигурных скобок
        //=отстутствие реализации
        public abstract double Area();
        //поэтому наследники обязаны переопределить метод

        public abstract double Perimeter();
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac) : base() //неявно вызвается базовый конструктор
            //base() без аргументов внутри можно не писать
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle Created");
        }
         
        public override double Area()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s*(s-ac)*(s-bc)*(s-ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimeter()
        {
            return ab + bc + ac;

        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

            Console.WriteLine("Rectamgle Created");
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimeter()
        {
            return 2*(width+height);
        }
    }
}
