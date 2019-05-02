using System;
using System.Linq.Expressions;
using ProtoBuf.Meta;

namespace protoMapper
{
    public interface IMapProperty<T>
    {
        IMapProperty<T> MapProperty(Expression<Func<T, object>> expression);
        IMapObject<Ttype> MapObject<Ttype>();
        RuntimeTypeModel Build();
    }
}