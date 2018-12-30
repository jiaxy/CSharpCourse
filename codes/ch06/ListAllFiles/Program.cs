using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAllFiles
{
    class Program
    {
        public static void Main(string[] args){
            ListFiles(new DirectoryInfo(@"C:\360Downloads"));
        }

        private static void ListFiles(FileSystemInfo info){
            if (!info.Exists) return;
            if(info is FileInfo) {
                Console.WriteLine(
                    info.FullName + "\t" + ((FileInfo)info).Length);
            }else{
                FileSystemInfo[] files = 
                    ((DirectoryInfo)info).GetFileSystemInfos();
                Array.ForEach(files, 
                    finfo => ListFiles(finfo));
            }
        }
    }
}
