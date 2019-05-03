using System;
using System.Linq.Expressions;

namespace ProtoMapper
{
    public interface IMapObject<T>
    {
        IMapProperty<T> MapProperty(Expression<Func<T, object>> expression);
        IMapAllProperties<T> MapAllProperties();
    }
}