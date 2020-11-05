using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{//Value type=структура=тип значения
 //reference type=ссылочный тип
 //первая структура:

    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X={X}, Y={Y}");
        }
    }

    ///Ссылки в структуре
    public struct EvilSt
    {
        public int X;
        public int Y;

        public PointRef Pointref; //объявили поле типа Pointref
        //структура содержит поле ссылочного типа
    }


}
