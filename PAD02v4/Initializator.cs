using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    public class Initializator
    {
        string[] arg;
        public Initializator(string[] arg)
        {
            this.arg = arg;
        }

        public bool isMaven()
        {
            if (arg.Count() <= 0) return false;
            if (arg[0] == "0") return false;
            else return true;
        }

        public bool isWhite()
        {
            if (arg.Count() <= 1) return false;
            if (arg[1] == "0") return false;
            else return true;
        }
        public int mavensPort()
        {
            if (arg.Count() <= 2) return -1;
            int port = Int32.Parse(arg[2]);
            return port;
        }

        public int nodesPort()
        {
            if (arg.Count() <= 3) return -1;
            int port = Int32.Parse(arg[3]);
            return port;
        }
        public string xmlName()
        {
            if (arg.Count() <= 4) return null;
            return arg[4];
        }

        public int getNodeNumber()
        {
            if (arg.Count() <= 5) return 0;
            int nodeNum = Int32.Parse(arg[5]);
            return nodeNum;
        }

        public int getWhiteNodeNum()
        {
            if (arg.Count() <= 6) return 0;
            int nodeNum = Int32.Parse(arg[6]);
            return nodeNum;
        }

    }
}
