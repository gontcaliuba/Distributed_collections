using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    public class TCPServer
    {      
        Socket sListener;
        IPEndPoint ipEndPoint;
        public TCPServer(IPAddress ipAddr, int port) 
        {
            this.ipEndPoint = new IPEndPoint(ipAddr, port);
            sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sListener.Bind(ipEndPoint);
            sListener.Listen(100);
        }

        public byte[] TCPReceive()
        {
            try
            {
                Socket handler = sListener.Accept();

                byte[] message_len = new byte[4];
                byte[] bytes = new byte[20480];
                handler.Receive(message_len);
                int msg_size = BitConverter.ToInt32(message_len, 0);
                int bytesRec = handler.Receive(bytes, msg_size, SocketFlags.None);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

                return bytes.Take(bytesRec).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        ~TCPServer() 
        {
            sListener.Close();
        }
    }
}
