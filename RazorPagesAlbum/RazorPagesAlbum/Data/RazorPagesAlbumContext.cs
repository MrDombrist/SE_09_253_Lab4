using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesAlbum.Models;

namespace RazorPagesAlbum.Data
{
    public class RazorPagesAlbumContext : DbContext
    {
        public RazorPagesAlbumContext (DbContextOptions<RazorPagesAlbumContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesAlbum.Models.Audio> Audio { get; set; } = default!;
    }
}
