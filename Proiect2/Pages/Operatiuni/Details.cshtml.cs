using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Operatiuni
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public DetailsModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

      public Operatiune Operatiune { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Operatiune == null)
            {
                return NotFound();
            }

            var operatiune = await _context.Operatiune.FirstOrDefaultAsync(m => m.ID == id);
            if (operatiune == null)
            {
                return NotFound();
            }
            else 
            {
                Operatiune = operatiune;
            }
            return Page();
        }
    }
}
