using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5AndBootstrap.Models;

namespace MVC5AndBootstrap.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            var person = new Person
            {
                Id = 1,
                FirstName = "Goran",
                LastName = "Djordjijevski",
                BirthDate = new DateTime(year: 1987, month: 8, day: 23),
                LikesMusic = true,
                Skills = new List<string> { "Programming", "Microsoft Sql Server", "C#" }
            };

            return View(person);
        }
    }
}