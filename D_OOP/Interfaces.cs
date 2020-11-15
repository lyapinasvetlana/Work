using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public interface ICollection
    {
        //сравнивают с контрактами
        //ВСЕ НАЧИНАЮТСЯ С I

        //может содержать только сигнатуры
        //без реализации

        void Add(object obj);
        void Remove(object obj);

    }
    public class BaseList : ICollection
    {
        private object[] items;
        private int count = 0;

        //в случае наследника Интерфейса
        //OVERRIDE можно не указывать

        //сразу от нескольких интерфейсов можно наследовать
        //А ОТ КЛАССОВ НЕЛЬЗЯ(только один)
        //можно наследовать 1 класс + много интерфейсов

        //в интерфейс нельзя просто так добавить ещё метод
        //весь следующий ход ломается, потому что метод обязательно добавить

        //в с#8 уже можно добавлять поля и члены


        public BaseList(int initialCapacity)
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
