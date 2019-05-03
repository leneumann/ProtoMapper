using System;
using ProtoBuf.Meta;

namespace ProtoMapper
{
    public class ProtoMapBuilder
    {
        public readonly RuntimeTypeModel _runtimeTypeModel;
        private ProtoMapBuilder() => _runtimeTypeModel = TypeModel.Create();
        public static ProtoMapBuilder New() => new ProtoMapBuilder();
        public IMapObject<T> MapObject<T>() => new ProtoMapObject<T>(this);
    }
}
