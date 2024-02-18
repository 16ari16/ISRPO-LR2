using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Task1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Task1(string a, string b, string c) 
        {
            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);

            if (a1<b1+c1 && b1 < a1 + c1 && c1 < b1 + a1)
            {
                ViewBag.message = "Треугольник существует";
                return View();
            }
            ViewBag.message = "Треугольник не существует";
            return View();
        }


        public IActionResult Task2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Task2(string number)
        {
            int a = Convert.ToInt32(number);
            if (a==1)
            {
                Language.count1++;
            }
            if (a == 2)
            {
                Language.count2++;
            }
            if (a == 3)
            {
                Language.count3++;
            }
            if (a == 0)
            {
                Language.count0++;
            }
            ViewBag.EnglishCount = Language.count1;
            ViewBag.GermanCount = Language.count2;
            ViewBag.FrenchCount = Language.count3;
            ViewBag.NoLanguageCount = Language.count0;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Task3()
        {
            Random rand = new Random();
            ViewBag.arr = new int[20];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                ViewBag.arr[i] = rand.Next(-15, 41);
                if (ViewBag.arr[i] < 0)
                {
                    sum += ViewBag.arr[i];
                    count++;
                }

            }
            ViewBag.avg = sum / count;
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}