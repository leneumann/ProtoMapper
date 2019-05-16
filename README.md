# ProtoMapper

Provides a fluent interface when using Protobuf-net (https://github.com/mgravell/protobuf-net) to map classes and properties that represents the contracts of the Language Specification and a serializer/deserializer.


## Example of usage:

### Mapping the classes and properties

```c#
_proto = ProtoMapBuilder.New()
	.MapObject<Catalog>()
        .MapAllProperties()
        .MapObject<Customer>()
        .MapAllProperties()
        .MapObject<Address>()
        .MapAllProperties()
        .Build();
```
### Initializing the serializer
```c#
IProtoBufferSerializer Serializer = new ProtoBufferSerializer(_proto);
```
### When serializing
```c#
 var stream = Serializer.Serialize<Catalog>(catalog);
```
### When deserializing
```c#
 catalog = Serializer.Deserialize<Catalog>(stream);
```

## See a full example in
https://github.com/leneumann/poc-protobuffer/tree/master/src/protobufNet/runTimeTypeModel



## Additional information
This project uses a pipeline of CI/CD using Github + Cirle CI + Codecov + Nuget, thanks to @github/tcfialho
This project was created only to help others to use a fluent interface with protobuf-net (https://github.com/mgravell/protobuf-net) and was used together with the protobuf-net.
https://codecov.io/gh/leneumann/ProtoMapper
