using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    public class TCPClient
    {
        Socket sender;
        IPEndPoint ipEndPoint;
        public TCPClient(IPAddress ipAddr, int port)
        {
            this.ipEndPoint = new IPEndPoint(ipAddr, port);
            sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        void open()
        {
            try
            {
                sender.Connect(ipEndPoint);
            }
            catch
            {
                sender = null;
            }
        }

        void close()
        {
            try
            {
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch { }
        }

        public void TCPSend(byte[] bytes)
        {
            if (sender == null) return;
            try
            {
                open();
                byte[] message_size = BitConverter.GetBytes((int)bytes.Count());
                sender.Send(message_size);
                sender.Send(bytes);
                close();
            }
            catch 
            {
                Console.WriteLine(bytes.Count());
                Console.WriteLine("Can't send!");
            }
        }
    }
}
