using System;
using System.Collections.Generic;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du lägga till någon?");

        
            PersonClass.PersonInfo.Add("Nickname", PersonClass.Nickname);

            if (Console.ReadLine() == "yes")
            {
                bool anotherOne = true;

                while (anotherOne)
                {
                    anotherOne = false;

                    Adder.AddContact();

                    Console.WriteLine($"These are all your contacts:");

                    Writer.WriteAllContacts();

                    Console.WriteLine("Do you want another one?");

                    if (Console.ReadLine() == "yes")
                    {
                        anotherOne = true;
                    }

                }
            }
            else
            {
                
            }

        }
    }
}
