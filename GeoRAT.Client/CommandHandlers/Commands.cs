using System;


namespace GeoRAT.Client.CommandHandlers
{
    //This is a commands class. It has 2 simple parameters for constructing commands.
    //Server uses those to communicate with client. Have to share same class in both projects just like Info class.
    //Client needs to know about it 

    [Serializable]
    class Commands
    {
        public string CommandType { get; set; }
        public string CommandParams { get;  set; }

        public Commands(string CommandType, string CommandParams)
        {
            this.CommandType = CommandType;
            this.CommandParams = CommandParams;
        }

        public Commands()
        {

        }
      


    }

}


