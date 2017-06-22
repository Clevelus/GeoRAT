

namespace GeoRAT.Core.Interfaces
{
     interface ICommandSerializer<T> where T : class
    {
        byte[] Serialize(T command);
        T Deserialize(byte[] buffer); 
    }
}
