using System;
using System.Collections.Generic;
using NPoco;

namespace CageCon.Models.DND
{
    [TableName("dnd.tblteam")]
    [PrimaryKey("teamid")]
    public class TblTeam
    {
        public int teamid {get;set;}
        public string teamname {get;set;}
        public string shortname {get;set;}
        public string photourl {get;set;}
    }
}