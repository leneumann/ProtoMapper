using System;
using System.Linq.Expressions;

namespace protoMapper
{
    public interface IMapObject<T>
    {
        IMapProperty<T> MapProperty(Expression<Func<T, object>> expression);
        IMapAllProperties<T> MapAllProperties();
    }
}