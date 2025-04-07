using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272Lecture4v1.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            var people = new List<PersonModel>
    {
        new PersonModel { FirstName = "Person01", LastName = "Surname01", Age = 20, IsAlive = true, myLink = "~/HTML/Person01.html" },
        new PersonModel { FirstName = "Person02", LastName = "Surname02", Age = 21, IsAlive = true, myLink = "~/HTML/Person02.html" },
        new PersonModel { FirstName = "Person03", LastName = "Surname03", Age = 22, IsAlive = true, myLink = "~/HTML/Person03.html" },
        new PersonModel { FirstName = "Person04", LastName = "Surname04", Age = 23, IsAlive = true, myLink = "~/HTML/Person04.html" },
        new PersonModel { FirstName = "YourName", LastName = "YourSurname", Age = 24, IsAlive = true, myLink = "~/HTML/YourName.html" }};
            return View(people);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Action called form1 accepts parameters and assign it to ViewBag objects to be dispayed in the Contact page
        [HttpPost]
        public ActionResult form1(string fName, string lName, int age, string isAlive)
        {
            
            ViewBag.FirstName = fName;
            ViewBag.LastName = lName;
            ViewBag.Age = age;
          
            if (isAlive != null)
                
                ViewBag.IsAlive = "Alive";
            else
                ViewBag.IsAlive = "Not Alive";

            return View("Contact");
        }

        //Action called form2 accepts an object and assign its properties to ViewBag objects to be dispayed in the Contact page
        [HttpPost]
        public ActionResult form2(Models.PersonModel pm)
        {
            ViewBag.FirstName = pm.FirstName;
            ViewBag.LastName = pm.LastName;
            ViewBag.Age = pm.Age;

            if (pm.IsAlive == true)

                ViewBag.IsAlive = "Alive";
            else
                ViewBag.IsAlive = "Not Alive";

            return View("Contact");
        }
        public ActionResult GridPage()
        {
            return View();
        }

        public ActionResult PanelPage()
        {
            return View();
        }

        public ActionResult StudyBuddies()
        {
            return View();
        }
    }
}