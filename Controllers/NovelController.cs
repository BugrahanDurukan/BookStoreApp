using BugrahanDurukan_HW2.Models;
using BugrahanDurukan_HW2.Models.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Controllers
{
	public class NovelController : Controller
	{
		private readonly ILogger<NovelController> _logger;
		public int PageSize = 4;
		private INovelRepository _repository;

		MagazineDBContext _context;
		public NovelController(ILogger<NovelController> logger, INovelRepository repository, MagazineDBContext context)
		{
			_logger = logger;
			_repository = repository;
			_context = context;
		}
		//paging page functionality
		public IActionResult Index(int page=1)
		{
			ListViewModel viewModel = new ListViewModel
			{
				Novels = _repository.Novels.OrderBy(p => p.NovelId)
	.Skip((page - 1) * PageSize)
	.Take(PageSize)
,
				PagingInfo = new PagingInfo
				{
					CurentPage = page,
					ItemsPerPage = PageSize,
					TotalItems = _repository.Novels.Count()
				}
			};
			return View(viewModel);
		}
		public IActionResult Detail(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var products = _context.Novels.Where(p => p.NovelId == id).SingleOrDefault();
			if (products == null)
			{
				return NotFound();
			}
			return View(products);
		}
		public IActionResult Create()
		{
			Novel p = new Novel();
			return View(p);
		}
		[HttpPost]
		public IActionResult Create(Novel p)
		{
			_context.Novels.Add(p);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			Novel p = _context.Novels.Where(p => p.NovelId == id).SingleOrDefault();
			if (p == null)
			{
				return NotFound();
			}
			return View(p);
		}
		[HttpPost]
		public IActionResult Edit(Novel pmodel)
		{
			if (ModelState.IsValid)
			{
				Novel p = _context.Novels.Where(p => p.NovelId == pmodel.NovelId).SingleOrDefault();
				if (p != null)
				{
					_context.Entry(p).CurrentValues.SetValues(pmodel);
					_context.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			return View(pmodel);
		}

		public IActionResult Delete(int? id)
		{
			Novel p = _context.Novels.Where(p => p.NovelId == id).SingleOrDefault();

			return View(p);
		}
		[HttpPost]
		public IActionResult Delete(int id, Novel pmodel)
		{
			Novel p = _context.Novels.Where(p => p.NovelId == id).SingleOrDefault();
			if (p != null)
			{
				_context.Novels.Remove(p);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(p);
		}


	}
}

