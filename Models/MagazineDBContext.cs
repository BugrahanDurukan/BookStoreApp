using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models
{
    public class MagazineDBContext : DbContext
    {
        public MagazineDBContext(DbContextOptions<MagazineDBContext> options) : base(options) { }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Novel> Novels { get; set; }
    }
}
