using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDelivery.foodie;

namespace FoodDelivery.Pages_foods
{
    public class EditModel : PageModel
    {
        private readonly fooddeliveryfoodContext _context;

        public EditModel(fooddeliveryfoodContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(foodie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!foodieExists(foodie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool foodieExists(int id)
        {
            return _context.foodie.Any(e => e.ID == id);
        }
    }
}
