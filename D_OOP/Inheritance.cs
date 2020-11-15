using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class BankTerminal
    {
      


        //ИНКАПСУЛЯЦИЯ = Защита класса
        //ОЪЯВЛЯЕМ конструктор
        //обязываем внешний код передавать аргументы
        //+проверяем аргументы на корректность


        //НАСЛЕДОВАНИЕ
        //переиспользование базового кода

        //Пример банковский терминал подключается к серверу
        //три терминала и все разные
        //но часть подключения одинаковые

        //protected закрыт, но доступен в наследниках
        protected string id;
        public BankTerminal(string id)
        {
            this.id = id;
        }

        //VIRTUAL = часть смогут преопределить + наследник
        public virtual void Connect()
        {
            Console.WriteLine("General Connecting Protocol...");
            //например некоторым моделям банкомата этого недостаточно
        }

    }
    //для наследования используем :
    public class BankTerminalX : BankTerminal
    {
        //можно здесь поле инициализировать
        //как ниже, но можно в базовом классе сразу

        //public BankTerminalX(string id)
        //{
        //    base.id = id;
        //}

        //передать работу из базового конструктора
        //чтобы не повторять, код посылается наверх
        public BankTerminalX(string id) : base(id)
        {
            
        }




        //override= переопределенный
        public override void Connect()
        {
            //теперь можем воспользовать 
            //PROTECTED полем


            //base = обращаемся к базовому классу
            base.Connect();
            /* вызов пойдёт к
             * Console.WriteLine("General Connecting Protocol...");
             * а потом уже продолжит здесь*/
            Console.WriteLine("Additional actions for model X");
        }
    }
    public class BankTerminalY : BankTerminal
    {
        public BankTerminalY(string id) : base(id)
        {

        }
        public override void Connect()
        {
            //без базового
            Console.WriteLine("Actions for model Y");
        }

    }
}
