using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public enum TrafficLight : int
    {
        Red = 0,
        Yellow = 1,
        Green = 2
    }
    //у каждого значения перечисления есть
    //асоциируемое с ним число (неявно с нуля от инта)
    //но можно ставить любые значения
    public enum Race // : int
    {
        Elf = 30,
        Ork = 40,
        Terrain = 20
    }
    //иногда лучше чем, с измененным конструктором  со стрингом
    //когда небольшое количество
    //так это строгий тип
    public class Character2
    {

        private readonly int speed = 10;
        public int Health { get; private set; } = 100;
        public Race Race { get; private set; }
        public int Armor { get; private set; }

        public Character2(Race race)
        {
            Race = race;
            //представим, что армор зависит от ассоциируемых значений расы
            //приводим к инту
            Armor = (int)race;
        }
        public Character2(Race race, int armor)
        {
            Race = race;
            Armor = armor;

            if (race == Race.Terrain)
            {
                Armor = 20;
            }
            else if (race == Race.Elf)
            {
                Armor = 30;

            }
            else Armor = 40;

        }
        //работаем как со статическими членами
        


    }
}
