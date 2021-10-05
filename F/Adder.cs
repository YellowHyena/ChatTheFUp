using System;
using System.Collections.Generic;

namespace F
{
    class Adder
    {


        public static void AddContact()
        {
            Console.Clear();

            PersonClass person = new PersonClass();

            
            Console.Write("Nickname: ");
            person.Nickname = Console.ReadLine();            
            Console.Clear();
            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();
            ContactsClass.Stylin(person.FirstName);
            Console.Clear();
            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Clear();

            //AddBirthday();
           // PersonClass.PersonInfo.Add("Nickname", person.Nickname);

            Console.WriteLine($"{person.Nickname} has been added to your contact list!");

            PersonClass.ContactList.Add(person);

        }
        public static void AddBirthday()
        {
            Console.Clear();
            Console.Write("Write birthday (dd-mm-yyyy): ");
            string input = Console.ReadLine();           
             
            
            Console.WriteLine($"da bithtajm is {PersonClass.Birthday.Day}/{PersonClass.Birthday.Month}/{PersonClass.Birthday.Year}");
        }
    }
}
