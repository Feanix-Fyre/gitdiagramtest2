using System;
using System.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization;

public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
{
	private static readonly object TypeContractCacheLock;

	private static readonly DefaultJsonNameTable NameTable;

	private static Dictionary<StructMultiKey<Type, Type>, JsonContract>? _contractCache;

	public override JsonContract ResolveContract(Type type)
	{
		return null;
	}

	internal override DefaultJsonNameTable GetNameTable()
	{
		return null;
	}
}
