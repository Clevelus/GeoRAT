
namespace GeoRAT.Server.CommandHandlers
{
     interface ICommandSerializer
    {
        byte[] Serialize(Commands cmd);
        Commands Deserialize(byte[] buffer); 
    }
}
