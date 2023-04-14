using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_SortArray
{
    public class Array
    {
        public string[] GetArrayFromConsole()
        {
            var result = new string[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = Console.ReadLine();
            }

            return result;
        }
    }
}
