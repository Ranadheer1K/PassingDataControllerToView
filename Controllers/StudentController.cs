using Microsoft.AspNetCore.Mvc;

namespace PassingDataViewToController.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
