using System;
using System.Net.Sockets;
using System.Threading;


namespace Cliet
{
    class DataReader
    {

        //delegates and events

        public delegate void Received( byte[] buffer, int MessageSize);
        public event Received OnReceived;
        public delegate void Disconnected(Socket s);
        public event Disconnected OnDisconnected;

        //

        //fields and properties 
        private Socket ClientReader; 
        private byte[] lenbuffer = new byte[4];
        
        public DataReader(Socket s)
        {
            ClientReader = s;
            ClientReader.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, ReceivedCallback, null);
        }

        //Begin reading data from server here 

        private void ReceivedCallback(IAsyncResult result)
        {
            try
            {
                int total = ClientReader.EndReceive(result);
                int left = sizeof(int) - total; // How much bytes left to receive. sizeof(int) indicates that we want to receive 4 bytes in total 
                while (ClientReader.Available < left) //Wait for rest of bytes
                {
                    Thread.SpinWait(100);
                }
                ClientReader.Receive(lenbuffer, total, left, SocketFlags.None); //Get all bytes now 
                var len = BitConverter.ToInt32(lenbuffer, 0); //Deserialize received bytes back to INT and get length of packet
                ReceiveMessage(len); //Begin reading incoming packets based on length now 
                ClientReader.BeginReceive(new byte[] { 0 }, 0, 0, SocketFlags.None, ReceivedCallback, null);
            }
            catch
            {
                 
                OnDisconnected?.Invoke(ClientReader);
            }
        }


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
                    IAsyncResult result = ClientReader.BeginReceive(buffer, total, size, SocketFlags.None, null, null);
                    result.AsyncWaitHandle.WaitOne(ClientReader.ReceiveTimeout);
                    int received = ClientReader.EndReceive(result);
                    total += received;
                    if (received == 0)
                        break;
                } while (total < size);
                OnReceived?.Invoke(buffer, size);

            }
            catch
            {

                OnDisconnected?.Invoke(ClientReader); 
            }
        }


        //Send data to server via this function 
        public void Send(byte[] buf)
        {
            ClientReader.BeginSend(buf, 0, buf.Length, SocketFlags.None, SendCb, null);
        }

        private void SendCb(IAsyncResult result)
        {
            ClientReader.EndSend(result);
        }
        
    }

    
}
