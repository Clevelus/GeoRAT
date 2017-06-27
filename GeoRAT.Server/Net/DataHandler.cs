using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using GeoRAT.Core.Commands;
using GeoRAT.Core.Compressor;

namespace GeoRAT.Server.Net
{
    /// <summary>
    /// This class handles all data reading  and sending 
    /// </summary>
    class DataHandler
    {
        #region Declarations

        public delegate void Received(byte[] buf, Socket received);
        public event Received OnReceived;
        public delegate void Disconnected(Socket s);
        public event Disconnected OnDisconnected; 


        private Socket DataSocket;  //Reads data sent by client, first it reads data length, then data itself 
        private Socket DummySocket;  //Actually does nothing, just checks if socket is connected, if not, raises disconnected event
        byte[] PrefixBuffer = new byte[4]; //Buffer to store Message length 
        private static int MessageLength = 0; //Message length sent by client 
        #endregion

        #region Constructor

        public DataHandler(Socket s)
        {
            DataSocket = s;
            DummySocket = DataSocket;
            DataSocket.BeginReceive(PrefixBuffer, 0, 4, SocketFlags.None, ReceivedCallback, null); //Begin reading asynchronously
            DummySocket.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, Dummy, null);  //Dummy function 

        }

        #endregion


        #region Dummy

        //Dummy Callback, Raises disconnection event  if it can't read from socket 

        private void Dummy(IAsyncResult result)
        {
            try
            {
                DummySocket.EndReceive(result);
                DummySocket.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, Dummy, null);
            }
            catch
            {
               
                OnDisconnected?.Invoke(DataSocket);
           }

        }
        #endregion

        #region Receive_Length

        //Here we actually begin reading data from socket. Reads Length of message sent by client in this function 
        private void ReceivedCallback(IAsyncResult result)
        {
            try
            {
                int total = DataSocket.EndReceive(result);
                int left = sizeof(int) - total; // How much bytes left to receive.  
                do
                {
                    var recv = DataSocket.Receive(PrefixBuffer, total, left, SocketFlags.None);
                    left -= recv;
                } while (left != 0); 
                var len = BitConverter.ToInt32(PrefixBuffer, 0); //Deserialize received bytes back to INT and get length of packet
                MessageLength = len; //Assign length to global constant 
                ReceiveMessage(MessageLength); //Begin reading incoming packets based on length now 

            }
            catch
            {
                OnDisconnected?.Invoke(DataSocket);

            }
        }


        #endregion

        #region Receive_Data

        //Reads incoming data from client, based on length of data we got earlier 
        //Keeps reading until it gets exact amount of bytes we need 
        private void ReceiveMessage(int size)
        {
            try
            {
                int total = 0;

                byte[] buffer = new byte[size];
                do
                {
                    IAsyncResult result = DataSocket.BeginReceive(buffer, total, size, SocketFlags.None, null, null);
                    result.AsyncWaitHandle.WaitOne(DataSocket.ReceiveTimeout);
                    int received = DataSocket.EndReceive(result);
                    total += received;
                    if (received == 0)
                        break;
                } while (total < size);
                OnReceived?.Invoke(buffer, DataSocket);

            }
            catch
            {

                OnDisconnected?.Invoke(DataSocket);
            }
        }

        #endregion


        #region Send
        public void Send(Commands command)

        {
            try
            {
                CommandSerializer serializer = new CommandSerializer();
                byte[] packet = serializer.Serialize(command);
                var cmpr = Compression.Compress(packet);
                var len2 = cmpr.Length;
                DataSocket.Send(BitConverter.GetBytes(len2));
                DataSocket.BeginSend(cmpr, 0, cmpr.Length, SocketFlags.None, SentCallback, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SentCallback(IAsyncResult result)
        {
            DataSocket.EndSend(result);
        }



        #endregion

    }
}
