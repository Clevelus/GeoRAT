


namespace GeoRAT.Client.PacketStruct
{
    //Packet serializer interface
    public interface IPacketSerializer
    {
        byte[] Serialize(Info i);
        Info Deserialize(byte[] buffer); 

    }
}
