using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.foodie;

namespace FoodDelivery.Pages_foods
{
    public class IndexModel : PageModel
    {
        private readonly fooddeliveryfoodContext _context;

        public IndexModel(fooddeliveryfoodContext context)
        {
            _context = context;
        }

        public IList<foodie> foodie { get;set; }

        public async Task OnGetAsync()
        {
            foodie = await _context.foodie.ToListAsync();
        }
    }
}
