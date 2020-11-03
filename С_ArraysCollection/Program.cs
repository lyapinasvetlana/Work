using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace С_ArraysCollection
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        static void IndexedArrays()
        {
            ///такие массивы работают медленне, чем массивы с нуля
            //размерность=4, начальный индекс=1
            Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
            myArray.SetValue(2019, 1);
            myArray.SetValue(2020, 2);
            myArray.SetValue(2021, 3);
            myArray.SetValue(2022, 4); //не вызвало исключений!!!
            Console.WriteLine($"Starting Index:{myArray.GetLowerBound(0)}");
            Console.WriteLine($"Starting Index:{myArray.GetUpperBound(0)}");

            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
            {
                Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
            //аналогично
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Аналог");

            }
        }
        static void JaggedArray()
        {
            //зубчатые массивы
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];

            Console.WriteLine("Enter the numbers for a jagged array");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Printing the Elements");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

        }
        static void MultidimArrays()
        {
            //двумерный массив =матрица
            //1 2 3 
            //2 4 5
            // одномерный 1 2 3 4

            int[,] r1 = new int[2, 3];
            int[,] r2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] r3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void StackQueue()
        {
            //STACK
            //abstract data type(может быть реализован по разному)
            //навязывает правила работы с элементами
            //работает под массивами or linked lists
            //LIFO=Last In - First Out
            //push-add item to top
            //pop - remove the top item
            //peek -get the top item without removing

            //QUEUE
            //FIFO= First In -First Out
            //enqueue - add an item to the end of the queue
            //dequeue - remove an item at the front of the queue
            //тот который прищёл первым
            //peek - get item at the front of the queue without removing

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine($"Print out 4:{stack.Peek()}");
            int back = stack.Pop(); //возвращает элемент, который удаляет
            Console.WriteLine($"Print out 3:{stack.Peek()}");

            Console.WriteLine("Iterate over the stack");
            //извлекаются с конца в начало// 3 2 1 
            foreach (var cur in stack)
            {
                Console.WriteLine(cur);
            }
            //пример отменяемые операции
            //Очередь
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine($"Print out 1:{queue.Peek()}");
            int newback = queue.Dequeue(); //возвращает элемент, который удаляет
            Console.WriteLine($"Print out 2:{queue.Peek()}");

            Console.WriteLine("Iterate over the queue");
            //извлекаются с начала до конца// 2 3 4 
            foreach (var cur in queue)
            {
                Console.WriteLine(cur);
            }

        }
        static void BasicDictionary()
        {
            //с ключом типа int, ассоциируется значение типа string
            var people = new Dictionary<int, string>();
            people.Add(1, "Jonh");
            people.Add(2, "Bob");
            people.Add(3, "Alice");
            //двух одинаковых ключей, быть не может
            people = new Dictionary<int, string>()
            {
                {1, "Jonh"},
                {2, "Bob"},
                {3, "Alice"}
            };
            //чтобы быстро найти значение (по ключу) !=индекс
            string name = people[1];
            Console.WriteLine(name);
            //проще var ==ключи проитерировать
            Console.WriteLine("Iteration_Keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("Iteration_Value");
            var values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine("Iteration_Both");
            //pair тип, содержащий и ключи и значение
            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}, Value:{pair.Value}");
            }
            //количсетво элементов в словаре
            Console.WriteLine($"Count={people.Count}");
            //поиск ключа=2, ищет гораздо быстрее, чем в массиве 
            bool containKey = people.ContainsKey(2);
            //поиск значений работает, так же по скорости,как в массиве(листе)
            bool containValue = people.ContainsValue("Bob");
            Console.WriteLine($"Contains key:{containKey}, Contains value:{containValue}");
            //удаление значения по нулю
            //возвращает bool
            people.Remove(1);
            //потпытаться добавить
            if (people.TryAdd(2, "Ellias"))
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            //в val будет значение
            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key=2, Val={val}");
            }
            else Console.WriteLine("Failed");
            people.Clear();
        }
       
        static void BasicList()
        {
            //List можно изменить размерность
            //динамически-расширяем
            //внутри держит по факту массив
            //и при добавление элемената
            //он создаёт массив большей длины в два раза
            //и копирует туда элементы 
            //Add модифицирует исходный лист
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };
            intList.AddRange(intArray);
            //remove- возвращает bool 
            //сначала удалет, если находит, что удалить, то true
            if (intList.Remove(1))//удаляет только первое значение
            {
                //do
            }
            //() индекс, с котрого удалять
            intList.RemoveAt(0);
            intList.Reverse();

            //проверить содержаение в листе
            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();
            Console.WriteLine($"Min={min}, Max={max}.");
            //первое и последние вхождения двойки
            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            //Count вместо Length
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"{intList[i]} ");
            }
            Console.WriteLine();

            foreach (int item in intList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadLine();
        }
        static void BasicArrayCommands()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //запускаем двоичный поиск
            //(работает только на упорядоченном масииве)
            //возращает индекс первого вхождения искомого числа
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);
            int[] copy = new int[10];
            //(который хотим скопировать, в какой, сколько элементов)
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            //метод уровня экземпляра 
            //(+передаём начальный индекс копирования)
            copy.CopyTo(anotherCopy, 0);
            //реверс всех элементов
            Array.Reverse(copy); //не возвращает новый массив
            foreach (var c in copy)
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
            Array.Clear(copy, 0, copy.Length);
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

    }
}
