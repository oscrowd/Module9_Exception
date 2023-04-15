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
        public string name { get; set; }
        public Person(string name)

        {
            this.name = name;
        }

        public static int SortName(Person x, Person y)
        {
            int ret = x.name.CompareTo(y.name);
            return ret;
        }

    }


    class Program
    {
        static void Sort(List<Person> list, Func<Person, Person, int> comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer(list[i], list[j]) > 0)
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>()
            {
            new Person("Peach"),
            new Person("Avocado"),
            new Person("Apple")
            };

            Sort(Persons, Person.SortName); ///////apple, avocado, peach
            Console.WriteLine("Алфавитный список товаров:\r\n"
            + string.Join("\r\n", Persons.Select(st => st.name)));
            Console.WriteLine();




        }
    }
}




