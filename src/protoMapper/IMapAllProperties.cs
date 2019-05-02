using ProtoBuf.Meta;

namespace protoMapper
{
    public interface IMapAllProperties<T>
    {
        IMapObject<Ttype> MapObject<Ttype>();
        RuntimeTypeModel Build();
    }
}