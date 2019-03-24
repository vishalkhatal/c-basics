using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_is_value_type_or_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test for list of object
            List<Person> lstPerson = new List<Person>();
            Person p1 = new Person("Vk");

            Person p2 = new Person("Kp");
            lstPerson.Add(p1);
            lstPerson.Add(p2);
            AddMorePerson(lstPerson);
            foreach (var person in lstPerson)
            {
                Console.WriteLine(person.Name);
            }
            #endregion

            #region Test for int list

            List<int> lstint= new List<int>();
            lstint.Add(10);
            lstint.Add(20);
            AddMoreNumbers(lstint);
            foreach (var number in lstint)
            {
                Console.WriteLine(number);
            }

            #endregion
            Console.ReadKey();
        }
        public static void AddMorePerson(List<Person> lstPerson)
        {
            Person p3 = new Person("Pd");
            lstPerson.Add(p3);

        }
        public static void AddMoreNumbers(List<int> lstint)
        {
            lstint.Add(30);
        }
    }
    
    class Person
    {
        public string Name { get;set; }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
