




using GeoRAT.Core.PacketStruct;

namespace GeoRAT.Core.Interfaces
{
    //Packet serializer interface
    public interface IPacketSerializer<T> where T : class
    {
        byte[] Serialize(T i);
        T Deserialize(byte[] buffer); 

    }
}
