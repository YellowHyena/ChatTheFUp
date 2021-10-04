using System;
using System.Collections.Generic;

namespace F
{
    class Writer
    {
        //public static void WriteDictionary()
        //{
        //    foreach (var Person in PersonClass.PersonInfo)
        //    {
        //        Console.WriteLine(Person.Key + " " + Person.Value);
        //        Console.WriteLine(PersonClass.Nickname);
        //    }
        //}

        public static void WriteAllContacts()
        {
            Console.WriteLine("-----------------------------------------------");
            foreach (var contact in Program.ContactList)
            {
                Console.WriteLine(contact);
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
