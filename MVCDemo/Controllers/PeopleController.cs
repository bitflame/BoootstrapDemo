using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ali", LastName = "Sarvari", Age=45 });
            people.Add(new PersonModel { FirstName = "Kobra", LastName = "Asghari", Age = 55 });
            people.Add(new PersonModel { FirstName = "Soghra", LastName = "Shahi", Age = 44 });
            return View(people);
        }
    }
}