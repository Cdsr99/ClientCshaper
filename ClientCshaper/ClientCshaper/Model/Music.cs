using System.Text.Json.Serialization;

namespace ClientCshaper.Model;

internal class Music
{
    [JsonPropertyName("song")]
    public string? name { get; set; }
    
    [JsonPropertyName("artist")]
    public string? singer { get; set; }

    [JsonPropertyName("duration_ms")]
    public string? time { get; set; }

    [JsonPropertyName("genre")]
    public string? type { get; set; }

    public void ShowMusic()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"singer: {singer}");
        //Console.WriteLine($"time: {time}");
        Console.WriteLine($"type: {type}");
    }
}