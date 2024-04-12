using Microsoft.EntityFrameworkCore;
using RazorPagesAlbum.Data;
namespace RazorPagesAlbum.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesAlbumContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesAlbumContext>>()))
        {
            if (context == null || context.Audio == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Audio.Any())
            {
                return;   // DB has been seeded
            }

            context.Audio.AddRange(
                new Audio
                {
                    Title = "Thriller",
                    ReleaseDate = DateTime.Parse("1982-10-30"),
                    Genre = "Pop",
                    Price = 9.99M,
                    Count = 9,
                    Info = "Michael Jackson's seventh studio album",
                    Lenght = 6.58M,
                    Rating = "8,9"
                },


            new Audio
            {
                Title = "Sgt. Pepper's Lonely Hearts Club Band",
                ReleaseDate = DateTime.Parse("1967-06-01"),
                Genre = "Rock",
                Price = 8.99M,
                Count = 12,
                Info = "The Beatles' eighth studio album",
                Lenght = 3.54M,
                Rating = "9,5"
            },


            new Audio
            {
                Title = "Born to Run",
                ReleaseDate = DateTime.Parse("1975-08-25"),
                Genre = "Rock",
                Price = 10.99M,
                Count = 10,
                Info = "Bruce Springsteen's third studio album",
                Lenght = 4.32M,
                Rating = "10"
            },


            new Audio
            {
                Title = "Purple Rain",
                ReleaseDate = DateTime.Parse("1984-06-25"),
                Genre = "Rock",
                Price = 11.99M,
                Count = 9,
                Info = "Prince and The Revolution's sixth studio album",
                Lenght = 7.59M,
                Rating = "8"
            },


            new Audio
            {
                Title = "Ok Computer",
                ReleaseDate = DateTime.Parse("1997-05-21"),
                Genre = "Rock",
                Price = 12.99M,
                Count = 12,
                Info = "Radiohead's third studio album",
                Lenght = 6.23M,
                Rating = "9"
            }
            );
            context.SaveChanges();
        }
    }
}
