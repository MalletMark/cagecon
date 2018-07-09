using System;
using System.Collections.Generic;
using NPoco;

namespace CageCon.Models.DND
{
    public class Teams
    {
        public int teamId {get;set;}
        public string teamName { get; set; }
        public string shortName {get; set; }
        public string photoUrl { get; set; }
        public List<Character> characters { get; set; }

        public class Character
        {
            public int id { get; set; }
            public string name { get; set; }
            public string photoUrl { get; set; }
            public string bio { get; set; }
            public string bioFull {get;set;}
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