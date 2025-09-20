using System.Collections.Specialized;
using System.Text;

namespace CSharpFundamentals.Core.Async_TPL
{
    public class SequentialDownloader
    {
        DownloadContent DownloadContent;
        public SequentialDownloader( DownloadContent downloadContent)
        {
                DownloadContent = downloadContent;
        }
        public async  Task  DownloadWebsites()
        {
            Console.WriteLine("Starting sequential download...");

             await DownloadContent.DownloadContent1("https://www.google.com");
            Console.WriteLine("Downloaded Google");

            await DownloadContent.DownloadContent1("https://www.microsoft.com");
            Console.WriteLine("Downloaded Microsoft");

            await DownloadContent.DownloadContent1("https://www.apple.com");
            Console.WriteLine("Downloaded Apple");

            Console.WriteLine("Download complete.");

        }
    }
}
