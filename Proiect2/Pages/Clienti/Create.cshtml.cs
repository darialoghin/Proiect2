using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Clienti
{
    public class CreateModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public CreateModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ManichiuraID"] = new SelectList(_context.Manichiura, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Client.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
