using System;
using System.Collections.Generic;

namespace F
{
    class Program
    {
        
        static void Main(string[] args)
        {           

            //Adder.AddBirthday();

            //DateTime now = DateTime.Now;
            //string strDate = now.ToString("dd-MM-yyyy");

            //Console.WriteLine(strDate);

           // PersonClass.PersonInfo.Add("Nickname", PersonClass.Nickname);



            while (true)
            {
                Console.WriteLine("Please press a command key: " +
                    "\n(1) Add Contact" +
                    "\n(2) View Contacts" +
                    "\n(3) Edit Contacts");


                var command = Console.ReadKey();
                switch (command.Key)
                {
                    case ConsoleKey.D1:
                        Adder.AddContact();
                        break;
                    case ConsoleKey.D2:
                        Writer.WriteAllContacts();
                        break;
                    case ConsoleKey.D3:
                        Menus.EditMenu();
                        break;

                }

            }
        }
    }
}
