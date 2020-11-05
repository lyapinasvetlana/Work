using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {//содержит данные и методы
       
        //private int health = 100;

     //поведение класса задётся методами(функциями)
     //в C# нет функций только методы
     //функция считается, когда объявлена вне класса

        //Объъявляем свойство(всегда public)
        //на самом деле GET and SET = МЕТОДЫ
        //доступ на чтение
        //доступ на запись закрыли(может быть protected or internal)
        public int Health { get; private set; } = 100; //автосвойство
        //либо с закрытым set/ открытм set
        //public int GetHealth()
        //  { 
        //    return health;
        //}
        //private void SetHealth(int value)
        //{
        //    health = value;
        //}

        public  void Hit(int damage)
        {
            if (damage > Health) 
            {
                damage = Health;
            }
            Health -= damage;


        }
        //void= пустой, невозвратный(он просто что-то делает)
        //создаем статическое поле 
        public static int Speed = 70;

        //добавим метод
        ///не статические члены, имеют доступ к статическим членам
        public void PrintSpeed()
        {
            Console.WriteLine($"Speed - {Speed}");
        }



    }
}
