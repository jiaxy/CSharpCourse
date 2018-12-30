using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener
                (IPAddress.Parse("127.0.0.1"), 10000);
            listener.Start();
            Console.WriteLine("开始监听端口10000....");
            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine("客户端连接成功。");
            NetworkStream stream = client.GetStream();
            string message=null;
            do
            {
                byte[] data = new byte[1024];
                int length = stream.Read(data, 0, 1024);//最多取1024个字符
                message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("收到了信息：" + message);
            } while (message != "q");

            Console.WriteLine("客户端断开连接。");
            stream.Close();
            client.Close();
            listener.Stop();//停止监听
            Console.ReadKey();
        }
    }
}
