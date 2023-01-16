using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Manichiuri
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public DeleteModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Manichiura Manichiura { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Manichiura == null)
            {
                return NotFound();
            }

            var manichiura = await _context.Manichiura.FirstOrDefaultAsync(m => m.ID == id);

            if (manichiura == null)
            {
                return NotFound();
            }
            else 
            {
                Manichiura = manichiura;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Manichiura == null)
            {
                return NotFound();
            }
            var manichiura = await _context.Manichiura.FindAsync(id);

            if (manichiura != null)
            {
                Manichiura = manichiura;
                _context.Manichiura.Remove(Manichiura);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
