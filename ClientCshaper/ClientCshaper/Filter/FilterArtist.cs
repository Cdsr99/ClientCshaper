using ClientCshaper.Model;

namespace ClientCshaper.Filter;

internal class FilterArtist
{
    public static void FilterAllArtist(List<Music> artist)
    {
        var AllArtist = artist.Select(artist => artist.Artist).Distinct().ToList();

        foreach (var singer in AllArtist)
        {
            Console.WriteLine($"- {singer}");
        }
    }
}