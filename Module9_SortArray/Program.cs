using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_SortArray
{
    class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] FIO;
            Console.WriteLine("Введите 5 ФИО для сортировки:");
            //Записываем в массив ФИО
            Array array = new Array();
            FIO = array.GetArrayFromConsole();
            Console.WriteLine("Начальный массив");
            
            foreach (string fio in FIO)
            {

                // Display Original List
                Console.WriteLine(fio);
            }
            //Получаем число и сортируем
            NumberSort numberSort = new NumberSort();
            numberSort.NumberSortEvent += SortNum;
            while (true)
            {
                try
                {
                    numberSort.ReadSort();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильно! Введите 1 или 2: ");
                }
            }
            static void SortNum(int number)
            { 
                switch (number) 
                {
                    case 1: IEnumerable<string> FIO1 = from fio in FIO
                                        orderby fio.Substring(0, 1) descending
                                        select fio;
                    break;
                    case 2: IEnumerable<string> FIO1 = from fio in FIO
                                        orderby fio.Substring(0, 1) ascending
                                        select fio;
                    break;
                }
            }
            

            //IEnumerable<string> FIO1 = from fio in FIO
            //                            orderby fio.Substring(0, 1) descending
            //                            select fio;
            //Console.WriteLine("Отсортированный список массив");

            //foreach (string fio1 in FIO1)
            //{

                // Display Original List
            //    Console.WriteLine(fio1);
            //}
        }
        class NumberSort
        {
            public delegate void NumberSortDelegate();
            public event NumberSortDelegate NumberSortEvent;

            void ReadSort()
            { 
                Console.WriteLine();
                Console.WriteLine("Введите число 1 или число2: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 2 || number < 1) throw new FormatException();
                NumberSort(number);
            }
            protected virtual void NumberSort(int number) 
            {
                NumberSortEvent?.Invoke(number);
            }
        }
    }

   
}
