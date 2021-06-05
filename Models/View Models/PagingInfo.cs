using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugrahanDurukan_HW2.Models.View_Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurentPage { get; set; }
        public int TotalPage => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
