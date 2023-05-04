using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           
            var user = new User();
            
            var Downloader = new YoutubeDownloader("https://www.youtube.com/watch?v=fcqHMKoCHH4");

            
            var GetInfo = new GetAsync(Downloader);
            user.SetCommand(GetInfo);
            await user.Run();

            
            var download = new DownloadAsync(Downloader);
            user.SetCommand(download);
            await user.Run();
        }
    }
}
