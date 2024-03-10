using System.Text.Json.Serialization;

namespace ClientCshaper.Model
{
    public class Music
    {
        // Define properties of Music class
        [JsonPropertyName("song")]

        public string Title { get; set; }
        
        [JsonPropertyName("artist")]
        public string Artist { get; set; }
        
        [JsonPropertyName("year")]
        public string Year { get; set; }
        
        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        // Constructor
        public Music(string title, string artist, string year, string genre)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Genre = genre;
        }

        // Method to show music details
        public void ShowMusic()
        {
            Console.WriteLine($"Title: {Title}, Artist: {Artist}, Year: {Year}, Genre: {Genre}");
        }
    }
}