using ProtoBuf.Meta;
using protoMapper;
using Xunit;

namespace tests
{
    public class ProtoBufferSerializerUnitTests
    {
        public RuntimeTypeModel _runtimeTypeModel;
        public readonly IProtoBufferSerializer _protoBufferSerializer;
        public ProtoBufferSerializerUnitTests()
        {
            _runtimeTypeModel = ProtoMapBuilder.New()
                                .MapObject<FakePoco>()
                                .MapAllProperties()
                                .Build();
            _protoBufferSerializer = new ProtoBufferSerializer(_runtimeTypeModel);
        }

        [Fact]
        public void WhenSerializingNullObjectShouldReturnAnEmptyByteArray()
        {
            FakePoco fake = null;
            byte[] expected = new byte[] { };
            var actual = _protoBufferSerializer.Serialize(fake);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenDeserializingNullByteArrayShouldReturnDefaultType()
        {
            byte[] fake = null;
            var expected = default(FakePoco);
            var actual = _protoBufferSerializer.Deserialize<FakePoco>(fake);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenSerializingValidObjectShouldDeserializeWithSuccessToTheSameTypeObject()
        {
            var expected = new FakePoco() { FakeString = "fake", FakeInt = 10 };
            var serializedObject = _protoBufferSerializer.Serialize(expected);
            var actual = _protoBufferSerializer.Deserialize<FakePoco>(serializedObject);
            Assert.IsType<FakePoco>(actual);
            Assert.Equal(expected.FakeString, actual.FakeString);
            Assert.Equal(expected.FakeInt, actual.FakeInt);
        }
    }
}