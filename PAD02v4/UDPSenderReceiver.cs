using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PAD02v4
{
    public class UDPSenderReceiver
    {
        public async Task sendUnicastBytesAsync(byte[] bytes, int port)
        {
            try
            {
                if (bytes.Count() <= 0) return;
                UdpClient trasport = new UdpClient();
                trasport.Connect("127.0.0.1", port);
                await trasport.SendAsync(bytes, bytes.Length);
                trasport.Close();
            }
            catch { }
        }

        public async Task<UdpReceiveResult> receiveBytesAsync(int port)
        {
            while (true)
            {
                try
                {
                    UdpClient trasport = new UdpClient(port);
                    UdpReceiveResult result = await trasport.ReceiveAsync();
                    trasport.Close();
                    return result;
                }
                catch 
                {
                    Thread.Sleep(10);
                }
            }
            
        }

        public async Task sendBroadcastBytesAsync(byte[] bytes, int port)
        {
            try
            {
                if (bytes.Count() <= 0) return;
                UdpClient trasport = new UdpClient();
                trasport.Connect(IPAddress.Broadcast, port);
                await trasport.SendAsync(bytes, bytes.Length);
                trasport.Close();
            }
            catch { }
        }
    }
}
