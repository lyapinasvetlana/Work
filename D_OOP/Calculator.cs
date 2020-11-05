using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        //Пример OUT
        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0; //по умолчанию, если операция прошла неуспешно
            if (divisor == 0)
            {
                return false;
            }
            else
            {
                result = divisible / divisor;
                return true;
            }
        }
        ///
        //какой передадут массив такой и будет
        public double Average(int[] numbers)
        {
            double sum = 0;
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum / numbers.Length;

        }

        //ИСПОЛЬЗОВАНИЕ PARAMS с массивом (1,2,3) =чтобы передавать аргументы через запятую
        //аргумент с PARAMS должен быть последним в списке
        public double Average2(params int[] numbers)
        {
            double sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum / numbers.Length;
        }


       public double CalcTriangleSquare(double first, double second, double third)
        {
            double perimeter = (first + second + third) / 2;
            return Math.Sqrt(perimeter * (perimeter - first) * (perimeter - second) * (perimeter - third));
            //возвратный метод 
        }
        //перегружать по возвращаемому значению нельзя(тип например:
        //float и double)
        //public float CalcTriangleSquare(double first,double hight)
        public double CalcTriangleSquare(double first,double hight)
        {
            return 0.5*first*hight;
            //перегрузили метод
            //сигнатура состоит из возвращаемого типа и наименования метода
            //и входящих элементов

            //если сигнатура отличается, то мы можем перезагрузить
        }
        /*Добавить перегрузку, которая принимает длины двух смежных сторон (double) и величину угла между ними. 
         * Величину угла принимать как int.
         * Метод должен рассчитывать площадь по формуле:
         * 0.5 * ab * ac * sin(alpha)
         */
        public double CalcTriangleSquare(double first,double second, int degrees)
        {
            double rads = degrees * Math.PI / 180;
            return 0.5 * first * second * Math.Sin(rads); //использует радианы
        }

    }
}
