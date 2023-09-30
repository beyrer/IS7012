using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BearcatSportsBuyback.Data;
using BearcatSportsBuyback.Models;

namespace BearcatSportsBuyback.Pages.SportingGoods
{
    public class StatisticsModel : PageModel
    {
        private readonly BearcatSportsBuyback.Data.BearcatSportsBuybackContext _context;

        public StatisticsModel(BearcatSportsBuyback.Data.BearcatSportsBuybackContext context)
        {
            _context = context;
        }

        public double AverageQuantity { get; set; }
        public int TQuantity { get; set; }
        public int TotalQuantity { get; set; }

        public async Task OnGetAsync()
        {
                AverageQuantity = await _context.SportingGood.AverageAsync(x => x.Quantity);
                TQuantity = await _context.SportingGood.SumAsync(x => x.Quantity);
                TotalQuantity = await _context.SportingGood.CountAsync();
        }
    }
}
