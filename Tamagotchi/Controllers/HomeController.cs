using Microsoft.AspNetCore.Mvc;
using DigitalPet.Models;
using System.Collections.Generic;

namespace DigitalPet.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/tamagotchi")]
        public ActionResult List()
        {
            List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
            return View(allTamagotchi);
        }
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/tamagotchi")]
        public ActionResult Create(string name)
        {
            Tamagotchi myPet = new Tamagotchi(name);
            return RedirectToAction("List", myPet);
        }

        [HttpGet("/feedButton/{id}")]
        public ActionResult Show(int id)
        {
            Tamagotchi pet = Tamagotchi.Find(id);
            return View(pet);
        }

        [HttpPost("/feedButton/{id}")]
        public ActionResult Feed(int id)
        {
            Tamagotchi myPet = Tamagotchi.Find(id);
            myPet.Feed(myPet.GetFood() + 1);
            return View("Show", myPet);
        }

    }
}
