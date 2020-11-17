using System;

namespace ExceptionTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static void Proveryaem()
        {
            //throws IOException
            //Проверяемые исключения это, которые прописываются в сигнатуре функции

            //Пример
            //public static void readFile(string filePath) throws IOException{
            //    FileRader file = new FileRader(filePath);
            //    BufferedReader fileInput = new BufferedReader(file);

            //    //print first 3 lines of the file

            //    for (int counter = 0; counter < 3; counter++)
            //    {
            //        System.out.printIn(fileInput.readLine());
            //    }
            //    fileInput.close();

            //НО проблема версионирования
            //Нельзя просто добавить новый тип исключения
            //в используемое API


            }

        }
    }
}
