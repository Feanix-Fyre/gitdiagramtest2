using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization;

internal class SerializationBinderAdapter : ISerializationBinder
{
	public readonly SerializationBinder SerializationBinder;

	public SerializationBinderAdapter(SerializationBinder serializationBinder)
	{
	}

	public Type BindToType(string? assemblyName, string typeName)
	{
		return null;
	}

	public void BindToName(Type serializedType, out string? assemblyName, out string? typeName)
	{
		assemblyName = null;
		typeName = null;
	}
}
