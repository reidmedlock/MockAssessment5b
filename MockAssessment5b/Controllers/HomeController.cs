using Microsoft.AspNetCore.Mvc;
using MockAssessment5b.Models;

namespace MockAssessment5b.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetAge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Person person)
        {
            if (person.Age >= 21)
                person.CanDrink = true;
            else
                person.CanDrink = false;

            if (person.Age >= 16)
                person.CanDrive = true;
            else
                person.CanDrive = false;

            return View(person);
        }
    }
}