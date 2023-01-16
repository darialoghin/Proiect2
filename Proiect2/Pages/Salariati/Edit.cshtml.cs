using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Salariati
{
    public class EditModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public EditModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Salariat Salariat { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Salariat == null)
            {
                return NotFound();
            }

            var salariat =  await _context.Salariat.FirstOrDefaultAsync(m => m.ID == id);
            if (salariat == null)
            {
                return NotFound();
            }
            Salariat = salariat;
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

            _context.Attach(Salariat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalariatExists(Salariat.ID))
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

        private bool SalariatExists(int id)
        {
          return _context.Salariat.Any(e => e.ID == id);
        }
    }
}
