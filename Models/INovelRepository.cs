using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models
{
	public interface INovelRepository
	{
		IQueryable<Novel> Novels { get; }
	}
}
