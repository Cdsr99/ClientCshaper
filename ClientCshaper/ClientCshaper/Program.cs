using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ClientCshaper.Filter;
using ClientCshaper.LinqFilterArtist;
using ClientCshaper.Model;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta =
                    await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

                var musicJson = JsonSerializer.Deserialize<List<Music>>(resposta);

                if (musicJson != null && musicJson.Count > 0)
                {
                    //musicJson[1].ShowMusic();
                    //LinqFilter.FilterAllMusicGenre(musicJson);
                    //LinqFilterArtist.FilterAllArtist(musicJson);
                    //LinqFilterByGenre.FilterByGenre(musicJson, "hip hop");
                    //LinqFilterArtistMusic.FilterArtistSongs(musicJson, "Eminem");

                    var Playlist = new FavoriteSongs("English2024");

                    Playlist.AddFavoriteSong(musicJson[10]);
                    Playlist.AddFavoriteSong(musicJson[20]);
                    Playlist.AddFavoriteSong(musicJson[25]);
                    Playlist.AddFavoriteSong(musicJson[49]);
                    Playlist.AddFavoriteSong(musicJson[98]);
                    
                    Playlist.ShowFavoriteMusic();

                    Playlist.CreateJsonFile();  



                }
                else
                {
                    Console.WriteLine("No music data found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error with: {ex}");
            }

        }
    }
}