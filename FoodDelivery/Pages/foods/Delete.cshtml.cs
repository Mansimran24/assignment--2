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
    public class DeleteModel : PageModel
    {
        private readonly fooddeliveryfoodContext _context;

        public DeleteModel(fooddeliveryfoodContext context)
        {
            _context = context;
        }

        [BindProperty]
        public foodie foodie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            foodie = await _context.foodie.FirstOrDefaultAsync(m => m.ID == id);

            if (foodie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            foodie = await _context.foodie.FindAsync(id);

            if (foodie != null)
            {
                _context.foodie.Remove(foodie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
