using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class MyStack
    {
        //делаем вид, что не знаем, что такое дженерики<>
        //используем тип object
        private object[] items;

        //внещний код может только читать
        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapacity = 4;
            items = new object[defaultCapacity];
        }

        public MyStack(int capacity)
        {
            items = new object[capacity];

        }
        //реализуем Push
        public void Push(object item)
        {
            if (items.Length == Count)
            {
                object[] largerArray = new object[Count * 2];
                //копируем данные в новый массив .(откуда -куда-сколько элементов)
                Array.Copy(items, largerArray, Count);
                items = largerArray;
            }
            //сначала присвоится item, потом инкремент
            items[Count++] = item;

        }
        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            items[--Count] = null;
        }
        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return items[Count-1];
        }


    }

    //исправленная обобщенная версия
    //в dictionary <TKey, TValue>
    public class MyStack2<T>
    {
        //делаем вид, что не знаем, что такое дженерики<>
        //используем тип object
        private T[] items;

        //внещний код может только читать
        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }

        public MyStack2()
        {
            const int defaultCapacity = 4;
            items = new T[defaultCapacity];
        }

        public MyStack2(int capacity)
        {
            items = new T[capacity];

        }
        //реализуем Push
        public void Push2(T item)
        {
            if (items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];
                //копируем данные в новый массив .(откуда -куда-сколько элементов)
                Array.Copy(items, largerArray, Count);
                items = largerArray;
            }
            //сначала присвоится item, потом инкремент
            items[Count++] = item;

        }
        public void Pop2()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            //items[--Count] = null;
            //не все типы поддерживают null

            items[--Count] = default;
        }
        public T Peek2()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return items[Count - 1];
        }
    }

}
