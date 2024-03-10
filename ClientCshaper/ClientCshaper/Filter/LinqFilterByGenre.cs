using System.Text.Json.Serialization;
using ClientCshaper.Model;

namespace ClientCshaper.Filter;

public class LinqFilterByGenre
{
    public static void FilterByGenre(List<Music> genre, string genreSeached)
    {
        var FilterGenre = genre.OrderBy(artist => artist.Artist)
            .Where(genre => genre.Genre!.Contains(genreSeached))
            .Select(artist => artist.Artist)
            .Distinct()
            .ToList();

        foreach (var GenreList in FilterGenre )
        {
            Console.WriteLine($"- {GenreList}");
        }
        Console.WriteLine($"Total of artist: {FilterGenre.Count}");
        
    }
}