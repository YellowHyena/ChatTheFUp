using System;

namespace F
{
    class Adder
    {
        public static void AddContact()
        {
            Console.Clear();
            Console.Write("Nickname: ");
            PersonClass.Nickname = Console.ReadLine();
            ContactsClass.ContactList.Add(PersonClass.Nickname);
            Console.WriteLine($"You added {PersonClass.Nickname} to your contact list");
        }
    
    }
}
