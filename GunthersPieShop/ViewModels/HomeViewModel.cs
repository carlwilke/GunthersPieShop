using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GunthersPieShop.Models;

namespace GunthersPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
