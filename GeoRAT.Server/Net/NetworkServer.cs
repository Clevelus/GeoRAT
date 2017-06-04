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
   
     // Delegates and events 
        
        public delegate void Connected(Socket s);
        public event Connected OnConnected;

        
        // Fields and properties 
        //
        private Socket ServerSocket;
        public string  IP { get; private set; }
        public int     PORT { get; private set; }

        /// <summary>
        /// Here we construct our class 
        /// </summary>
        /// <param name="IP"> //IP to listen</param>
        /// <param name="PORT"> //Port to listen </param>
        /// 
        public NetworkServer(string IP, int PORT)
        {
            this.IP = IP;
            this.PORT = PORT;
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerSocket.Bind(new IPEndPoint(IPAddress.Parse(IP), PORT));
            ServerSocket.Listen(200);

        }

        

       
        //Task based function, just wraps Begin/EndXXX EAP based function, better syntax. 
        private Task<Socket> GetSocket()
        {
            return Task<Socket>.Factory.FromAsync(ServerSocket.BeginAccept, ServerSocket.EndAccept, null); 
        }

        //Here we actually receive socket and pass it to handler using OnConnected event 
        public async void Start()
        {
            try
            {
                while (true) //Keeps accepting new sockets 
                {
                    var _acceptsock = await GetSocket(); //Socket accepted 
                    OnConnected?.Invoke(_acceptsock); //Rest is up to DataHandler, our job is done. 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "OOPS DOOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
            
        }
    }


