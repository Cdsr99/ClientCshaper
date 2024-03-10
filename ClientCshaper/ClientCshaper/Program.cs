using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using ClientCshaper.Model;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var musicJson = JsonSerializer.Deserialize<List<Music>>(resposta);
            
            if (musicJson != null && musicJson.Count > 0)
            {
                musicJson[0].ShowMusic();
            }
            else
            {
                Console.WriteLine("No music data found.");
            }
        }
    }
}