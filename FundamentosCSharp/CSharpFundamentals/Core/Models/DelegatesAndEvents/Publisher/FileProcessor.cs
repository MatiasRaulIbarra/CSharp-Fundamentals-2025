using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals.Core.Models.DelegatesAndEvents.Publisher
{
    public class FileProcessor
    {
        
       
        public  delegate void  ProgressHandler(int percentage);
        public event ProgressHandler ProgressUpdate;

        public void  ProcessFile(string fileName)
        {
            for(int i = 0; i < 100; i+=10)
            {
                ProgressUpdate?.Invoke(i);
            }
        }

    }
}
