using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesAlbum.Data;
using RazorPagesAlbum.Models;

namespace RazorPagesAlbum.Pages.AudioAlbum
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesAlbum.Data.RazorPagesAlbumContext _context;

        public CreateModel(RazorPagesAlbum.Data.RazorPagesAlbumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Audio Audio { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Audio == null || Audio == null)
            {
                return Page();
            }

            _context.Audio.Add(Audio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
