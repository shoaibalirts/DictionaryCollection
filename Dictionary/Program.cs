using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                {101,"Shoaib Ali" },
                {102, "Muhammad Ahmed" },
                {103, "Ali Ahmed" }
            };
            Console.WriteLine("Key: Value");
            Console.WriteLine("-----------");
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine(employee.Key + ": " + employee.Value);
            }
            Console.WriteLine("-----------");
            // fetch value based on key
            string s = employees[101];
            Console.WriteLine(s);

            // storing all keys using KeyCollection class
            Dictionary<int, string>.KeyCollection keys = employees.Keys;
            foreach (int item in keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(employees[item]);
            }

        }
    }
}
