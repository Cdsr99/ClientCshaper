using ClientCshaper.Model;

namespace ClientCshaper.LinqFilterArtist;

internal class LinqFilterArtist
{
    public static void FilterAllArtist(List<Music> artist)
    {
        var AllArtist = artist.OrderBy(artist => artist.Artist).Select(artist => artist.Artist).Distinct().ToList();

        foreach (var singer in AllArtist)
        {
            Console.WriteLine($"- {singer}");
        }
            Console.WriteLine($"Total of artist: {AllArtist.Count}");
    }
}