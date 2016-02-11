using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    public class BinaryWorker
    {
        public byte[] messageToBytes(Message msg)
        {
            byte[] bytes = null;
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, msg);
                bytes = stream.ToArray();
            }
            if (bytes.Count() <= 0) return null;
            return bytes;
        }
        public Message bytesToMessage(byte[] bytes)
        {
            Message msg = null;
            IFormatter formatter = new BinaryFormatter();
            if (bytes == null) return null;
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                msg = (Message)formatter.Deserialize(stream);
            }
            return msg;
        }

        public byte[] messageCalcToBytes(MessageCalc msgCalc)
        {
            try
            {
                byte[] bytes = null;
                IFormatter formatter = new BinaryFormatter();
                using (MemoryStream stream = new MemoryStream())
                {
                    formatter.Serialize(stream, msgCalc);
                    bytes = stream.ToArray();
                }
                if (bytes.Count() <= 0) return null;
                return bytes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }
        public MessageCalc bytesToMessageCalc(byte[] bytes)
        {
            MessageCalc msgCalc = null;
            IFormatter formatter = new BinaryFormatter();
            if (bytes == null) return null;
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                msgCalc = (MessageCalc)formatter.Deserialize(stream);
            }
            return msgCalc;
        }

    }
}
