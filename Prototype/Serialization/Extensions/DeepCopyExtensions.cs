using System.Xml.Serialization;
using MessagePack;
using MessagePack.Resolvers;

namespace Prototype.Serialization.Extensions;

public static class DeepCopyExtensions
{
    public static T DeepCopyMessagePack<T>(this T self)
    {
        var options = ContractlessStandardResolver.Options;
        var bytes = MessagePackSerializer.Serialize(self, options);
        return MessagePackSerializer.Deserialize<T>(bytes, options);
    }

    public static T DeepCopyXml<T>(this T self)
    {
        using var stream = new MemoryStream();
        var serializer = new XmlSerializer(typeof(T));
        serializer.Serialize(stream, self);
        stream.Position = 0;
        return (T)serializer.Deserialize(stream);
    }
}