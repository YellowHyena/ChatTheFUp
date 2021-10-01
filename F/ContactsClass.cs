using System;
using System.Collections.Generic;

namespace F
{
    class ContactsClass
    {
       
        public static List<string> ContactList = new List<string>();
        


        public static string Stylin(string input)
        {
            input = input.Trim(); // Ta bort onödiga mellanslag
            var firstLetter = input.Substring(0, 1).ToUpper(); // Första bokstaven Versal
            var theRest = input.Substring(1).ToLower(); // Resten i gemener
            return firstLetter + theRest; // Returnera namnet
        }
    }

    
}
