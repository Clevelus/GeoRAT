
namespace GeoRAT.Client.CommandHandlers
{
     interface ICommandSerializer
    {
        byte[] Serialize(Commands cmd);
        Commands Deserialize(byte[] buffer); 
    }
}
