using System;

namespace F
{
    class Adder
    {
        public static void AddContact()
        {
            PersonClass person = new PersonClass();
            Console.Clear();
            Console.Write("Nickname: ");
            person.Nickname = Console.ReadLine();
            Program.ContactList.Add(person.Nickname);

            PersonClass.PersonInfo.Add("Nickname", person.Nickname);

            Console.WriteLine($"You added {person.Nickname} to your contact list");


        }
        public static void AddBirthday()
        {
            Console.Clear();
            Console.Write("Write birthday (dd-mm-yyyy): ");
            PersonClass.Birthday = Console.ReadLine();           
            DateTime birthday = Convert.ToDateTime(PersonClass.Birthday);

            Console.WriteLine($"da bithtajm is {birthday.Day}/{birthday.Month}/{birthday.Year}");
        }
    }
}
