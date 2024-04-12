using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesAlbum.Data;
using RazorPagesAlbum.Models;

namespace RazorPagesAlbum.Pages.AudioAlbum
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesAlbum.Data.RazorPagesAlbumContext _context;

        public IndexModel(RazorPagesAlbum.Data.RazorPagesAlbumContext context)
        {
            _context = context;
        }

        public IList<Audio> Audio { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? AudioGenre { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Audio
                                            orderby m.Genre
                                            select m.Genre;

            var audios = from m in _context.Audio
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                audios = audios.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(AudioGenre))
            {
                audios = audios.Where(x => x.Genre == AudioGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Audio = await audios.ToListAsync();
        }
    }
}
