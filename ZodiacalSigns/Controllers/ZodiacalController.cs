using Application.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ZodiacalSigns.Controllers
{
    public class ZodiacalController : Controller
    {
        private ZodiacalService zS;
        public ZodiacalController()
        {
            zS = new();
        }
        public IActionResult Index(string? result = null)
        {
            ViewBag.result = result;
            return View();
        }

        public IActionResult GuessSign(ZodiacalViewModel z)
        {
            int day = z.Day;
            int month = z.Month;

            dynamic sign = zS.WhichIsMySign(month, day);

            return RedirectToRoute(new { controller = "Zodiacal", action = "Index", result = sign }); 
        }
    }
}
