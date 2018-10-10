using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CageCon.Models.DND;

namespace CageCon.Controllers
{
    public class DNDController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Teams(string id = "TSA")
        {
            Repository.DND.Repo repo = new Repository.DND.Repo();
            Teams model = repo.GetTeamByShortName(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult<string> GetTeamById(int id)
        {
            Repository.DND.Repo repo = new Repository.DND.Repo();
            return repo.GetTeamById(id).teamName;
        }

        [HttpGet]
        public ActionResult<string> GetBio(int id)
        {
            Repository.DND.Repo repo = new Repository.DND.Repo();
            return repo.getBio(id);
        }

    }
}
