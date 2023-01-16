using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Manichiuri
{
    public class EditModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public EditModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Manichiura Manichiura { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Manichiura == null)
            {
                return NotFound();
            }

            var manichiura =  await _context.Manichiura.FirstOrDefaultAsync(m => m.ID == id);
            if (manichiura == null)
            {
                return NotFound();
            }
            Manichiura = manichiura;
            ViewData["ClientID"] = new SelectList(_context.Set<Publisher>(), "ID",
"ClientID");

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

            _context.Attach(Manichiura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManichiuraExists(Manichiura.ID))
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

        private bool ManichiuraExists(int id)
        {
          return _context.Manichiura.Any(e => e.ID == id);
        }
    }
}
