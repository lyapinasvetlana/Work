using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IShape
    {
        int CalcSquare();
    }
    //решение проблемы снизу

    public class Rect2 : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            return Height * Width;
        }
    }
    public class Squre2 : IShape
    {
        public int SideLength { get; set; }
        public int CalcSquare()
        {
            return SideLength * SideLength;
        }
    }
    //Problems

    //класс прямоугольника
    public class Rect
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    //квадрат наследует прямоугольник

    public class Squre : Rect
    {

    }
    //класс для вычеслений
    public static class AreaCalc
    {
        public static int CalculateSquare(Squre squre)
        {
            return squre.Height * squre.Height;
        }

        public static int CalculateSquare(Rect rect)
        {
            return rect.Height * rect.Width;
        }
    }
}
