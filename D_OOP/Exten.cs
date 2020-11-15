using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface IExtention
    {
        //С помощью расширения можно добавит
        //И декларацию и реализацию
        //клиенты смогут расширть клиенты и поставщики
        
        void Add(object obj);
        void Remove(object obj);
        //мы уже выкатили 2 метода и ходим добавить новый

        //
    }
    //для этого нужен отдельный класс
    public static class BaseCollectionExt
    {
        //так же статический и публичный (this .. collection, список параметров)
        //IEnumerable позволяет по инстанциям делать foreach
        public static void AddRange(this IExtention collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }

        }
    }
    //взято из Interface
    public class BaseList2 : IExtention
    {
        private object[] items;
        private int count = 0;

        public BaseList2(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;

        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
