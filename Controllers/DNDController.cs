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
        public ActionResult Teams(string id = "")
        {
            Teams model = new Teams();
            model.teamName = "Taldorei Service Agency";
            model.photoUrl = "/img/dnd/TSA_Logo.png";

            model.characters = new List<Teams.Character>()
            {
                new Teams.Character() { id = 1, name = "Derek", photoUrl = "/img/dnd/derek.png", bio = "story 1" },
                new Teams.Character() { id = 2, name = "Bordir", photoUrl = "/img/dnd/bordir.png", bio = "story 1" },
                new Teams.Character() { id = 3, name = "Tho'Kit", photoUrl = "/img/dnd/thokit.png", bio = "story 1" },
                new Teams.Character() { id = 4, name = "Torrig", photoUrl = "/img/dnd/torrig.png", bio = "story 1" },
                new Teams.Character() { id = 5, name = "Erryn", photoUrl = "/img/dnd/erryn.png", bio = "story 1" }
            };

            return View(model);
        }
    }
}
