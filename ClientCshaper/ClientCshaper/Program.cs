using System.Text.Json;
using ClientCshaper.Model;

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    //Console.WriteLine(resposta);

    var musiac = JsonSerializer.Deserialize<List<Music>>(resposta);
    
    musiac[0].ShowMusic();


}