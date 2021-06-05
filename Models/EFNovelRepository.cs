using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models
{
	public class EFNovelRepository : INovelRepository
	{
		private MagazineDBContext _context;
		public EFNovelRepository(MagazineDBContext context)
		{
			_context = context;
		}
		public IQueryable<Novel> Novels => _context.Novels;

		public IQueryable<Magazine> Magazines => _context.Magazines;

	}    
}
