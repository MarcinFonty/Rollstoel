using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "D8266";

            SendUDP(text);

            while (true)
            {
                Listen();
            }
        }

        static void SendUDP(string message)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.43.49");

            byte[] sendbuf = Encoding.ASCII.GetBytes(message);
            IPEndPoint ep = new IPEndPoint(broadcast, 999);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");
        }

        static void Listen()
        {
            const int listenPort = 1001;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);

            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");
                    byte[] bytes = listener.Receive(ref groupEP);

                    Console.WriteLine($"Received broadcast from {groupEP} :");
                    Console.WriteLine($" {Encoding.ASCII.GetString(bytes, 0, bytes.Length)}");
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }
    }
}
