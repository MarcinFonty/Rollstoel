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

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.43.49");

            byte [] sendbuf = Encoding.ASCII.GetBytes(text);
            IPEndPoint ep = new IPEndPoint(broadcast, 999);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("Message sent to the broadcast address");

            stringMethode(text);
        }

        static void stringMethode(string message)
        {
            Console.WriteLine(message.Substring(0, 1));
            Console.WriteLine(message.Substring(1));
        }
    }
}
