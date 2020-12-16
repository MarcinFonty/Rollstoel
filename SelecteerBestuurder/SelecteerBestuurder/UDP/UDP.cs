using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SelecteerBestuurder
{
    public class UDP
    {

        private string IP;
        private int ClientPoort;
        private int MyPoort;


        //public string text { set; private get; }
        FormSelecteerBestuurder getIpAndPort = new FormSelecteerBestuurder();

        public UDP()
        {
            IP = "192.168.43.49";
            ClientPoort = 999;
            MyPoort = 1001;
        }

        public void SendUDP(string message)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse(IP);

            byte[] sendbuf = Encoding.ASCII.GetBytes(message);
            IPEndPoint ep = new IPEndPoint(broadcast, ClientPoort);

            s.SendTo(sendbuf, ep);

            //Console.WriteLine("Message sent to the broadcast address");
        }

        public void Listen()
        {
            UdpClient listener = new UdpClient(MyPoort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, MyPoort);

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
