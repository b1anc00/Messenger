using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static TcpListener listener;
        static List<TcpClient> clients = new List<TcpClient>();

        static void Main()
        {
            listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            Console.WriteLine("Сервер запущен...");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                Thread thread = new Thread(HandleClient);
                thread.Start(client);
            }
        }

        static void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                try
                {
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    if (bytes == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytes);
                    Console.WriteLine(message);

                    foreach (var c in clients)
                    {
                        if (c != client)
                            c.GetStream().Write(buffer, 0, bytes);
                    }
                }
                catch { break; }
                ;
            }
            clients.Remove(client);
            client.Close();
        }
    }
}
