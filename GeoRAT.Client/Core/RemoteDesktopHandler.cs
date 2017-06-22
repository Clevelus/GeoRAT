

using System;
using System.Net;
using System.Net.Sockets;

namespace GeoRAT.Client.Core
{
    class RemoteDesktopHandler
    {
        private Socket UDPSender;

       public RemoteDesktopHandler()
       {
           UDPSender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);

       }

        private void Connected(IAsyncResult result)
        {
            
        }
         


    }
}
