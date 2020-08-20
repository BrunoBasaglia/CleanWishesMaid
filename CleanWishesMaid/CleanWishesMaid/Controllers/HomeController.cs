using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CleanWishesMaid.Models;

namespace CleanWishesMaid.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            var model = new CleanWishesMaidModel
            {
                Home = "active",
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/About")]
        public IActionResult About()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = "active",
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = string.Empty
            };

            return View(model);
        }

        [Route("/Veterinarian")]
        public IActionResult Veterinarian()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = "active",
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/Services")]
        public IActionResult Services()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = "active",
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/Gallery")]
        public IActionResult Gallery()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = "active",
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/Pricing")]
        public IActionResult Pricing()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = "active",
                Blog = string.Empty,
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/Blog")]
        public IActionResult Blog()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = "active",
                Contact = string.Empty
            };
            return View(model);
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            var model = new CleanWishesMaidModel
            {
                Home = string.Empty,
                About = string.Empty,
                Veterinarian = string.Empty,
                Services = string.Empty,
                Gallery = string.Empty,
                Pricing = string.Empty,
                Blog = string.Empty,
                Contact = "active"
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
