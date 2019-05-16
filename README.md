# ProtoMapper

Provides a fluent interface to map classes and properties that represents the contracts of the Language Specification and a serializer/deserializer.


##Example of usage:

###Mapping the classes and properties

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
###Initializing the serializer
```c#
IProtoBufferSerializer Serializer = new ProtoBufferSerializer(_proto);
```
###When serializing
```c#
 var stream = Serializer.Serialize<Catalog>(catalog);
```
###When deserializing
```c#
 catalog = Serializer.Deserialize<Catalog>(stream);
```

##See a full example in
https://github.com/leneumann/poc-protobuffer/tree/master/src/protobufNet/runTimeTypeModel
