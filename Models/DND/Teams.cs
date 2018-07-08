using System;
using System.Collections.Generic;

namespace CageCon.Models.DND
{
    public class Teams
    {
        public string teamName { get; set; }
        public string photoUrl { get; set; }
        public List<Character> characters { get; set; }

        public class Character
        {
            public int id { get; set; }
            public string name { get; set; }
            public string photoUrl { get; set; }
            public string bio { get; set; }
        }

        public Teams GetTeamByName(string name)
        {
            return new Teams()
            {
                teamName = name,
                photoUrl = "test"
            };
        }
    }
}