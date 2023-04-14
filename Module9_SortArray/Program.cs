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
            //Записываем в массив
            Array array = new Array();
            FIO = array.GetArrayFromConsole();

            Console.WriteLine("Начальный массив");

            foreach (string fio in FIO)
            {

                // Display Original List
                Console.WriteLine(fio);
            }
            Console.ReadLine();

            IEnumerable<string> FIO1 = from fio in FIO
                                        orderby fio.Substring(0, 1) descending
                                        select fio;
            Console.WriteLine("Отсортированный список массив");

            foreach (string fio1 in FIO1)
            {

                // Display Original List
                Console.WriteLine(fio1);
            }
            Console.ReadLine();

        }
    }

   
}
