using System;
using System.Collections;
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

    //вызываем для foreach IEnumerable
    //ctrl +left click = info
    public class MyStack2<T> : IEnumerable<T>
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
        //как реализовать легче
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new StackEnumerator<T>(items, Count);
        //}
        //явная реализация интерфейса=метод от внешнего пользователя спрятан

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = Count-1; i>=0; i--)
            {
                //using yield return =  автоматизировали весь процесс создания
                yield return items[i];
                //если в ходе сделать break, то код так же генерит по одному элементу
                //линивое вычисление == лишних зачений нет
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;
        private int position;

        public StackEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;
            position = count;
        }
        public T Current
        {
            get
            {
                return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                //возвращает результат Current
                return Current;
            }
        }
        //обычно для чистки памяти
        public void Dispose()
        {
        }
        //возвращает bool, если дальше есть элемент
        //и сдвивает указатель
        //идём с крекца в начало
        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }
        //возвращает начальный элемент
        public void Reset()
        {
            position = count;
        }
    }

}
