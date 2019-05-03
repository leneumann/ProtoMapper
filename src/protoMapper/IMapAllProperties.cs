using ProtoBuf.Meta;

namespace ProtoMapper
{
    public interface IMapAllProperties<T>
    {
        IMapObject<Ttype> MapObject<Ttype>();
        RuntimeTypeModel Build();
    }
}