using ClientCshaper.Model;

namespace ClientCshaper.Filter;

internal class LinqFilter
{
    public static void FilterAllMusicGenre(List<Music> musics)
    {
        var AllGenreSogns = musics.Select(genre => genre.Genre).Distinct().ToList();

        foreach (var genre in AllGenreSogns)
        {
            Console.WriteLine($"- {genre}");
        }
    }
}