using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//view component
namespace BugrahanDurukan_HW2.Components
{
    public class FooterViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedItem = 1;
            List<string> ftrText = new List<string>() { "This project is made for the purpose of learning C# in 2021 by Buğrahan Durukan." };
            return View(ftrText);
        }
    }
}
