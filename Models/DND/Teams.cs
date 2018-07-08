using System;
using System.Collections.Generic;

namespace CageCon.Models.DND
{
    public class Teams
    {
        public string teamName { get; set; }
        public string photoUrl { get; set; }
        public List<Character> characters {get;set;}

        public class Character
        {
            public string name { get; set; }
            public string photoUrl { get; set; }
        }
    }
}