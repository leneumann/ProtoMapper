using System;
using ProtoMapper;
using Xunit;

namespace tests
{
    public class ProtoMapObjectUnitTests
    {
        public readonly ProtoMapBuilder protoMapBuilder;

        public ProtoMapObjectUnitTests()
        {
            protoMapBuilder = ProtoMapBuilder.New();
        }
        
        [Fact]
        public void MapObjectMethodShouldReturnAInstanceOfProtoMapObject()
        {
            var protoMapObject = new ProtoMapObject<FakePoco>(protoMapBuilder);
            var obj = protoMapObject.MapObject<FakePoco>();
            Assert.Equal(typeof(ProtoMapObject<FakePoco>), obj.GetType());
        }

        [Fact]
        public void MapPropertyMethodShouldReturnItSelf()
        {
            var protoMapObject = new ProtoMapObject<FakePoco>(protoMapBuilder);
            var obj = protoMapObject.MapProperty(x => x.FakeString).MapProperty(x => x.FakeInt);
            Assert.Equal(typeof(ProtoMapObject<FakePoco>), obj.GetType());
        }

        [Fact]
        public void MapAllPropertiesMethodShouldReturnItSelf()
        {
            var protoMapObject = new ProtoMapObject<FakePoco>(protoMapBuilder);
            var obj = protoMapObject.MapAllProperties();
            Assert.Equal(typeof(ProtoMapObject<FakePoco>), obj.GetType());

        }

        [Fact]
        public void BuildMethodShouldReturnTheRuntimeTypeModel()
        {
            var protoMapObject = new ProtoMapObject<FakePoco>(protoMapBuilder);
            var obj = protoMapObject.MapAllProperties().Build();
            Assert.Equal(typeof(ProtoBuf.Meta.RuntimeTypeModel), obj.GetType());
        }
    }
}
