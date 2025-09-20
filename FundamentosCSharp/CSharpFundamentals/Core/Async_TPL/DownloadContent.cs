namespace CSharpFundamentals.Core.Async_TPL
{
    public  class DownloadContent
    {
        public   async Task<string>  DownloadContent1(string url)
        {
           
            await  Task.Delay(2000);
            return   $"Content from {url}";
            
            
        }
    }
}
