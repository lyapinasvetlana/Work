using System;

namespace С_ArraysCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //запускаем двоичный поиск
            //(работает только на упорядоченном масииве)
            //возращает индекс первого вхождения искомого числа
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);
            int[] copy = new int[10];
            //(который хотим скопировать, в какой, сколько элементов)
            Array.Copy(numbers, copy,numbers.Length);

            int[] anotherCopy = new int[10];
            //метод уровня экземпляра 
            //(+передаём начальный индекс копирования)
            copy.CopyTo(anotherCopy,0);
            //реверс всех элементов
            Array.Reverse(copy); //не возвращает новый массив
            foreach(var c in copy)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            //отсортировать элементы
            Array.Sort(copy);
            foreach (var c in copy)
            {
                Console.WriteLine(c);
            }
            //очистка массива, c какого элемента
            //какое количество 
            Array.Clear(copy,0,copy.Length);
            //способы создания массивов
            int[] a1;
            a1 = new int[10];
            int[] a2 = new int[5];
            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };
            int[] a4 = { 1, 3, 2, 4, 5 };
            //коллекции с заранее определенным
            //количеством элементов(при инициализации)
            //это сахар они представлены типом Array
            Array myArray = new int[5];
            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            myArray2.SetValue(12, 0); //(значение, индекс)
            Console.WriteLine(myArray2.GetValue(0));
          
        }
        static void BasicArrayCommands()
        {

        }

    }
}
