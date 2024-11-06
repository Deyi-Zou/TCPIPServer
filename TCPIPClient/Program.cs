using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace TCPIPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client tcpClient = new Client();
            tcpClient.Run();

            Console.WriteLine("Press Enter to End");
            Console.ReadLine();
        }
        
    }
}
