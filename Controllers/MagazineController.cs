using BugrahanDurukan_HW2.Models;
using BugrahanDurukan_HW2.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Controllers
{
	public class MagazineController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		MagazineDBContext _context;
		public MagazineController(ILogger<HomeController> logger, MagazineDBContext context)
		{
			_logger = logger;
			_context = context;
		}
		//Sends a list object generated from your database to the Magazine/index.cshtml to be displayed
		public IActionResult Index()
		{
			var magazines = _context.Magazines.ToList();
			return View(magazines);
		}
		//Displays a specific magazine with its details when we click on the detail button on the Magazine/index.cshtml
		public IActionResult Detail(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var products = _context.Magazines.Where(p => p.MagazineId == id).SingleOrDefault();
			if (products == null)
			{
				return NotFound();
			}
			return View(products);
		}
		//Open the create page
		public IActionResult Create()
		{
			Magazine p = new Magazine();
			return View(p);
		}
		//adds a magazine object to the database
		[HttpPost]
		public IActionResult Create(Magazine p)
		{
			_context.Magazines.Add(p);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		//Displays a specific magazine with its details when we click on the detail button on the Magazine/index.cshtml
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			Magazine p = _context.Magazines.Where(p => p.MagazineId == id).SingleOrDefault();
			if (p == null)
			{
				return NotFound();
			}
			return View(p);
		}
		//Saves the edited object to the database
		[HttpPost]
		public IActionResult Edit(Magazine pmodel)
		{
			if (ModelState.IsValid)
			{
				Magazine p = _context.Magazines.Where(p => p.MagazineId == pmodel.MagazineId).SingleOrDefault();
				if (p != null)
				{
					_context.Entry(p).CurrentValues.SetValues(pmodel);
					_context.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			return View(pmodel);
		}
		//Opens the delete page
		public IActionResult Delete(int? id)
		{
			Magazine p = _context.Magazines.Where(p => p.MagazineId == id).SingleOrDefault();

			return View(p);
		}
		//Deletes a record from the database
		[HttpPost]
		public IActionResult Delete(int id, Magazine pmodel)
		{
			Magazine p = _context.Magazines.Where(p => p.MagazineId == id).SingleOrDefault();
			if (p != null)
			{
				_context.Magazines.Remove(p);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(p);
		}


	}
}
