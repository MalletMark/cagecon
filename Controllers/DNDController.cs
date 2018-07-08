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
                new Teams.Character() { name = "Derek", photoUrl = "/img/dnd/derek.png" },
                new Teams.Character() { name = "Bordir", photoUrl = "/img/dnd/bordir.png" },
                new Teams.Character() { name = "Tho'Kit", photoUrl = "/img/dnd/thokit.png" },
                new Teams.Character() { name = "Torrig", photoUrl = "/img/dnd/torrig.png" },
                new Teams.Character() { name = "Erryn", photoUrl = "/img/dnd/erryn.png" }
            };

            return View(model);
        }
    }
}
