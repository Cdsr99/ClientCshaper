using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ClientCshaper.Filter;
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
                    musicJson[1].ShowMusic();
                    LinqFilter.FilterAllMusicGenre(musicJson);

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