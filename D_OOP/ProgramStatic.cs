﻿using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public  class ProgramStatic
    {
        //чтобы взять методы из класса 
        //пользователь создает экземпляр класса калькулятор
        //класс статический и все методы в нём статические
        //по факту как контейнер статический методов
        //НЕТ СВОЙСТВ; НЕТ ПОЛЕЙ

        public static double CalcTriangleSquare(double first, double second, double third)
        {
            double perimeter = (first + second + third) / 2;
            return Math.Sqrt(perimeter * (perimeter - first) * (perimeter - second) * (perimeter - third));
            
        }
        public static double Average2_1(params int[] numbers)
        {
            double sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum / numbers.Length;
        }

        //опциональные параметры
        //вместо новый перегрузки, можно создать модификацию
        //то есть по умоланию bool isInRadians=false, если не передавать 4 агумент

        public static double CalcTriangleSquare(double first, double second, int alpha, bool isInRadians=false)
        {
            if (isInRadians)
            {
                return 0.5 * first * second * Math.Sin(alpha); //использует радианы

            }
            else
            {
                double rads1 = alpha * Math.PI / 180;
                return 0.5 * first * second * Math.Sin(rads1);  //использует радианы
            }
            
        }

    }
}
