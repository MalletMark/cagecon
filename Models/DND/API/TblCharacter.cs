using System;
using System.Collections.Generic;
using NPoco;

namespace CageCon.Models.DND
{
    [TableName("dnd.tblcharacter")]
    [PrimaryKey("characterid")]
    public class TblCharacter
    {
        public int characterId {get;set;}
        public int teamId {get;set;}
        public string name {get;set;}
        public string bioshort {get;set;}
        public string biofull {get;set;}
        public string photourl {get;set;}
    }
}