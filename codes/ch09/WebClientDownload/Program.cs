using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"http://www.baidu.com";
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string pageHtml = client.DownloadString(url);
            Console.WriteLine(pageHtml);
            File.WriteAllText(@"baidu.html", pageHtml);
        }
    }
}
