using System;
using System.Collections.Generic;

namespace F
{
    class Writer
    {
        public static void WriteAllContacts()
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------");
            foreach (var person in PersonClass.ContactList)
            {
                int index = PersonClass.ContactList.IndexOf(person) +1;
                Console.WriteLine(index + ":     " + person.Nickname);
               //AllInfo(person);
            }
            Console.WriteLine("-----------------------------------------------");


        }

        private static void AllInfo(PersonClass person)
        {
            Console.WriteLine($"Nickname: {person.Nickname}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
