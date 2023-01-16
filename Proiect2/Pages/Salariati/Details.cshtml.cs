﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Models;

namespace Proiect2.Pages.Salariati
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect2.Data.Proiect2Context _context;

        public DetailsModel(Proiect2.Data.Proiect2Context context)
        {
            _context = context;
        }

      public Salariat Salariat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Salariat == null)
            {
                return NotFound();
            }

            var salariat = await _context.Salariat.FirstOrDefaultAsync(m => m.ID == id);
            if (salariat == null)
            {
                return NotFound();
            }
            else 
            {
                Salariat = salariat;
            }
            return Page();
        }
    }
}
