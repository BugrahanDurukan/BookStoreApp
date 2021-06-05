using BugrahanDurukan_HW2.Models;
using BugrahanDurukan_HW2.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Sets session when we open he home page
        public IActionResult Index()
        {
            List<Magazine> productListB = new List<Magazine>()
            {
                new Magazine(){Name="HP laserJet 1200", Description="a magazine to explore",Category="Cat",Price=10},
                new Magazine(){Name="Natgeo", Description="a magazine to explore",Category="Cat",Price=10}
            };

            HttpContext.Session.SetJson("SessionProductsB", productListB);

            HttpContext.Session.SetString("SessionVariable1", "Testing123");

            return View();
        }
        //displays the session when we click on the respective navbar tab 
        //it is connected via html tag asp-action in _layout.cshtml
        public IActionResult SessionView()
        {
            List<Magazine> productList2 = HttpContext.Session.GetJson<List<Magazine>>("SessionProductsB");

            if (HttpContext.Session.GetString("SessionVariable1") != null)
                ViewBag.Message = HttpContext.Session.GetString("SessionVariable1");
            else
                ViewBag.Message = "No session was detected";

            return View(productList2);
        }
        //clears the session when we click on the respective navbar tab 
        //it is connected via html tag asp-action in _layout.cshtml
        public IActionResult SessionCleared()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
/* Sending multiple objects to view
 * public class RandomViewModel
{
    public List<CustomerDto> Customers { get; set; }
    public List<ReportDto> Reports { get; set; }
}

[AllowAnonymous]
public ActionResult RandomView()
{
   // Customer.
   var customers = _context.Customers.ToList();
   List<CustomerDto> customersDto = new List<CustomerDto>();

   foreach (var customer in customers)
   {
      customersDto.Add(new CustomerDto() { 
      Id = customer.Id,
      Name = customer.Name
      });
   }

   // Reports.
   var Reports= _context.Reports.ToList();
   List<ReportsDto> reportsDto= new List<ReportsDto>();

   foreach (var report in reports)
   {
      reportsDto.Add(new ReportsDto() {
      Id = report.Id,
      Name = report.Name
      });
   }

   var randomViewModel = new RandomViewModel() {
      Customers = customersDto,
      Reports = reportsDto
   };

   return View(randomViewModel);
}*/
//dotnet ef database update
//dotnet ef Migrations add initial