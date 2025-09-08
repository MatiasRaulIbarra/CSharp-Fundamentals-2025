namespace CSharpFundamentals.Core.Models.Gaming
{
    public class VideoGame
    {
        public string Title { get; set; }
        public string Platform { get; set; }

        public VideoGame (string title, string platform)
        {
            Title = title;
            Platform = platform;
        }
    }
}
