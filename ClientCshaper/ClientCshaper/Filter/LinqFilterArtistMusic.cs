using ClientCshaper.Model;

namespace ClientCshaper.Filter;

internal class LinqFilterArtistMusic
{
    public static void FilterArtistSongs(List<Music> ArtistSongs, string singer)
    {
        var songs = ArtistSongs.Where(artist => artist.Artist!.Contains(singer))
            .Select(music => music.Title)
            .Distinct()
            .ToList();

        foreach (var song in songs)
        {
            Console.WriteLine($"- {song}");
        }
        Console.WriteLine($"Total of songs: {songs.Count}");
    }
}