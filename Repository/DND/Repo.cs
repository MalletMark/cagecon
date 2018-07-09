using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using NPoco;
using NPoco.DatabaseTypes;
using CageCon.Models.DND;

namespace CageCon.Repository.DND
{
    public class Repo
    {
        private IDatabase db = new NPoco.Database(@"host=cage-con.com;user id=postgres;password=P@ssw0rd;database=postgres;", DatabaseType.PostgreSQL, Npgsql.NpgsqlFactory.Instance);

        public Repo() {}

        public List<Teams> GetAllTeams()
        {
            return db.Fetch<TblTeam>().Select(x => new Teams(){
                teamId = x.teamid,
                teamName = x.teamname,
                shortName = x.shortname
            }).ToList();
        }

        public Teams GetTeamById(int id)
        {
            TblTeam tblTeam = db.SingleById<TblTeam>(id);
            Teams team = new Teams();
            team.teamId = tblTeam.teamid;
            team.shortName = tblTeam.shortname;
            team.teamName = tblTeam.teamname;
            team.photoUrl = tblTeam.photourl;
            team.characters = db.Fetch<TblCharacter>("SELECT * FROM dnd.tblcharacter WHERE teamid = @t1", new {t1 = id}).Select(y => new Teams.Character(){
                id = y.characterId,
                name = y.name,
                bio = y.bioshort,
                bioFull = y.biofull,
                photoUrl = y.photourl
            }).ToList();

            return team;
        }

        public Teams GetTeamByShortName(string name)
        {
            TblTeam tblTeam = db.Single<TblTeam>("where shortname = @t1", new {t1 = name});
            Teams team = new Teams();
            team.teamId = tblTeam.teamid;
            team.shortName = tblTeam.shortname;
            team.teamName = tblTeam.teamname;
            team.photoUrl = tblTeam.photourl;
            team.characters = db.Fetch<TblCharacter>("SELECT * FROM dnd.tblcharacter WHERE teamid = @t1", new {t1 = tblTeam.teamid}).Select(y => new Teams.Character(){
                id = y.characterId,
                name = y.name,
                bio = y.bioshort,
                bioFull = y.biofull,
                photoUrl = y.photourl
            }).ToList();

            return team;
        }
    }
}