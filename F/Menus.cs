using System;

namespace F
{
    class Menus
    {
        public static void EditMenu()
        {

            Console.WriteLine("These are your contacts:");
            Writer.WriteAllContacts();
            Console.Write("Type in the index number of the contact you want to edit: ");

            int.TryParse(Console.ReadLine(), out int contactChoice);
            contactChoice--;

            Console.Clear();
            Console.WriteLine($"Editing contact; {PersonClass.ContactList[contactChoice].Nickname}");

            Console.WriteLine("Please press a command key: " +
                    "\n(1) Edit names" +
                    "\n(2) Edit birthday" +
                    "\n(3) Edit social media accounts");
            //



            var command = Console.ReadKey();
            switch (command.Key)
            {
                case ConsoleKey.D1:
                    EditName(contactChoice);
                    Console.Clear();
                    Console.WriteLine($"Editing contact; {PersonClass.ContactList[contactChoice].Nickname}");
                    break;
                case ConsoleKey.D2:
                    Writer.WriteAllContacts();
                    break;

            }


        }

        public static string EditName(int input)
        {
            Console.Write("Please type in new nickname: ");
            PersonClass.ContactList[input].Nickname = Console.ReadLine();
            string newName = PersonClass.ContactList[input].Nickname;
            return newName;
        }
    }
}
