using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("user")]
        public IActionResult NewUser() {

            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(User user){
            if (ModelState.IsValid){
                // do stuff like insert into db..

                // then redirect
                return RedirectToAction("someaction");
            } else {
                // return view response with modelstate and the errors it now contains.
                return View("NewUser");
            }
        }
    }
}