using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Puntero_Windows
{
    class TcpServerCode
    {
        IPEndPoint ipEnd;
        Socket sock;
        bool run = true;
        public TcpServerCode(int port)
        {
            ipEnd = new IPEndPoint(IPAddress.Any, port);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            sock.Bind(ipEnd);
        }
        public void StartServer()
        {
            try
            {
                sock.Listen(100);
                Socket clientSock = sock.Accept();
                byte[] clientData = new byte[1];
                clientSock.Receive(clientData);
                string getStr = Encoding.ASCII.GetString(clientData);
                Form1.Singletone.Interprete(getStr);
                if (run)
                    StartServer();
                else
                {
                    clientSock.Close();
                    sock.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Stop()
        {
            run = false;
        }
    }
}
