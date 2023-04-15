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

            string[] FIO = { "Иванов Иван Иванович", "Че Гевара Ирнесто", "Леонтьев Валерий Константинович", "Марсело Виейра Джуниор", "Паркер Питер Питерович"};
            //Console.WriteLine("Введите 5 ФИО для сортировки:");
            //Записываем в массив ФИО
            //Array array = new Array();
            //FIO = array.GetArrayFromConsole();
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
            void SortNum(int number, string[] FIO1)
            {
                switch (number)
                {
                    case 1:
                        IEnumerable<string> FIO2 = from fio in FIO1
                                                   orderby fio.Substring(0, 1) descending
                                                   select fio;
                        break;
                    case 2:
                        FIO2 = from fio in FIO1
                                                   orderby fio.Substring(0, 1) ascending
                                                   select fio;
                        break;
                }
            }
        }
    }   
       
        class NumberSort
        {
            public delegate void NumberSortDelegate();
            public event NumberSortDelegate NumberSortEvent;

            public void ReadSort()
            { 
                Console.WriteLine();
                Console.WriteLine("Введите число 1 или число2: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 2 || number < 1) throw new FormatException();
                NumberSort(number);
            }
            protected virtual void NumberSort(int number) 
            {
            NumberSortEvent?.Invoke();
            }
        }
}




