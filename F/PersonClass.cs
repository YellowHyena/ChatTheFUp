using System.Collections.Generic;

namespace F
{
    public class PersonClass
    {
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
        public string FavFood { get; set; }
        public string HateFood { get; set; }
        public string FavAnimal { get; set; }
        public string FavMovieGenre { get; set; }

        public static bool IsGhosted = false;
        public static bool IsBlocked = false;

        public static Dictionary<string, string> PersonInfo = new();
    }
}

