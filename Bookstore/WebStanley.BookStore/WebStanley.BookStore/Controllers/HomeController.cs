using Microsoft.AspNetCore.Mvc;

namespace WebStanley.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello stanley from webstanley";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
