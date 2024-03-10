namespace ClientCshaper.Model;

internal class FavoriteSongs
{
    public string? PlaylistName { get; set; }
    public List<Music> ListOfFavoriteSongs { get; set; }

    public FavoriteSongs(string? playlistName)
    {
        PlaylistName = playlistName;
        ListOfFavoriteSongs = new List<Music>();
    }

    public void AddFavoriteSong(Music music)
    {
        ListOfFavoriteSongs.Add(music);
    }

    public void ShowFavoriteMusic()
    {
        Console.WriteLine($"This is your list of favorite songs from {PlaylistName}");
        foreach (var song in ListOfFavoriteSongs)
        {
            Console.WriteLine($"{song.Title} from {song.Artist}");
        }
    }
}