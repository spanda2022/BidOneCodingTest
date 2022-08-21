using BidOneCodingTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace BidOneCodingTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public ActionResult SubmitForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                var jsondata = JsonSerializer.Serialize(person);


                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "person.json")))
                {
                    outputFile.WriteLine(jsondata + Environment.NewLine);
                }


                //System.IO.File.AppendAllText("person.json", jsondata + Environment.NewLine);
                    ViewBag.viewBagMsg = "Person details saved successfully.";
                    ModelState.Clear();             
            }          
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
