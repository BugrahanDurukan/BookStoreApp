using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models.View_Models
{
	public class ListViewModel
	{
		public IEnumerable<Magazine> Magazines { get; set; }
		public IEnumerable<Novel> Novels { get; set; }
		public PagingInfo PagingInfo { get; set; }

	}
}
