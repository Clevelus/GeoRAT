using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeoRAT.Server.Net
{

  
    // This is main connection class. Here we receive socket, pass it to handler method using event 
    // DataHandler does all work with this socket! 
   
   
    class NetworkServer  
    {

        #region Declarations

        public delegate void Connected(Socket s);
        public event Connected OnConnected;
        internal Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
       
        #endregion

        #region Constructor

        public  NetworkServer(string  addr, int port)
        {
            try
            {   
                    IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(addr), port);
                    ServerSocket.Bind(endpoint);
                    ServerSocket.Listen(200);
                    MessageBox.Show(addr + ":" + port, "Listening on", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }

        }

        #endregion

        #region Connection

        //Task based function, just wraps Begin/EndXXX EAP based function, better syntax. 

        private Task<Socket> GetSocket()
        {

            return Task<Socket>.Factory.FromAsync(ServerSocket.BeginAccept, ServerSocket.EndAccept, null);
        }

        //Here we actually receive socket and pass it to handler using OnConnected event 
        public async void Start()
        {
            while (true)
            {
                var acceptsock = await GetSocket(); //Socket accepted 
                OnConnected?.Invoke(acceptsock); //Rest is up to DataHandler, our job is done. 
            }
        }        
    }

    #endregion

}


